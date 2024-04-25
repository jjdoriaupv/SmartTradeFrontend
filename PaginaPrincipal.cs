using SmartTradeFrontend.Models;
using SmartTradeFrontend.Servicios;
namespace SmartTradeFrontend
{
    public partial class PaginaPrincipal : Form
    {
        public SmartTradeServices servicio;
        public List<Producto> Tendencias;

        public PaginaPrincipal() {

            InitializeComponent();
        }
        public PaginaPrincipal(SmartTradeServices servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
            tendencias.View = View.Details;
            tendencias.Columns.Add("Nombre", 150, HorizontalAlignment.Left);

            tendencias.FullRowSelect = true;
            Tendencia();
        }
        private void SmartTrade_Load(object sender, EventArgs e)
        {


        }

        public async void Tendencia()
        {
            List<Producto> result = await servicio.Tendencias();

            if (result != null && result.Count > 0)
            {
                foreach (var item in result)
                {
                    Tendencias.Add(item);
                }
            }
            foreach (Producto p in Tendencias)
            {
                ListViewItem dato = new ListViewItem(p.nombre);
                tendencias.Items.Add(dato);
            }
        }

    }
}
