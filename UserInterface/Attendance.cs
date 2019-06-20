using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Attendance : Form
    {
        private List<Period> Periods;
        BindingSource Source;

        public Attendance()
        {
            InitializeComponent();
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            Periods.Remove(FindSelectedPeriod());
            RefreshPanel();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            Period period = new Period(FirstDay.Value, LastDay.Value);
            Periods.Add(period);
            RefreshPanel();
        }
        #region Miscellaneous function
        public class Period
        {
            public DateTime FirstDay { get; }
            public DateTime LastDay { get; }

            public Period(DateTime f, DateTime l)
            {
                FirstDay = f;
                LastDay = l;
            }

            public int Length => (LastDay - FirstDay).Days;
            public string Display => $"{Length} {(Length == 1 ? "day" : "days")}: {FirstDay.ToShortDateString()} - {LastDay.ToShortDateString()}";
        }
        private Period FindSelectedPeriod()
        {
            Period Target = Periods[0];
            foreach (var item in Periods)
            {
                if (item.Display == ((Period)HistoryBox.SelectedItem).Display)
                {
                    Target = item;
                    break;
                }
            }
            return Target;
        }
        private void RefreshPanel()
        {
            Source = new BindingSource
            {
                DataSource = Periods,
            };
            HistoryBox.DataSource = Source;
            HistoryBox.DisplayMember = "Display";
        }
        #endregion

        
    }
}
