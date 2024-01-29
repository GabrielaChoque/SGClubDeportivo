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
    public partial class frmGestionInscripciones : frmGestiones
    {
        InscripcionController _Inscripciones = new InscripcionController();
        public frmGestionInscripciones()
        {
            InitializeComponent();
        }


        private void frmGestionInscripciones_Load(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.text);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abrir un nuevo formulario para agregar Inscripcioness
            frmCrudInscripciones frmAgregar = new frmCrudInscripciones();
            DialogResult result = frmAgregar.ShowDialog();

            // Recargar los datos si se agregó un Inscripciones
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
                //_Inscripciones = new UsuarioController(); //no olvidar esta linea para actualizar tabla //NO USAMOS PORQUE TENEMOS EL CELLCONTENTCLICK
                // Llamas al método Listar del controlador con el filtro
                InscripcionesBindingSource.DataSource = _Inscripciones.Listar(textSearch);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InscripcionesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si se hizo clic en una celda de botón
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Verifica si se hizo clic en la columna "Editar"
                    if (InscripcionesDataGridView.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        // Lógica para editar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(InscripcionesDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                        frmCrudInscripciones frmEditar = new frmCrudInscripciones(id);
                        DialogResult result = frmEditar.ShowDialog();

                        // Recargar los datos si se editó un Inscripciones
                        if (result == DialogResult.OK)
                        {
                            _Inscripciones = new InscripcionController(); //no olvidar esta linea para actualizar tabla
                            CargarDatos(txtBuscar.text);
                        }
                    }
                    // Verifica si se hizo clic en la columna "Eliminar"
                    else if (InscripcionesDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        // Lógica para eliminar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(InscripcionesDataGridView.Rows[e.RowIndex].Cells["id"].Value);

                        // Lógica para confirmar la eliminación
                        DialogResult confirmResult = MessageBox.Show("¿Estás seguro de eliminar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Lógica para eliminar el Inscripciones
                            if (_Inscripciones.Eliminar(id))
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
        private void InscripcionesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
        //------FK-----//
        UsuarioController _user = new UsuarioController();
        JugadorController _jug = new JugadorController();
        GuiaPrecioController _gPre = new GuiaPrecioController();
        private void InscripcionesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ESTO SIRVE PARA REEMPLAZAR CON EL VALOR DE UN ATRIBUTO DE LA OTRA TABLA, EN VEZ DE id_fk reemplazar por un valor
            //NO OLVIDAR RENOMBRAR EN EL DATAGRIDVIEW EN EL (name) para q coincidan las columnas. //solo podemos cambiar el HeaderText del DataGridView
            if (InscripcionesDataGridView.Columns[e.ColumnIndex].Name == "Usuario_id" && e.Value != null)
            {
                int usuarioId = Convert.ToInt32(e.Value);

                Usuarios usuario = _user.Seleccionar(usuarioId);

                e.Value = usuario?.Nombres ?? string.Empty;
            }
            if (InscripcionesDataGridView.Columns[e.ColumnIndex].Name == "Jugador_id" && e.Value != null)
            {
                int jugadorId = Convert.ToInt32(e.Value);

                Jugadores jugador = _jug.Seleccionar(jugadorId);

                e.Value = jugador?.Ci_jugador ?? string.Empty;
            }
            if (InscripcionesDataGridView.Columns[e.ColumnIndex].Name == "Guiaprecios_id" && e.Value != null)
            {
                int guiaprecioId = Convert.ToInt32(e.Value);

                GuiaPrecios gprecios= _gPre.Seleccionar(guiaprecioId);

                e.Value = gprecios?.Concepto ?? string.Empty;
            }
        }
    }
}
