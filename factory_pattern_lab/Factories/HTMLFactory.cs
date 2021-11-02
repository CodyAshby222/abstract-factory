using factory_pattern_lab.Interfaces;
using factory_pattern_lab.Objects;

namespace factory_pattern_lab.Factories
{
    public class HTMLFactory : FileFactory
    {
        public override Button CreateButton(string content, string height, string width, string top, string left)
        {
            return new HTMLButton(content, height, width, top, left);
        }

        public override TextBox CreateTextBox(string content, string height, string width, string top, string left)
        {
            return new HTMLTextBox(content, height, width, top, left);
        }
    }
}
