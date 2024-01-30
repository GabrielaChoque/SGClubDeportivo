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
    public partial class frmGestionUsuarios : frmGestiones
    {
        //NO OLVIDAR INTRODUCIR LOS BOTONES "Editar" y "Eliminar" en el datagridview (ambos en modoBoton) y el TrueuseColumnForButton ponerlo True, el id Cambiar el name a "id" y si quieres ponerlo visible False
        //TAMBIN NO OLVIDAR CAMBIAR EL name del DATAGRIDVIEW Y EL name de BINDINGSOURCE donde LA PRIMERA LETRA DEBERA SER MAYUSCULA
        //CRUD PRINCIPAL ORIGEN O FORMATO
        UsuarioController _Usuarios = new UsuarioController();
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }


        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.text);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abrir un nuevo formulario para agregar Usuarioss
            frmCrudUsuarios frmAgregar = new frmCrudUsuarios();
            DialogResult result = frmAgregar.ShowDialog();

            // Recargar los datos si se agregó un Usuarios
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
                //_Usuarios = new UsuarioController(); //no olvidar esta linea para actualizar tabla //NO USAMOS PORQUE TENEMOS EL CELLCONTENTCLICK
                // Llamas al método Listar del controlador con el filtro
                UsuariosBindingSource.DataSource = _Usuarios.Listar(textSearch);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UsuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si se hizo clic en una celda de botón
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Verifica si se hizo clic en la columna "Editar"
                    if (UsuariosDataGridView.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        // Lógica para editar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(UsuariosDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                        frmCrudUsuarios frmEditar = new frmCrudUsuarios(id);
                        DialogResult result = frmEditar.ShowDialog();

                        // Recargar los datos si se editó un Usuarios
                        if (result == DialogResult.OK)
                        {
                            _Usuarios = new UsuarioController(); //no olvidar esta linea para actualizar tabla
                            CargarDatos(txtBuscar.text);
                        }
                    }
                    // Verifica si se hizo clic en la columna "Eliminar"
                    else if (UsuariosDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        // Lógica para eliminar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(UsuariosDataGridView.Rows[e.RowIndex].Cells["id"].Value);

                        // Lógica para confirmar la eliminación
                        DialogResult confirmResult = MessageBox.Show("¿Estás seguro de eliminar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Lógica para eliminar el Usuarios
                            if (_Usuarios.Eliminar(id))
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
        private void UsuariosDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
        //HASTA ACA

    }
}
