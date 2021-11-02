using factory_pattern_lab.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace factory_pattern_lab.Clients
{
    public class XAML
    {
        FileFactory fileFactory;
        List<Tuple<string, string, string, string, string, string>> content;
        string filename;
        string XAMLend = "\t</Grid>\r\n</Window>";

        public XAML(FileFactory fileFactory, List<Tuple<string, string, string, string, string, string>> content, string filename)
        {
            this.fileFactory = fileFactory;
            this.content = content;
            this.filename = filename;
        }

        public string AssembleFile()
        {
            string contents = "";
            foreach (var tuple in content)
            {
                switch (tuple.Item1.ToUpper())
                {
                    case "BUTTON":
                        Button button = this.fileFactory.CreateButton(tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
                        contents += button.ButtonLayout();
                        break;
                    case "TEXTBOX":
                        TextBox textBox = this.fileFactory.CreateTextBox(tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
                        contents += textBox.TextBoxLayout();
                        break;
                }
            }
            return XAMLIntro() + contents + XAMLend;
        }
        public void CreateFile()
        {
            if (!File.Exists($"{filename}.xaml"))
            {
                File.Create($"{filename}.xaml").Close();
                using (StreamWriter sw = File.AppendText($"{filename}.xaml"))
                {
                    sw.Write(AssembleFile());
                }
            }
            else
            {
                File.WriteAllText($"{filename}.xaml", String.Empty);
                using (StreamWriter sw = File.AppendText($"{filename}.xaml"))
                {
                    sw.Write(AssembleFile());
                }
            }
        }

        public string XAMLIntro()
        {
            return "<Window x:Class=\"factory_pattern_lab.MainWindow\">\r\n" +
            "\t\txmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\r\n" +
            "\t\txmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\r\n" +
            "\t\txmlns:d=\"http://schemas.microsoft.com/expression/blend/2008\"\r\n" +
            "\t\txmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"\r\n" +
            "\t\txmlns:local=\"clr -namespace:factory_pattern_lab\"\r\n" +
            "\t\tmc:Ignorable=\"d\"\r\n" +
            "\t\tTitle=\"MainWindow\" Height=\"450\" Width=\"800\"\r\n" +
            "\t<Grid>\r\n";
        }
    }
}
