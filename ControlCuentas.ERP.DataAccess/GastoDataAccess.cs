using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCuentas.ERP.DataAccess
{
    public class GastoDataAccess
    {
        private readonly CCEntities context;

        public GastoDataAccess(CCEntities context)
        {
            this.context = context;
        }

        public Gasto GetById(int id)
        {
            var gasto = context.Gasto.FirstOrDefault(x => x.IdGasto == id);
            return gasto;
        }
    }
}
