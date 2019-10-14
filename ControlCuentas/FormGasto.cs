using ControlCuentas.ERP.BusinessLogic;
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

        public FormGasto(int? idGasto)
        {
            this.idGasto = idGasto;
            this.gastoBusiness = new GastoBusiness();
            this.commonBusiness = new CommonBusiness();
            InitializeComponent();
        }

        private void FormGasto_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = commonBusiness.GetGetCategoriaGastoSelectionList();
            cbMedio.DataSource = commonBusiness.GetMedioSelectionList();

            if (idGasto.HasValue) {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            var gasto = gastoBusiness.GetById(idGasto.Value);
            cbCategoria.SelectedValue = gastoBusiness.GetCategoriaByIdSubcategoria(gasto.IdSubcategoria).IdCategoria;
            cbSubcategoria.SelectedValue = gasto.IdSubcategoria;
            dtFecha.Value = gasto.Fecha;
            cbMedio.SelectedValue = gasto.IdMedio;
            tbImporte.Text = gasto.Importe.ToString();
            tbObservaciones.Text = gasto.Observaciones;
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
            var gasto = gastoBusiness.GetById(idGasto.Value);

            try {
                if (MessageBox.Show("Se modificara el gasto. Desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ValidarDatos();
                    CapturarDatos(gasto);
                    gastoBusiness.Update(gasto);
                    MessageBox.Show("Gasto modificado exitosamente");
                }
            }
            catch (Exception) {
                MessageBox.Show("Hubo un error al cargar el gasto. Intente nuevamente.");
            }
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
            catch (Exception) {
                MessageBox.Show("Hubo un error al cargar el gasto. Intente nuevamente.");
            }
        }

        private void CapturarDatos(Gasto gasto)
        {
            gasto.Fecha = dtFecha.Value;
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
