using factory_pattern_lab.Clients;
using factory_pattern_lab.Factories;
using factory_pattern_lab.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factory_pattern_lab
{
    public partial class Form1 : Form
    {
        public List<Tuple<string, string,string,string,string,string>> list = new List<Tuple<string,string, string, string, string, string>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddTextBtn_Click(object sender, EventArgs e)
        {
            list.Add(Tuple.Create("Textbox", ContentInput.Text, HeightInput.Text, WidthInput.Text, TopInput.Text, LeftInput.Text));
            DisplayAll();
        }

        private void AddButtonBtn_Click(object sender, EventArgs e)
        {
            list.Add(Tuple.Create("Button", ContentInput.Text, HeightInput.Text, WidthInput.Text, TopInput.Text, LeftInput.Text));
            DisplayAll();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            list.RemoveAt(list.Count - 1);
            DisplayAll();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (HtmlRadio.Checked)
            {
                HTML file = new HTML(new HTMLFactory(), list, FilenameInput.Text);
                file.CreateFile();
            }
            else
            {
                XAML file = new XAML(new XAMLFactory(), list, FilenameInput.Text);
                file.CreateFile();
            }
        }

        private void DisplayAll()
        {
            DisplayInputs.Clear();
            foreach (var tuple in list)
            {
                DisplayInputs.Text += $"{tuple.Item1}: {tuple.Item2} - H:{tuple.Item3} - W:{tuple.Item4} - T: {tuple.Item5} - L: {tuple.Item6} \r\n";
            }
        }
    }
}
