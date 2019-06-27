using ControlCuentas.ERP.Entities.ViewModels;
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

        public IList<GastoListViewModel> GetList(GastoQuery query)
        {
            ////TODO: Falta los filtros

            IQueryable<Gasto> tGasto = context.Set<Gasto>().AsNoTracking();
            IQueryable<CategoriaGasto> tCategoria = context.Set<CategoriaGasto>().AsNoTracking();
            IQueryable<SubcategoriaGasto> tSubcategoria = context.Set<SubcategoriaGasto>().AsNoTracking();

            var result = from gasto in tGasto
                         join subcategoria in tSubcategoria
                         on gasto.IdSubcategoria equals subcategoria.IdSubcategoria
                         join categoria in tCategoria
                         on subcategoria.IdCategoria equals categoria.IdCategoria
                         select new GastoListViewModel {
                             IdGasto = gasto.IdGasto,
                             Categoria = categoria.Descripcion,
                             Fecha = gasto.Fecha,
                             Importe = gasto.Importe,
                             Subcategoria = subcategoria.Descripcion,
                             Observaciones = gasto.Observaciones
                         };

            return result.ToList();
        }
    }
}
