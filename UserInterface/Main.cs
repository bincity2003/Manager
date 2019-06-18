using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Backend;

namespace UserInterface
{
    public partial class Main : Form
    {
        #region Data declaration and definition

        const string DataPath = "Data";
        const string Version = "V1.1";
        IOManager Manager = new IOManager(DataPath);
        XElement Configs;

        string EmployeeName;
        List<Entry> Entries;
        BindingSource source;

        #endregion

        #region Startup

        public Main()
        {
            InitializeComponent();
            Setup();
        }
        private void Setup()
        {        
            Directory.CreateDirectory(DataPath);
            try
            {
                WriteLog("Reading configs");
                Configs = XElement.Load(@"config.xml");
            }
            catch
            {
                WriteLog("No configs");
                throw new Exception("Configs missing!");
            }

            Configs.Element("version").Value = Version;
            Configs.Save("config.xml");

            Text = "Manager - " + Version;

            LoadEmployees();
        }

        #endregion

        #region Control Handler

        private void ESelect_SelectedIndexChanged(object sender, EventArgs e)
        {         
            EmployeeName = (string)ESelect.SelectedValue;
            WriteLog("Employee changed to " + EmployeeName);
            Entries = RetrieveData();
            RefreshPanel();
        }
        private void AButton_Click(object sender, EventArgs e)
        {
            if (AButton.Text == "Edit")
            {         
                Entry Target = FindSelectedEntry();
                WriteLog("Save existing entry: " + Target.Display);
                Entries.Remove(Target);
                AButton.Text = "Add";
            }

            Entry entry;
            if (DatePicker.Enabled)
            {
                entry = new Entry(DText.Text, PCheck.Checked, DatePicker.Value);              
            }
            else
            {
                entry = new Entry(DText.Text, PCheck.Checked, DateTime.Today);
            }

            WriteLog("Add new entry: " + entry.Display);
            Entries.Add(entry);
            RefreshPanel();
            ResetField();
        }
        private void DButton_Click(object sender, EventArgs e)
        {
            Entry Target = FindSelectedEntry();
            WriteLog("Delete entry: " + Target.Display);
            Entries.Remove(Target);
            RefreshPanel();
        }
        private void EButton_Click(object sender, EventArgs e)
        {
            Entry Item = (Entry)TShow.SelectedValue;
            WriteLog("Save existing entry: " + Item.Display);
            DText.Text = Item._desc;
            DatePicker.Value = Item._dl;
            PCheck.Checked = Item.Prioritized;
            AButton.Text = "Edit";
        }
        private void SButton_Click(object sender, EventArgs e)
        {
            PushEntries();
            WriteLog("Save data for " + EmployeeName);
        }
        private void EditEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteLog("Open employee editor");
            Form prop = new Editor(Configs);
            prop.Activate();
            prop.Show();
        }
        private void DCheck_CheckedChanged(object sender, EventArgs e)
        {
            DatePicker.Enabled = DCheck.Checked;
        }
        private void AForm_Click(object sender, EventArgs e)
        {
            Form form = new Attendance();
            form.Activate();
            form.Show();
        }

        #endregion

        #region Miscellaneous Function

        private List<Entry> RetrieveData()
        {
            //List<Entry> entries = new List<Entry>();
            //entries.Add(new Entry("Test", true, DateTime.Today));
            //return entries;
            return Manager.Unpack(EmployeeName);
        }
        private void RefreshPanel()
        {
            source = new BindingSource
            {
                DataSource = Entries
            };
            TShow.DataSource = source;
            TShow.DisplayMember = "Display";
        }
        private Entry FindSelectedEntry()
        {
            Entry Target = Entries[0];
            foreach (var item in Entries)
            {
                if (item.Display == ((Entry)TShow.SelectedValue).Display)
                {
                    Target = item;
                    break;
                }
            }

            return Target;
        }
        private void ResetField()
        {
            DText.Text = "";
            DatePicker.Value = DateTime.Today;
            PCheck.Checked = false;
        }
        private void PushEntries()
        {
            Manager.Pack(EmployeeName, Entries);
        }
        private void LoadEmployees()
        {
            int Count = int.Parse(Configs.Element("employee").Attribute("count").Value);
            List<string> Employees = new List<string>();

            for (int i = 1; i <= Count; i++)
            {
                Employees.Add(Configs.Element("employee").Element($"e{i}").Value);
            }

            BindingSource source = new BindingSource
            {
                DataSource = Employees
            };
            ESelect.DataSource = source;
        }
        private void WriteLog(string data)
        {
            LogWriter.Write("log.txt", data, true);
        }


        #endregion

    }
}