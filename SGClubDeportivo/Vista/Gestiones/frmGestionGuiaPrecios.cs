using SGClubDeportivo.Controlador;
using SGClubDeportivo.Data;
using SGClubDeportivo.Vista.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubDeportivo.Vista.Gestiones
{
    public partial class frmGestionGuiaPrecios : frmGestiones
    {
        GuiaPrecioController _GuiaPrecios = new GuiaPrecioController();
        public frmGestionGuiaPrecios()
        {
            InitializeComponent();
        }


        private void frmGestionGuiaPrecios_Load(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.text);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abrir un nuevo formulario para agregar guiaPrecioss
            frmCrudGuiaPrecios frmAgregar = new frmCrudGuiaPrecios();
            DialogResult result = frmAgregar.ShowDialog();

            // Recargar los datos si se agregó un guiaPrecios
            if (result == DialogResult.OK)
            {
                CargarDatos(txtBuscar.text);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar los resultados en el DataGridView según el texto de búsqueda
            string filtro = txtBuscar.text;
            CargarDatos(filtro);
        }



        private void CargarDatos(string textSearch)
        {
            
            try
            {
                //_GuiaPrecios = new GuiaPrecioController(); //no olvidar esta linea para actualizar tabla //NO USAMOS PORQUE TENEMOS EL CELLCONTENTCLICK
                // Llamas al método Listar del controlador con el filtro
                GuiaPreciosBindingSource.DataSource = _GuiaPrecios.Listar(textSearch);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guiaPreciossDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si se hizo clic en una celda de botón
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Verifica si se hizo clic en la columna "Editar"
                    if (GuiaPreciosDataGridView.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        // Lógica para editar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(GuiaPreciosDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                        frmCrudGuiaPrecios frmEditar = new frmCrudGuiaPrecios(id);
                        DialogResult result = frmEditar.ShowDialog();

                        // Recargar los datos si se editó un guiaPrecios
                        if (result == DialogResult.OK)
                        {
                            _GuiaPrecios = new GuiaPrecioController(); //no olvidar esta linea para actualizar tabla
                            CargarDatos(txtBuscar.text);
                        }
                    }
                    // Verifica si se hizo clic en la columna "Eliminar"
                    else if (GuiaPreciosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        // Lógica para eliminar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(GuiaPreciosDataGridView.Rows[e.RowIndex].Cells["id"].Value);

                        // Lógica para confirmar la eliminación
                        DialogResult confirmResult = MessageBox.Show("¿Estás seguro de eliminar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Lógica para eliminar el guiaPrecios
                            if (_GuiaPrecios.Eliminar(id))
                            {
                                MessageBox.Show("eliminado satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarDatos(txtBuscar.text);
                            }
                            else
                            {
                                MessageBox.Show("Error al intentar eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guiaPreciossDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}
