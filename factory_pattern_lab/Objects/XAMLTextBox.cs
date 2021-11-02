using factory_pattern_lab.Interfaces;

namespace factory_pattern_lab.Objects
{
    public class XAMLTextBox : TextBox
    {
        public XAMLTextBox(string content, string height, string width, string top, string left) : base(content, height, width, top, left) { }
        public override string TextBoxLayout()
        {
            return $"\t\t<TextBox HorizontalAlignment=\"Left\" Margin=\"{Left},{Top},0,0\" Text=\"{Content}\"  TextWrapping=\"Wrap\" VerticalAlignment=\"Top\" Width=\"{Width}\" Height=\"{Height}\"/>\r\n";
        }
    }
}
