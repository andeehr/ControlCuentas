using ControlCuentas.ERP.DataAccess;
using ControlCuentas.ERP.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCuentas.ERP.BusinessLogic
{
    public class CommonBusiness
    {
        public IEnumerable<SelectListItem> GetGetCategoriaGastoSelectionList()
        {
            using (var context = new CCEntities()) {
                var commonDA = new CommonDataAccess(context);
                return commonDA.GetCategoriaGastoSelectionList();
            }
        }

        public IEnumerable<SelectListItem> GetGetCategoriaIngresoSelectionList()
        {
            using (var context = new CCEntities()) {
                var commonDA = new CommonDataAccess(context);
                return commonDA.GetCategoriaIngresoSelectionList();
            }
        }

        public IEnumerable<SelectListItem> GetMedioSelectionList()
        {
            using (var context = new CCEntities()) {
                var commonDA = new CommonDataAccess(context);
                return commonDA.GetMedioSelectionList();
            }
        }

        public IEnumerable<SelectListItem> GetSubcategoriaSelectionListByIdCategoria(int idCategoria)
        {
            using (var context = new CCEntities()) {
                var commonDA = new CommonDataAccess(context);
                return commonDA.GetSubcategoriaSelectionListByIdCategoria(idCategoria);
            }
        }
    }
}
