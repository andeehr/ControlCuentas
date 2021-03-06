﻿using System;
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

        public ABMGasto()
        {
            this.gastoBusiness = new GastoBusiness();
            this.commonBusiness = new CommonBusiness();
            InitializeComponent();
        }

        private void GastoUI_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = commonBusiness.GetGetCategoriaGastoSelectionList();
            cbMedio.DataSource = commonBusiness.GetMedioSelectionList();
        }

        #region ABM

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = CreateFormGasto(null);
            form.Show();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                var idGasto = DataGridHelper.GetIdFromRowCell(dgGastos, "idGasto");
                if (MessageBox.Show("Se eliminara el gasto seleccionado, desea continuar?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    gastoBusiness.Delete(idGasto);
                    MessageBox.Show("Gasto eliminado exitosamente");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private FormGasto CreateFormGasto(int? idGasto)
        {
            return new FormGasto(idGasto);
        }

        private void Buscar()
        {
            var query = new GastoQuery();

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

            dgGastos.DataSource = gastoBusiness.GetGastos(query);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Buscar();
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
