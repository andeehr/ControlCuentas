using ControlCuentas.ERP.BusinessLogic;
using ControlCuentas.ERP.Entities.ViewModels;
using ControlCuentas.ERP.Infrastructure;
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
    public partial class ABMIngreso :Form
    {
        private readonly CommonBusiness commonBusiness;
        private readonly IngresoBusiness ingresoBusiness;

        public ABMIngreso()
        {
            this.commonBusiness = new CommonBusiness();
            this.ingresoBusiness = new IngresoBusiness();
            InitializeComponent();
        }

        private void ABMIngreso_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = commonBusiness.GetGetCategoriaIngresoSelectionList();
            cbMedio.DataSource = commonBusiness.GetMedioSelectionList();
        }

        #region ABM

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = CreateFormIngreso(null);
            form.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try {
                var idIngreso = DataGridHelper.GetIdFromRowCell(dgIngresos, "idIngreso");
                var form = CreateFormIngreso(idIngreso);
                form.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                var idIngreso = DataGridHelper.GetIdFromRowCell(dgIngresos, "idIngreso");
                if (MessageBox.Show("Se eliminara el ingreso seleccionado, desea continuar?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ingresoBusiness.Delete(idIngreso);
                    MessageBox.Show("Ingreso eliminado exitosamente");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private FormIngreso CreateFormIngreso(int? idIngreso)
        {
            return new FormIngreso(idIngreso);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void Buscar()
        {
            var query = new IngresoQuery();

            if (checkBoxDesde.Checked) {
                query.FechaDesde = dtDesde.Value;
            } else {
                query.FechaDesde = null;
            }

            if (checkBoxHasta.Checked) {
                query.FechaHasta = dtHasta.Value;
            } else {
                query.FechaHasta = null;
            }

            if (checkBoxCategoria.Checked) {
                query.IdCategoria = (int)cbCategoria.SelectedValue;
            } else {
                query.IdCategoria = null;
            }

            if (checkBoxMedio.Checked) {
                query.IdMedio = (int)cbMedio.SelectedValue;
            } else {
                query.IdMedio = null;
            }

            dgIngresos.DataSource = ingresoBusiness.GetIngresos(query);
        }

        #region Eventos de Checkboxs

        private void checkBoxMedio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMedio.Checked) {
                cbMedio.Enabled = true;
            } else {
                cbMedio.Enabled = false;
            }
        }

        private void checkBoxCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCategoria.Checked) {
                cbCategoria.Enabled = true;
            } else {
                cbCategoria.Enabled = false;
            }
        }

        private void checkBoxDesde_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDesde.Checked) {
                dtDesde.Enabled = true;
            } else {
                dtDesde.Enabled = false;
            }
        }

        private void checkBoxHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHasta.Checked) {
                dtHasta.Enabled = true;
            } else {
                dtHasta.Enabled = false;
            }
        }
        #endregion
    }
}
