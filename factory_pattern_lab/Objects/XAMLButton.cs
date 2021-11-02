using factory_pattern_lab.Interfaces;

namespace factory_pattern_lab.Objects
{
    public class XAMLButton : Button
    {
        public XAMLButton(string content, string height, string width, string top, string left) : base(content, height, width, top, left) { }
        public override string ButtonLayout()
        {
            return $"\t\t<Button x:Name=\"addTextBlock\" Content=\"{Content}\" HorizontalAlignment=\"Left\" Margin=\"{Left},{Top},0,0\" VerticalAlignment=\"Top\" Width=\"{Width}\" Height=\"{Height}\"/>\r\n";
        }
    }
}
