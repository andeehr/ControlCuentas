using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCuentas.ERP.BusinessLogic;

namespace ControlCuentas
{
    public partial class ABMGasto :Form
    {
        private readonly CommonBusiness commonBusiness;

        public ABMGasto(CommonBusiness commonBusiness)
        {
            this.commonBusiness = commonBusiness;
            InitializeComponent();
        }

        private void GastoUI_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = commonBusiness.GetGetCategoriaGastoSelectionList();
            cbMedio.DataSource = commonBusiness.GetMedioSelectionList();
        }
    }
}
