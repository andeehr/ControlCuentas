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
    public partial class FormIngreso :Form
    {
        private readonly CommonBusiness commonBusiness;
        private readonly IngresoBusiness ingresoBusiness;
        private readonly int? idIngreso;

        public FormIngreso(int? idIngreso)
        {
            this.idIngreso = idIngreso;
            this.ingresoBusiness = new IngresoBusiness();
            this.commonBusiness = new CommonBusiness();
            InitializeComponent();
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = commonBusiness.GetGetCategoriaIngresoSelectionList();
            cbMedio.DataSource = commonBusiness.GetMedioSelectionList();

            if (idIngreso.HasValue) {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            var ingreso = ingresoBusiness.GetById(idIngreso.Value);
            cbCategoria.SelectedValue = ingreso.IdCategoriaIngreso;
            dtFecha.Value = ingreso.Fecha;
            cbMedio.SelectedValue = ingreso.IdMedio;
            tbImporte.Text = ingreso.Importe.ToString();
            tbObservaciones.Text = ingreso.Observaciones;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (idIngreso.HasValue) {
                ModificarIngreso();
            } else {
                AltaIngreso();
            }
        }

        private void ModificarIngreso()
        {
            var ingreso = ingresoBusiness.GetById(idIngreso.Value);

            try {
                if (MessageBox.Show("Se modificara el ingreso. Desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ValidarDatos();
                    CapturarDatos(ingreso);
                    ingresoBusiness.Update(ingreso);
                    MessageBox.Show("Ingreso modificado exitosamente");
                }
            }
            catch (Exception) {
                MessageBox.Show("Hubo un error al cargar el ingreso. Intente nuevamente.");
            }
        }

        private void AltaIngreso()
        {
            var ingreso = new Ingreso();

            try {
                if (MessageBox.Show("Se cargara un nuevo ingreso. Desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    ValidarDatos();
                    CapturarDatos(ingreso);
                    ingresoBusiness.Add(ingreso);
                    MessageBox.Show("Ingreso cargado exitosamente");
                }
            }
            catch (Exception) {
                MessageBox.Show("Hubo un error al cargar el ingreso. Intente nuevamente.");
            }
        }

        private void CapturarDatos(Ingreso ingreso)
        {
            ingreso.Fecha = dtFecha.Value;
            ingreso.IdCategoriaIngreso = Convert.ToInt32(cbCategoria.SelectedValue);
            ingreso.Importe = Convert.ToDecimal(tbImporte.Text);
            ingreso.IdMedio = Convert.ToInt32(cbMedio.SelectedValue);
            ingreso.Observaciones = tbObservaciones.Text;
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
