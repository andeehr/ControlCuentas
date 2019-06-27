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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            new ABMGasto(CommonBusiness.Instance, GastoBusiness.Instance).Show();
        }
    }
}
