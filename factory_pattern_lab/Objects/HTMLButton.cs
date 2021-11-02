using factory_pattern_lab.Interfaces;

namespace factory_pattern_lab.Objects
{
    public class HTMLButton : Button
    {
        public HTMLButton(string content, string height, string width, string top, string left) : base(content, height, width, top, left) { }
        public override string ButtonLayout()
        {
            return $"\t<input type='button' value='{Content}' style='position: absolute; top:{Top}px; left:{Left}px; width:{Width}px; height:{Height}px' />\r\n";
        }
    }
}
