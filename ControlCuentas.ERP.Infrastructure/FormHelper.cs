using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas.ERP.Infrastructure
{
    public static class FormHelper
    {
        private static void LimpiarTextboxsHabilitados(Form form)
        {
            var textBoxs = form.Controls.OfType<TextBox>().ToList();

            foreach (var tb in textBoxs) {
                if (tb.Enabled) {
                    tb.Text = String.Empty;
                }
            }
        }

        private static void LimpiarTextboxs(Form form)
        {
            var textBoxs = form.Controls.OfType<TextBox>().ToList();

            foreach (var tb in textBoxs) {
                tb.Text = String.Empty;
            }
        }

        private static void LimpiarDatagrids(Form form)
        {
            var datagrids = form.Controls.OfType<DataGridView>().ToList();

            foreach (var data in datagrids) {
                data.DataSource = null;
                data.Rows.Clear();
            }
        }

        private static void LimpiarGroupboxs(Form form)
        {
            var groupBoxs = form.Controls.OfType<GroupBox>().ToList();

            foreach (var gb in groupBoxs) {
                LimpiarTextboxsDeGroupboxs(form, gb);
            }
        }

        private static void LimpiarTextboxsDeGroupboxs(Form form, GroupBox gb)
        {
            foreach (Control ctrl in gb.Controls) {
                if (ctrl is TextBox) {
                    if (ctrl.Enabled) {
                        ctrl.Text = String.Empty;
                    }
                }
            }
        }


        /// <summary>
        /// Deshabilita un control especifico pasado por parametro.
        /// </summary>
        /// <param name="control"></param>
        public static void DeshabilitarControl(Control control)
        {
            control.Enabled = false;
        }

        /// <summary>
        /// Habilita un control especifico pasado por parametro.
        /// </summary>
        /// <param name="control"></param>
        public static void HabilitarControl(Control control)
        {
            control.Enabled = true;
        }

        /// <summary>
        /// Deshabilita todos los controles del formulario, con excepcion de los labels independientes y los que pertenecen a los groupbox
        /// </summary>
        /// <param name="form"></param>
        public static void DeshabilitarControles(Form form)
        {
            var groupBoxs = form.Controls.OfType<GroupBox>().ToList();

            foreach (Control control in form.Controls) {
                if (!(control is Label) && !(control is GroupBox)) {
                    control.Enabled = false;
                }
            }

            foreach (GroupBox ctrl in groupBoxs) {
                DeshabilitarControlesDeGroupbox(ctrl);
            }
        }

        private static void DeshabilitarControlesDeGroupbox(GroupBox gb)
        {
            foreach (Control ctrl in gb.Controls) {
                if (!(ctrl is Label)) {
                    ctrl.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Habilita los controles pasados por parametro.
        /// </summary>
        /// <param name="controls"></param>
        public static void HabilitarControles(Control[] controls)
        {
            foreach (Control ctrl in controls) {
                ctrl.Enabled = true;
            }
        }

        /// <summary>
        /// Deshabilita los controles pasados por parametro.
        /// </summary>
        /// <param name="controls"></param>
        public static void DeshabilitarControles(Control[] controls)
        {
            foreach (Control ctrl in controls) {
                ctrl.Enabled = false;
            }
        }

        /// <summary>
        /// Limpia el formulario dejando los textBoxs habilitados en blanco y vaciando la grilla.
        /// </summary>
        /// <param name="form"></param>
        public static void Limpiar(Form form)
        {
            LimpiarDatagrids(form);
            LimpiarTextboxsHabilitados(form);
            LimpiarGroupboxs(form);
        }

        /// <summary>
        /// Limpia el formulario dejando tpdps los textBoxs en blanco y vaciando la grilla.
        /// </summary>
        /// <param name="form"></param>
        public static void LimpiarTodo(Form form)
        {
            LimpiarDatagrids(form);
            LimpiarTextboxs(form);
            LimpiarGroupboxs(form);
        }

        /// <summary>
        /// Verifica que los textboxs pasados por parametro no sean nulos o esten en blanco
        /// </summary>
        /// <param name="controls"></param>
        public static void ValidarCamposVacios(TextBox[] controls)
        {
            foreach (var control in controls) {
                if (string.IsNullOrWhiteSpace(control.Text)) {
                    throw new ApplicationException("Hay campos obligatorios sin completar");
                }
            }
        }
    }
}
