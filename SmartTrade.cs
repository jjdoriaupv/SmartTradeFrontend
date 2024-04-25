using SmartTradeFrontend.Servicios;
namespace SmartTradeFrontend
{
    public partial class SmartTrade : Form
    {
        public SmartTradeServices servicio;

        public SmartTrade() {

            InitializeComponent();
        }
        public SmartTrade(SmartTradeServices servicio)
        {
            this.servicio = servicio;
        }

        private void SmartTrade_Load(object sender, EventArgs e)
        {

        }
    }
}
