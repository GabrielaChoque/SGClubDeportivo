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
    public partial class frmGestionCategorias : frmGestiones
    {
        private CategoriaController _categoria = new CategoriaController();
        public frmGestionCategorias()
        {
            InitializeComponent();

        }

        private void frmGestionCategorias_Load(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abrir un nuevo formulario para agregar Categorias
            frmCrudCategorias frmAgregar = new frmCrudCategorias();
            DialogResult result = frmAgregar.ShowDialog();

            // Recargar los datos si se agregó un Categoria
            if (result == DialogResult.OK)
            {
                CargarDatos(txtBuscar.text);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar los resultados en el DataGridView según el texto de búsqueda
            string filtro = txtBuscar.text;
            //CategoriasBindingSource.Filter = $"Username LIKE '%{filtro}%' OR Nombres LIKE '%{filtro}%' OR Apellidos LIKE '%{filtro}%'";
            CargarDatos(filtro);
        }

        

        private void CargarDatos(string textSearch)
        {
            // Cargar los datos de la base de datos en el DataGridView
            //this.CategoriasTableAdapter.Fill(this.bdClubDeportivoDataSet.Categorias);
            //CategoriasBindingSource.DataSource = _categoria.Listar(textSearch);
            try
            {
                
                List<Categorias> categorias = _categoria.Listar(textSearch);
                categoriasBindingSource.DataSource = categorias;
                //// Llamas al método Listar del controlador con el filtro
                //var listaCategorias = _categoria.Listar(textSearch);

                //// Actualizas el origen de datos del BindingSource con la nueva lista
                //categoriasBindingSource.DataSource = listaCategorias;

                //// Refrescas el DataGridView para que muestre los nuevos datos
                //categoriasDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarCategoria(int idCategoria)
        {
            try
            {
                // Lógica para eliminar el Categoria en la base de datos
                // Utiliza el idCategoria para identificar al Categoria que se va a eliminar
                // Puedes implementar esta lógica según la estructura de tu base de datos

                // Ejemplo:
                // CategoriasTableAdapter.DeleteCategoria(idCategoria);
                // this.CategoriasTableAdapter.Fill(this.bdClubDeportivoDataSet.Categorias);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el Categoria. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CategoriasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si se hizo clic en una celda de botón
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Verifica si se hizo clic en la columna "Editar"
                    if (categoriasDataGridView.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        // Lógica para editar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(categoriasDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                        frmCrudCategorias frmEditar = new frmCrudCategorias(id);
                        DialogResult result = frmEditar.ShowDialog();

                        // Recargar los datos si se editó un Categoria
                        if (result == DialogResult.OK)
                        {
                            _categoria = new CategoriaController();
                            CargarDatos(txtBuscar.Text);
                            
                        }
                    }
                    // Verifica si se hizo clic en la columna "Eliminar"
                    else if (categoriasDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        // Lógica para eliminar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(categoriasDataGridView.Rows[e.RowIndex].Cells["id"].Value);

                        // Lógica para confirmar la eliminación
                        DialogResult confirmResult = MessageBox.Show("¿Estás seguro de eliminar este Categoria?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Lógica para eliminar el Categoria
                            if (_categoria.EliminarCategoria(id))
                            {
                                MessageBox.Show("Categoria eliminado satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarDatos(txtBuscar.Text);
                            }
                            else
                            {
                                MessageBox.Show("Error al intentar eliminar el Categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CategoriasDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.text);
        }
    }
}
