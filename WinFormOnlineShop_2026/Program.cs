namespace WinFormOnlineShop_2026
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormCatalog());
        }
    }
}