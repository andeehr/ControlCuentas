using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCuentas.ERP.Entities.ViewModels
{
    public class GastoViewModel
    {

    }

    public class GastoQuery
    {

    }

    public class GastoListViewModel
    {
        public int IdGasto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
    }
}
