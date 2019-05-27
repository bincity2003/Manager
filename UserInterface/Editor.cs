using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UserInterface
{
    public partial class Editor : Form
    {
        XElement Configs;

        public Editor(XElement configs)
        {
            InitializeComponent();
            Configs = configs;
            LoadData();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            int Count = EText.Lines.Length;
            int Current = int.Parse(Configs.Element("employee").Attribute("count").Value);
            for (int i = 1; i <= Current; i++)
            {
                try
                {
                    Configs.Element("employee").Element($"e{i}").Value = EText.Lines[i - 1];
                }
                catch (IndexOutOfRangeException)
                {
                    File.Delete($"data\\{string.Concat(Configs.Element("employee").Element($"e{i}").Value.Split(' '))}.json");
                    Configs.Element("employee").Element($"e{i}").Remove(); 
                }
            }
            for (int i = Current + 1; i <= Count; i++)
            {
                Configs.Element("employee").Add(new XElement($"e{i}", EText.Lines[i - 1]));
            }

            Configs.Element("employee").Attribute("count").Value = Count.ToString();
            Configs.Save("config.xml");

            Close();
        }

        private void LoadData()
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

            EText.Lines = Employees.ToArray();
        }
    }
}
