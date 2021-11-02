namespace factory_pattern_lab.Interfaces
{
    public abstract class FileFactory
    {
        public abstract Button CreateButton(string content, string height, string width, string top, string left);
        public abstract TextBox CreateTextBox(string content, string height, string width, string top, string left);
    }
}
