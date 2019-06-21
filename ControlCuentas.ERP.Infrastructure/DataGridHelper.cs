using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas.ERP.Infrastructure
{
    public static class DataGridHelper
    {
        /// <summary>
        /// Obtiene el Id de la entidad del registro de una grilla pasada por parametro.
        /// </summary>
        /// <param name="row">Linea del DataGrid</param>
        /// <param name="key">Nombre de la columna que contiene el id del Objeto</param>
        /// <returns></returns>
        public static int GetIdFromRowCell(DataGridView dataGrid, string key)
        {
            int idEntity = 0;
            try {
                DataGridViewRow row = dataGrid.CurrentRow;
                idEntity = Convert.ToInt32(row.Cells[key].Value);
            }
            catch (Exception) {
                throw new ApplicationException("Ha ocurrido un error inesperado. Pruebe nuevamente o contáctese con el administrador");
            }

            return idEntity;
        }

        /// <summary>
        /// Elimina la fila seleccionada
        /// </summary>
        /// <param name="dataGrid"></param>
        public static void DeleteCurrentRow(DataGridView dataGrid)
        {
            DataGridViewRow row = dataGrid.CurrentRow;
            dataGrid.Rows.Remove(row);
        }
    }
}
