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
using ControlCuentas.ERP.Entities.ViewModels;
using ControlCuentas.ERP.Infrastructure;

namespace ControlCuentas
{
    public partial class ABMGasto :Form
    {
        private readonly CommonBusiness commonBusiness;
        private readonly GastoBusiness gastoBusiness;

        public ABMGasto(CommonBusiness commonBusiness, GastoBusiness gastoBusiness)
        {
            this.gastoBusiness = gastoBusiness;
            this.commonBusiness = commonBusiness;
            InitializeComponent();
        }

        private void GastoUI_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = commonBusiness.GetGetCategoriaGastoSelectionList();
            cbMedio.DataSource = commonBusiness.GetMedioSelectionList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = CreateFormGasto(null);
            form.Show();
        }

        private FormGasto CreateFormGasto(int? idGasto)
        {
            return new FormGasto(CommonBusiness.Instance, GastoBusiness.Instance, idGasto);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try {
                var idGasto = DataGridHelper.GetIdFromRowCell(dgGastos, "idGasto");
                var form = CreateFormGasto(idGasto);
                form.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var query = new GastoQuery();
            // Faltan los filtros para la query

            var list = gastoBusiness.GetList(query);
            dgGastos.DataSource = list;
        }
    }
}
