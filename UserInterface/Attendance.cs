using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace UserInterface
{
    public partial class Attendance : Form
    {
        private List<Period> Periods;
        private BindingSource Source;
        private readonly string EmployeeName;

        public Attendance(string name)
        {
            InitializeComponent();
            EmployeeName = name;
            CheckFileAvailability();
            Periods = RetrieveData();
        }
        ~Attendance()
        {
            Source.Dispose();
        }

        #region Control Handler
        private void DButton_Click(object sender, EventArgs e)
        {
            Periods.Remove(FindSelectedPeriod());
            RefreshPanel();
            PushData();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            Period period = new Period(FirstDay.Value, LastDay.Value);
            Periods.Add(period);
            RefreshPanel();
            PushData();
        }
        #endregion

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

        private List<Period> RetrieveData()
        {
            List<Period> periods;
            string Data = System.IO.File.ReadAllText(GetPath(EmployeeName));
            try
            {
                periods = JsonConvert.DeserializeObject<List<Period>>(Data);
            }
            catch
            {
                periods = new List<Period>();
            }
            return periods;
        }

        private void PushData()
        {
            string Data = JsonConvert.SerializeObject(Periods);
            System.IO.File.WriteAllText(GetPath(EmployeeName), Data);
        }

        private string GetPath(string name)
        {
            return System.IO.Path.Combine("Data", string.Concat(name.Split(' ')) + ".OFF");
        }

        private void CheckFileAvailability()
        {
            if (!System.IO.File.Exists(GetPath(EmployeeName)))
            {
                System.IO.File.Create(GetPath(EmployeeName));
            }         
        }
        #endregion
    }
}
