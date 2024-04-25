using System.Net.Http;
using Newtonsoft.Json.Linq;
using SmartTradeFrontend.Models;
using Newtonsoft.Json;

namespace SmartTradeFrontend.Servicios
{
    public class PaginaPrincipalController
    {
        private HttpClient Client;
        public PaginaPrincipalController()
        {
            Client = new HttpClient();
        }

        public async Task<List<Producto>> Tendencias()
        {
            try
            {
                List<Producto> listaProducto;
                HttpResponseMessage response = await Client.GetAsync("http://www.smarttrade.somee.com/Servicios/Tendencia");

                var responsebody = await response.Content.ReadAsStringAsync();

                response.EnsureSuccessStatusCode();

                string responseJSON = await response.Content.ReadAsStringAsync();

                listaProducto = JsonConvert.DeserializeObject<List<Producto>>(responseJSON);

                Console.WriteLine(listaProducto);

                return listaProducto;
            }
            catch (Exception) { return null; }
        }
    }
}
