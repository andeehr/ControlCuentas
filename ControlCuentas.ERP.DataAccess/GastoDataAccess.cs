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

        public CategoriaGasto GetCategoriaByIdSubcategoria(int idSubcategoria)
        {
            IQueryable<CategoriaGasto> tCategoria = context.Set<CategoriaGasto>().AsNoTracking();
            IQueryable<SubcategoriaGasto> tSubcategoria = context.Set<SubcategoriaGasto>().AsNoTracking();

            var result = from categoria in tCategoria
                         join subcategoria in tSubcategoria
                         on categoria.IdCategoria equals subcategoria.IdCategoria
                         where subcategoria.IdSubcategoria == idSubcategoria
                         select categoria;
            return result.First();
        }

        public IEnumerable<GastoListViewModel> GetGastos(GastoQuery query)
        {
            var desde = new SqlParameter("@fechaDesde", query.FechaDesde ?? SqlDateTime.Null);
            var hasta = new SqlParameter("@fechaHasta", query.FechaHasta ?? SqlDateTime.Null);
            var idCategoria = new SqlParameter("@idCategoria", query.IdCategoria ?? SqlInt32.Null);
            var idMedio = new SqlParameter("@idMedio", query.IdMedio ?? SqlInt32.Null);

            var result = context.Database.SqlQuery<GastoListViewModel>("exec dbo.[GetGastos] @fechaDesde, @fechaHasta, @idCategoria, @idMedio", desde, hasta, idCategoria, idMedio).ToList();

            return result;
        }
    }
}
