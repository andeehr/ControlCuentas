using ControlCuentas.ERP.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas
{
    public partial class MenuPrincipal :Form
    {
        private readonly GastoBusiness gastoBusines;
        private readonly IngresoBusiness ingresoBusiness;

        public MenuPrincipal()
        {
            this.gastoBusines = new GastoBusiness();
            this.ingresoBusiness = new IngresoBusiness();
            InitializeComponent();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            new ABMGasto().Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            new ABMIngreso().Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            tbTotal.Text = (this.ingresoBusiness.TotalIngresos() - this.gastoBusines.TotalGastos()).ToString();
            tbCajaDeAhorro.Text = (this.ingresoBusiness.TotalIngresosEnCajaDeAhorro() - this.gastoBusines.TotalGastosEnCajaDeAhorro()).ToString();
            tbEfectivo.Text = (this.ingresoBusiness.TotalIngresosEnEfectivo() - this.gastoBusines.TotalGastosEnEfectivo()).ToString();
        }
    }
}
