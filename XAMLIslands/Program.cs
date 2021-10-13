public class Program
{
    [System.STAThreadAttribute()]
    public static void Main()
    {
        using (new MyUWPApp.App())
        {
            XAMLIslands.App app = new XAMLIslands.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}