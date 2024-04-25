using SmartTradeFrontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTradeFrontend.Servicios
{
    public class SmartTradeServices
    {
        public SmartTradeServices()
        {

        }

        private PaginaPrincipalController pagPrin = new PaginaPrincipalController();

        public async Task<List<Producto>> Tendencias()
        {
            List<Producto> result;
            result = await pagPrin.Tendencias();
            return result;
        }
    }
}
