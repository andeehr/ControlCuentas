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
    public class IngresoBusiness
    {
        public int Add(Ingreso entity)
        {
            using (var context = new CCEntities()) {

                context.Ingreso.Add(entity);
                context.SaveChanges();

                return entity.IdIngreso;
            }
        }

        public void Update(Ingreso entity)
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
                var entity = context.Set<Ingreso>().FirstOrDefault(x => x.IdIngreso == id);
                context.Ingreso.Remove(entity);
                context.SaveChanges();
            }
        }

        public Ingreso GetById(int id)
        {
            using (var context = new CCEntities()) {
                var ingresoDA = new IngresoDataAccess(context);
                var ingreso = ingresoDA.GetById(id);
                return ingreso;
            }
        }

        public IEnumerable<IngresoListViewModel> GetIngresos(IngresoQuery query)
        {
            using (var context = new CCEntities()) {
                var ingresoDA = new IngresoDataAccess(context);
                return ingresoDA.GetIngresos(query);
            }
        }

        public decimal TotalIngresos()
        {
            return this.TotalIngresosEnCajaDeAhorro() + this.TotalIngresosEnEfectivo();
        }

        public decimal TotalIngresosEnCajaDeAhorro()
        {
            using (var context = new CCEntities()) {
                var ingresosDA = new IngresoDataAccess(context);
                return ingresosDA.TotalIngresosEn(2);
            }
        }

        public decimal TotalIngresosEnEfectivo()
        {
            using (var context = new CCEntities()) {
                var ingresosDA = new IngresoDataAccess(context);
                return ingresosDA.TotalIngresosEn(1);
            }
        }

    }
}
