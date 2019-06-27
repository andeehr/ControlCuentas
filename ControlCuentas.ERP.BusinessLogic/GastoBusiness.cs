using ControlCuentas.ERP.DataAccess;
using ControlCuentas.ERP.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCuentas.ERP.BusinessLogic
{
    public class GastoBusiness
    {

        private static GastoBusiness _instance;

        public static GastoBusiness Instance {
            get {
                if (_instance == null) {
                    _instance = new GastoBusiness();
                }
                return _instance;
            }
            private set { }
        }

        private GastoBusiness() { }

        public int Add(Gasto entity)
        {
            using (var context = new CCEntities()) {

                context.Gasto.Add(entity);
                context.SaveChanges();

                return entity.IdGasto;
            }
        }

        public void Update(Gasto entity)
        {
            using (var context = new CCEntities()) {

                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();

                return;
            }
        }

        public void Delete(int id)
        {
            using (var context = new CCEntities()) {
                var entity = context.Set<Gasto>().FirstOrDefault(x => x.IdGasto == id);
                context.Gasto.Remove(entity);
                context.SaveChanges();
            }
        }

        public Gasto GetById(int id)
        {
            using (var context = new CCEntities()) {
                var gastoDA = new GastoDataAccess(context);
                var gasto = gastoDA.GetById(id);
                return gasto;
            }
        }

        public IList<GastoListViewModel> GetList(GastoQuery query)
        {
            using (var context = new CCEntities()) {
                var gastoDA = new GastoDataAccess(context);
                var gastosList = gastoDA.GetList(query);
                return gastosList;
            }
        }
    }
}
