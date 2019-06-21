﻿using ControlCuentas.ERP.BusinessLogic;
using ControlCuentas.ERP.DataAccess;
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
    public partial class FormGasto :Form
    {

        private readonly CommonBusiness commonBusiness;
        private readonly GastoBusiness gastoBusiness;
        private readonly int? idGasto;

        public FormGasto(CommonBusiness commonBL, GastoBusiness gastoBL, int? idGasto)
        {
            this.idGasto = idGasto;
            this.gastoBusiness = gastoBL;
            this.commonBusiness = commonBL;
            InitializeComponent();
        }

        private void FormGasto_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = commonBusiness.GetGetCategoriaGastoSelectionList();
            cbMedio.DataSource = commonBusiness.GetMedioSelectionList();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            cbSubcategoria.DataSource = commonBusiness.GetSubcategoriaSelectionListByIdCategoria(idCategoria);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (idGasto.HasValue) {
                ModificarGasto();
            } else {
                AltaGasto();
            }
        }

        private void ModificarGasto()
        {
            throw new NotImplementedException();
        }

        private void AltaGasto()
        {
            var gasto = new Gasto();

            try {
                if (MessageBox.Show("Se cargara un nuevo gasto. Desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ValidarDatos();
                    CapturarDatos(gasto);
                    gastoBusiness.Add(gasto);
                    MessageBox.Show("Gasto cargado exitosamente");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CapturarDatos(Gasto gasto)
        {
            gasto.Fecha = DateTime.Now;
            gasto.Importe = Convert.ToDecimal(tbImporte.Text);
            gasto.IdMedio = Convert.ToInt32(cbMedio.SelectedValue);
            gasto.IdSubcategoria = Convert.ToInt32(cbSubcategoria.SelectedValue);
            gasto.Observaciones = tbObservaciones.Text;
        }

        private void ValidarDatos()
        {
            var controls = new[] { tbImporte };
            FormHelper.ValidarCamposVacios(controls);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            FormHelper.Limpiar(this);
        }
    }
}
