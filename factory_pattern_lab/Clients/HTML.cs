using factory_pattern_lab.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace factory_pattern_lab.Clients
{
    public class HTML
    {
        FileFactory fileFactory;
        List<Tuple<string, string, string, string, string, string>> content;
        string filename;
        string HTMLbegin = "<!DOCTYPE html>\r\n<html>\r\n<head></head>\r\n<body>\r\n";
        string HTMLend = "</body>\r\n</html>";

        public HTML(FileFactory fileFactory, List<Tuple<string,string,string,string,string, string>> content, string filename)
        {
            this.fileFactory = fileFactory;
            this.content = content;
            this.filename = filename;
        }

        public string AssembleFile()
        {
            string contents = "";
            foreach(var tuple in content)
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
            return HTMLbegin + contents + HTMLend;
        }
        public void CreateFile()
        {
            if (!File.Exists($"{filename}.html"))
            {
                File.Create($"{filename}.html").Close();
                using (StreamWriter sw = File.AppendText($"{filename}.html"))
                {
                    sw.Write(AssembleFile());
                }
            }
            else
            {
                File.WriteAllText($"{filename}.html", String.Empty);
                using (StreamWriter sw = File.AppendText($"{filename}.html"))
                {
                    sw.Write(AssembleFile());
                }
            }
        }
    }
}
