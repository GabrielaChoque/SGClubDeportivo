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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf"; //nombre del pdf
            //string paginahtml_texto = "<table><tr>ctd>HOLA MUNDO</td></trx</table>";
            string paginahtml_texto = Properties.Resources.PlantillaJugadores.ToString();//agregarmos Plantilla.html como recurso desde Proyecto -> Propiedades

            //remplazacion de los caracteres especiales que pusimos dentro de la plantilla html @NAME
            //ejemplo: //paginahtml_texto = paginahtml_texto.Replace("@NAME", txt.text);
            //para fechas seria: paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));


            //REEMPLAZANDO LOS @NAME
            string NombreSesion = GlobalVariables.NomC.ToUpper();
            //string NameAdmin = "sss";


            paginahtml_texto = paginahtml_texto.Replace("@ADMIN", NombreSesion);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            // PARA REEMPLAZAR EN TABLA @FILAS , seleccione la OPCION 1 para hacer al parecer hay q poner (name) a las columnas del datagridview
            string filas = string.Empty;
            foreach (DataGridViewRow row in JugadoresDataGridView.Rows)
            {
                // formato de fecha
                DateTime fecha = (DateTime)row.Cells["FechaNacimiento"].Value;
                string fechaFormateada = fecha.ToString("dd/MM/yyyy"); //NUEVO FORMATO DE FECHA DE NACIMIENTO
                                                                       //
                Categorias CategoriaFila = _cat.Seleccionar((int)row.Cells["Categoria_id"].Value);




                filas += "<tr>";
                filas += "<td>" + row.Cells["Ci_jugador"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Tipo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Nombres"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Apellidos"].Value.ToString() + "</td>";
                filas += "<td>" + fechaFormateada + "</td>"; //FECHA DE NACIMIENTO
                filas += "<td>" + CategoriaFila.Nombre.ToString() + "</td>"; //DICE Categoria_id; pero sabemos que en datagrid esta con SUB 11,12 ETC
                filas += "</tr>";
            }
            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);


            //opcion 3 - PREVIZUALIZA   EN NUESTRO ABRIDOR DE PDF POR DEFECTO DE LA MAQUINA - PREVIZUALIZA EXTERNAMENTE EL PDF
            // Crear un archivo temporal para almacenar el PDF antes de decidir guardarlo físicamente
            string tempFilePath = Path.GetTempFileName() + ".pdf";

            using (FileStream stream = new FileStream(tempFilePath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase("")); // AÑADE TEXTO AL PDF

                // Utilizar StreamReader para leer la cadena HTML
                using (StringReader sr = new StringReader(paginahtml_texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
            }

            // Abrir el PDF en el navegador predeterminado
            try
            {
                Process.Start(tempFilePath);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al intentar abrir el navegador predeterminado
                MessageBox.Show("No se pudo abrir el navegador predeterminado. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
