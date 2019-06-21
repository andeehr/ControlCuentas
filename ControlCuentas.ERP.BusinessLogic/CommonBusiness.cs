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
        private static CommonBusiness _instance;

        public static CommonBusiness Instance {
            get {
                if (_instance == null) {
                    _instance = new CommonBusiness();
                }
                return _instance;
            }
            private set { }
        }

        private CommonBusiness() { }

        public IList<SelectListItem> GetGetCategoriaGastoSelectionList()
        {
            using (var context = new CCEntities()) {
                var commonDA = new CommonDataAccess(context);
                return commonDA.GetCategoriaGastoSelectionList();
            }
        }

        public IList<SelectListItem> GetGetCategoriaIngresoSelectionList()
        {
            using (var context = new CCEntities()) {
                var commonDA = new CommonDataAccess(context);
                return commonDA.GetCategoriaIngresoSelectionList();
            }
        }

        public IList<SelectListItem> GetMedioSelectionList()
        {
            using (var context = new CCEntities()) {
                var commonDA = new CommonDataAccess(context);
                return commonDA.GetMedioSelectionList();
            }
        }

        public IList<SelectListItem> GetSubcategoriaSelectionListByIdCategoria(int idCategoria)
        {
            using (var context = new CCEntities()) {
                var commonDA = new CommonDataAccess(context);
                return commonDA.GetSubcategoriaSelectionListByIdCategoria(idCategoria);
            }
        }
    }
}
