using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using SGClubDeportivo.Controlador;
using SGClubDeportivo.Data;
using SGClubDeportivo.Vista.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using iTextSharp.tool.xml.html.head;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SGClubDeportivo.Vista.Gestiones
{
    public partial class frmGestionJugadors : frmGestiones
    {
        //ACA TENEMOS EL EJEMPLO CON FK CASI CRUD VIRGEN CON FK
        JugadorController _Jugadores = new JugadorController();
        public frmGestionJugadors()
        {
            InitializeComponent();
        }

        private void frmGestionjugadores_Load(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.text);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abrir un nuevo formulario para agregar Jugadoress
            frmCrudJugadores frmAgregar = new frmCrudJugadores();
            DialogResult result = frmAgregar.ShowDialog();

            // Recargar los datos si se agregó un Jugadores
            if (result == DialogResult.OK)
            {
                CargarDatos(txtBuscar.text);
            }
        }

        private void GenerarPDF()
        {

           

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GenerarPDF();
            // Filtrar los resultados en el DataGridView según el texto de búsqueda
            // string filtro = txtBuscar.text;
            //CargarDatos(filtro);

        }



        private void CargarDatos(string textSearch)
        {

            try
            {
                //_Jugadores = new JugadoreController(); //no olvidar esta linea para actualizar tabla //NO USAMOS PORQUE TENEMOS EL CELLCONTENTCLICK
                // Llamas al método Listar del controlador con el filtro
                JugadoresBindingSource.DataSource = _Jugadores.ListarCompleto(textSearch);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void JugadorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si se hizo clic en una celda de botón
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Verifica si se hizo clic en la columna "Editar"
                    if (JugadoresDataGridView.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        // Lógica para editar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(JugadoresDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                        frmCrudJugadores frmEditar = new frmCrudJugadores(id);
                        DialogResult result = frmEditar.ShowDialog();

                        // Recargar los datos si se editó un Jugadores
                        if (result == DialogResult.OK)
                        {
                            _Jugadores = new JugadorController(); //no olvidar esta linea para actualizar tabla
                            CargarDatos(txtBuscar.text);
                        }
                    }
                    // Verifica si se hizo clic en la columna "Eliminar"
                    else if (JugadoresDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        // Lógica para eliminar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(JugadoresDataGridView.Rows[e.RowIndex].Cells["id"].Value);

                        // Lógica para confirmar la eliminación
                        DialogResult confirmResult = MessageBox.Show("¿Estás seguro de eliminar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Lógica para eliminar el Jugadores
                            if (_Jugadores.Eliminar(id))
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
                    else if (JugadoresDataGridView.Columns[e.ColumnIndex].Name == "AddMensualidad")
                    {
                        // Lógica para editar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var idJugador = Convert.ToInt32(JugadoresDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                        var idGuiaPrecio = 0; //ES 0 PORQUE SOMOS EXTERNOS
                        frmCrudMensualidades frm = new frmCrudMensualidades(idJugador, idGuiaPrecio);
                        DialogResult result = frm.ShowDialog();

                        // Recargar los datos si se editó un Jugadores
                        if (result == DialogResult.OK)
                        {
                            _Jugadores = new JugadorController(); //no olvidar esta linea para actualizar tabla
                            CargarDatos(txtBuscar.text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void JugadorsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    // Verifica si se está pintando la columna "Editar"
                    if (JugadoresDataGridView.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                        System.Drawing.Icon icoEditar = new System.Drawing.Icon(Environment.CurrentDirectory + @"\editar.ico");
                        e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                        JugadoresDataGridView.Rows[e.RowIndex].Height = icoEditar.Height + 8;
                        JugadoresDataGridView.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

                        e.Handled = true;
                    }

                    // Verifica si se está pintando la columna "Eliminar"
                    if (JugadoresDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                        System.Drawing.Icon icoEliminar = new System.Drawing.Icon(Environment.CurrentDirectory + @"\eliminar.ico");
                        e.Graphics.DrawIcon(icoEliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                        JugadoresDataGridView.Rows[e.RowIndex].Height = icoEliminar.Height + 8;
                        JugadoresDataGridView.Columns[e.ColumnIndex].Width = icoEliminar.Width + 8;

                        e.Handled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---EN CASO DE TENER FK---//
        CategoriaController _cat =new CategoriaController();
        private void JugadoresDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ESTO SIRVE PARA REEMPLAZAR CON EL VALOR DE UN ATRIBUTO DE LA OTRA TABLA, EN VEZ DE id_fk reemplazar por un valor
            //NO OLVIDAR RENOMBRAR EN EL DATAGRIDVIEW EN EL (name) para q coincidan las columnas. //solo podemos cambiar el HeaderText del DataGridView
            if (JugadoresDataGridView.Columns[e.ColumnIndex].Name == "Categoria_id" && e.Value != null) 
            {
                int categoriaId = Convert.ToInt32(e.Value);

                Categorias categoria = _cat.Seleccionar(categoriaId);

                e.Value = categoria?.Nombre ?? string.Empty;
            }
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            string filtro = txtBuscar.text;
            CargarDatos(filtro);
        }
    }
}
