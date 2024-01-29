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

//IMPORTANDO PARA ITESHARP PDF
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
    public partial class frmGestionMensualidades : frmGestiones
    {
        MensualidadController _Mensualidades = new MensualidadController();
        public frmGestionMensualidades()
        {
            InitializeComponent();
        }


        private void frmGestionMensualidades_Load(object sender, EventArgs e)
        {
            CargarMensualidadesJugador(txtBuscar.text);
            //MessageBox.Show("CARGACION");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abrir un nuevo formulario para agregar Mensualidadess
            frmCrudMensualidades frmAgregar = new frmCrudMensualidades();
            DialogResult result = frmAgregar.ShowDialog();

            // Recargar los datos si se agregó un Mensualidades
            if (result == DialogResult.OK)
            {
                CargarDatos(txtBuscar.text);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar los resultados en el DataGridView según el texto de búsqueda
            string filtro = txtBuscar.text;
            CargarMensualidadesJugador(txtBuscar.text);
            //CargarDatos(filtro);
        }

        Jugadores dataJugadoresSeleccionado = new Jugadores();
        public void CargarMensualidadesJugador(string textSearch)
        {
            MensualidadesBindingSource.DataSource = _Mensualidades.CargarJugadoresConMensualidades(textSearch);
            dataJugadoresSeleccionado = _jug.SeleccionarPorCI(txtBuscar.text);//--------------------------------------------------------
        }


        private void CargarDatos(string textSearch)
        {

            try
            {
                //_Mensualidades = new MensualidadeController(); //no olvidar esta linea para actualizar tabla //NO USAMOS PORQUE TENEMOS EL CELLCONTENTCLICK
                // Llamas al método Listar del controlador con el filtro
                MensualidadesBindingSource.DataSource = _Mensualidades.Listar(textSearch);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MensualidadesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si se hizo clic en una celda de botón
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Verifica si se hizo clic en la columna "Editar"
                    if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        // Lógica para editar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(MensualidadesDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                        frmCrudMensualidades frmEditar = new frmCrudMensualidades(id);
                        DialogResult result = frmEditar.ShowDialog();

                        // Recargar los datos si se editó un Mensualidades
                        if (result == DialogResult.OK)
                        {
                            _Mensualidades = new MensualidadController(); //no olvidar esta linea para actualizar tabla
                            CargarDatos(txtBuscar.text);
                        }
                    }
                    // Verifica si se hizo clic en la columna "Eliminar"
                    else if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        // Lógica para eliminar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var id = Convert.ToInt32(MensualidadesDataGridView.Rows[e.RowIndex].Cells["id"].Value);

                        // Lógica para confirmar la eliminación
                        DialogResult confirmResult = MessageBox.Show("¿Estás seguro de eliminar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Lógica para eliminar el Mensualidades
                            if (_Mensualidades.Eliminar(id))
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
        private void MensualidadesDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---EN CASO DE TENER FK---//
        InscripcionController _ins = new InscripcionController();
        JugadorController _jug = new JugadorController();
        private void MensualidadesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //ESTO SIRVE PARA REEMPLAZAR CON EL VALOR DE UN ATRIBUTO DE LA OTRA TABLA, EN VEZ DE id_fk reemplazar por un valor
            //NO OLVIDAR RENOMBRAR EN EL DATAGRIDVIEW EN EL (name) para q coincidan las columnas. //solo podemos cambiar el HeaderText del DataGridView
            if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "Inscripcion_id" && e.Value != null)
            {
                int inscripcionId = Convert.ToInt32(e.Value); //obtenemos el id del datagridView
                Inscripciones inscripcion = _ins.Seleccionar(inscripcionId); //OBTENEMOS FILA EN EL INSCRIPCIONES (tenemos idJugador

                int jugadorId = Convert.ToInt32(inscripcion.Jugador_id); //seleccionando Id jugador
                Jugadores jugador = _jug.Seleccionar(jugadorId); //OBTENEMOS FILA EN EL Jugadores (tenemos idJugador

                e.Value = jugador?.Ci_jugador ?? string.Empty; //y el valor lo pongo en la coumna
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf"; //nombre del pdf
            //string paginahtml_texto = "<table><tr>ctd>HOLA MUNDO</td></trx</table>";
            string paginahtml_texto = Properties.Resources.Plantilla.ToString();//agregarmos Plantilla.html como recurso desde Proyecto -> Propiedades

            //remplazacion de los caracteres especiales que pusimos dentro de la plantilla html @NAME
            //ejemplo: //paginahtml_texto = paginahtml_texto.Replace("@NAME", txt.text);
            //para fechas seria: paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            //para tablas de Base de Datos 
            //opcion 1 - SE REQUIERE PONER NOMBRES A LACA COLUMNA EN CADA TABLA (name)
            //string filas = string.Empty;
            //decimal total = 0;
            //foreach (DataGridViewRow row in dgvproductos.Rows)
            //{
            //    filas += "<tr>";
            //    filas += "<td>" + row.Cells["Fila1"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["Fila2"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["Fila3"].Value.ToString() + "</td>";
            //    filas += "<td>" + row.Cells["Fila4"].Value.ToString() + "</td>";
            //    filas += "</tr>";
            //    total += decimal.Parse(row.Cells["Fila5"].Value.ToString());
            //}
            //paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);
            //opcion 2 - es automatico pero es desordenado las columnas
            //string filas = string.Empty;
            //foreach (DataGridViewRow row in MensualidadesDataGridView.Rows)
            //{
            //    filas += "<tr>";
            //    foreach (DataGridViewColumn column in MensualidadesDataGridView.Columns)
            //    {
            //        string nombreColumna = column.DataPropertyName;
            //        // Verificar si la columna tiene un nombre de propiedad asociado
            //        if (!string.IsNullOrEmpty(nombreColumna))
            //        {
            //            // Obtener el valor de la celda usando el nombre de propiedad
            //            object valorCelda = row.Cells[column.Index].Value;

            //            // Añadir la celda a la fila
            //            filas += "<td>" + (valorCelda != null ? valorCelda.ToString() : "") + "</td>";
            //        }
            //    }
            //    filas += "</tr>";
            //}
            //paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);


            //REEMPLAZANDO LOS @NAME
            string Carnetpdf = dataJugadoresSeleccionado.Ci_jugador.ToUpper();
            string Nombrepdf = dataJugadoresSeleccionado.Nombres.ToUpper() + " " + dataJugadoresSeleccionado.Apellidos.ToUpper();

            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", Nombrepdf);
            paginahtml_texto = paginahtml_texto.Replace("@DOCUMENTO", Carnetpdf);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            // PARA REEMPLAZAR EN TABLA @FILAS , seleccione la OPCION 1 para hacer al parecer hay q poner (name) a las columnas del datagridview
            string filas = string.Empty;
            foreach (DataGridViewRow row in MensualidadesDataGridView.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Gestion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Mes"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Concepto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Correlativo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descuento"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["CuotaRegular"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["CuotaFinal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

            //ACCIONES NECESARIAS PARA EL PDF - ESTE DIRECTAMENTE GENERA PARA GUARDAR EL PDF
            //if (guardar.ShowDialog() == DialogResult.OK)
            //{
            //    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
            //    {
            //        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
            //        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
            //        pdfDoc.Open();
            //        pdfDoc.Add(new Phrase("")); // AÑADE TEXTO AL PDF


            //        // Utilizar StreamReader para leer la cadena HTML //ES DELICADO EL ITESHAPR hay q usar sin el < meta charset = "UTF-8" >
            //        using (StringReader sr = new StringReader(paginahtml_texto))
            //        {
            //            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
            //        }

            //        pdfDoc.Close();
            //        stream.Close();
            //    }
            //}
            //ACCIONES NECESARIAS PARA EL PDF - ESTE GUARDA Y LUEGO PREVIZUALIZA
            //if (guardar.ShowDialog() == DialogResult.OK)
            //{
            //    string filePath = guardar.FileName;

            //    using (FileStream stream = new FileStream(filePath, FileMode.Create))
            //    {
            //        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
            //        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
            //        pdfDoc.Open();
            //        pdfDoc.Add(new Phrase("")); // AÑADE TEXTO AL PDF

            //        // Utilizar StreamReader para leer la cadena HTML
            //        using (StringReader sr = new StringReader(paginahtml_texto))
            //        {
            //            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
            //        }

            //        pdfDoc.Close();
            //        stream.Close();
            //    }

            //    // Mostrar un mensaje de éxito o hacer otras acciones si es necesario

            //    // Abrir el PDF con un visor externo para previsualización
            //    try
            //    {
            //        Process.Start(filePath);
            //    }
            //    catch (Exception ex)
            //    {
            //        // Manejar cualquier excepción que pueda ocurrir al intentar abrir el visor de PDF
            //        MessageBox.Show("No se pudo abrir el visor de PDF. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

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
    }
}