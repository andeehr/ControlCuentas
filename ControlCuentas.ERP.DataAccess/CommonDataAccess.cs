using ControlCuentas.ERP.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCuentas.ERP.DataAccess
{
    public class CommonDataAccess
    {
        /*Esta clase es utilizada traer los datos de la base que no pueden ser modificados por el usuario*/
        private readonly CCEntities context;

        public CommonDataAccess(CCEntities context)
        {
            this.context = context;
        }

        public IList<SelectListItem> GetCategoriaGastoSelectionList()
        {
            IQueryable<CategoriaGasto> tCategoria = context.Set<CategoriaGasto>().AsNoTracking();

            var result = from categoria in tCategoria
                         select new SelectListItem {
                             Id = categoria.IdCategoria,
                             Desc = categoria.Descripcion
                         };
            return result.ToList();
        }

        public IList<SelectListItem> GetCategoriaIngresoSelectionList()
        {
            IQueryable<CategoriaIngreso> tCategoria = context.Set<CategoriaIngreso>().AsNoTracking();

            var result = from categoria in tCategoria
                         select new SelectListItem {
                             Id = categoria.IdCategoriaIngreso,
                             Desc = categoria.Descripcion
                         };
            return result.ToList();
        }

        public IList<SelectListItem> GetMedioSelectionList()
        {
            IQueryable<Medio> tMedio = context.Set<Medio>().AsNoTracking();

            var result = from medio in tMedio
                         select new SelectListItem {
                             Id = medio.IdMedio,
                             Desc = medio.Descripcion
                         };
            return result.ToList();
        }

        public IList<SelectListItem> GetSubcategoriaSelectionListByIdCategoria(int idCategoria)
        {
            IQueryable<SubcategoriaGasto> tSubcategoria = context.Set<SubcategoriaGasto>().AsNoTracking();

            var result = from subcategoria in tSubcategoria
                         where subcategoria.IdCategoria == idCategoria
                         select new SelectListItem {
                             Id = subcategoria.IdSubcategoria,
                             Desc = subcategoria.Descripcion
                         };
            return result.ToList();
        }
    }
}
