namespace factory_pattern_lab.Interfaces
{
    public abstract class Button
    {
        public string Content { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Top { get; set; }
        public string Left { get; set; }

        public Button(string content, string height, string width, string top, string left)
        {
            this.Content = content;
            this.Height = height;
            this.Width = width;
            this.Top = top;
            this.Left = left;
        }

        public abstract string ButtonLayout();
    }
}
