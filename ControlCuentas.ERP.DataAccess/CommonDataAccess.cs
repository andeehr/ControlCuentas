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
    }
}
