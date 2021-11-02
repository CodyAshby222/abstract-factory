using factory_pattern_lab.Interfaces;

namespace factory_pattern_lab.Objects
{
    public class HTMLTextBox : TextBox
    {
        public HTMLTextBox(string content, string height, string width, string top, string left) : base(content, height, width, top, left) { }
        public override string TextBoxLayout()
        {
            return $"\t<input type='input' placeholder='{Content}' style='position: absolute; top:{Top}px; left:{Left}px; width:{Width}px; height:{Height}px' />\r\n";
        }
    }
}
