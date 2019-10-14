using ControlCuentas.ERP.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCuentas.ERP.DataAccess
{
    public class IngresoDataAccess
    {
        private readonly CCEntities context;

        public IngresoDataAccess(CCEntities context)
        {
            this.context = context;
        }

        public Ingreso GetById(int id)
        {
            var ingreso = context.Ingreso.FirstOrDefault(x => x.IdIngreso == id);
            return ingreso;
        }

        public IEnumerable<IngresoListViewModel> GetIngresos(IngresoQuery query)
        {
            var desde = new SqlParameter("@fechaDesde", query.FechaDesde ?? SqlDateTime.Null);
            var hasta = new SqlParameter("@fechaHasta", query.FechaHasta ?? SqlDateTime.Null);
            var idCategoria = new SqlParameter("@idCategoria", query.IdCategoria ?? SqlInt32.Null);
            var idMedio = new SqlParameter("@idMedio", query.IdMedio ?? SqlInt32.Null);

            var result = context.Database.SqlQuery<IngresoListViewModel>("exec dbo.[GetIngresos] @fechaDesde, @fechaHasta, @idCategoria, @idMedio", desde, hasta, idCategoria, idMedio);

            return result.ToList();
        }
    }
}
