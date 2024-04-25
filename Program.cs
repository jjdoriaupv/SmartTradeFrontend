using SmartTradeFrontend.Servicios;
namespace SmartTradeFrontend
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SmartTradeServices servicio = new SmartTradeServices();
            ApplicationConfiguration.Initialize();
            Application.Run(new SmartTrade(servicio));
        }
    }
}