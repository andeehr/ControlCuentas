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
    public partial class FormGasto :Form
    {

        private readonly CommonBusiness commonBusiness;

        public FormGasto(CommonBusiness commonBL)
        {
            this.commonBusiness = commonBL;
            InitializeComponent();
        }

        private void FormGasto_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = commonBusiness.GetGetCategoriaGastoSelectionList();
            cbMedio.DataSource = commonBusiness.GetMedioSelectionList();
        }
    }
}
