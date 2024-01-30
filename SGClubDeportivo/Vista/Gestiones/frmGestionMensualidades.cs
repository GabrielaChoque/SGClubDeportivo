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
            //frmCrudMensualidades frmAgregar = new frmCrudMensualidades();
            frmCrudMensualidades frmAgregar = new frmCrudMensualidades((int)dataJugadoresSeleccionado.id,0); //agregar nuevo dato para mensualidades cuando es con 0
            DialogResult result = frmAgregar.ShowDialog();

            // Recargar los datos si se agregó un Mensualidades
            if (result == DialogResult.OK)
            {
                CargarMensualidadesJugador(txtBuscar.text);
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
            dataJugadoresSeleccionado = _jug.SeleccionarPorCI(txtBuscar.text);
            if (dataJugadoresSeleccionado == null )
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled= true;
                if (txtBuscar.text=="")
                {
                    btnAgregar.Enabled = false;
                }
            }
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
                    else if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "PrintBoleta")
                    {
                        // Lógica para eliminar la fila seleccionada
                        // Puedes obtener el ID u otra información de la fila seleccionada usando:
                        var idMensualidad = Convert.ToInt32(MensualidadesDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                        var FechaPago = Convert.ToDateTime(MensualidadesDataGridView.Rows[e.RowIndex].Cells["FechPago"].Value);
                        //OBTENER NOMBRE COMPLETO
                        int idjugador = Convert.ToInt32(MensualidadesDataGridView.Rows[e.RowIndex].Cells["Jugador_id"].Value);
                        Jugadores dataSelectJugador = _jug.Seleccionar(idjugador);
                        var NombreCompleto = dataSelectJugador.Nombres + " " + dataSelectJugador.Apellidos;
                        //Y LO DEMAS
                        var MontoPagado = Convert.ToInt32(MensualidadesDataGridView.Rows[e.RowIndex].Cells["CuotaFinal"].Value);
                        var ConceptoMensualidad = Convert.ToString(MensualidadesDataGridView.Rows[e.RowIndex].Cells["Concepto"].Value);
                        var MesFila = Convert.ToString(MensualidadesDataGridView.Rows[e.RowIndex].Cells["Mes"].Value);
                        ImprimirBoleta(idMensualidad, FechaPago, NombreCompleto, MontoPagado, ConceptoMensualidad, MesFila);

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
        //InscripcionController _ins = new InscripcionController(); ////ESTE CODIGO OBTIENE DESDE 2 TABLAS LA INFO - TRASPASA 2 TABLAS PARA OBTENER INFORMACION
        JugadorController _jug = new JugadorController();
        GuiaPrecioController _gPre = new GuiaPrecioController();
        UsuarioController _user = new UsuarioController();
        private void MensualidadesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //ESTO SIRVE PARA REEMPLAZAR CON EL VALOR DE UN ATRIBUTO DE LA OTRA TABLA, EN VEZ DE id_fk reemplazar por un valor
            //NO OLVIDAR RENOMBRAR EN EL DATAGRIDVIEW EN EL (name) para q coincidan las columnas. //solo podemos cambiar el HeaderText del DataGridView
            //if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "Jugador_id" && e.Value != null)
            //{
            //    //ESTE CODIGO OBTIENE DESDE 2 TABLAS LA INFO - TRASPASA 2 TABLAS PARA OBTENER INFORMACION
            //    //int inscripcionId = Convert.ToInt32(e.Value); //obtenemos el id del datagridView
            //    //Inscripciones inscripcion = _ins.Seleccionar(inscripcionId); //OBTENEMOS FILA EN EL INSCRIPCIONES (tenemos idJugador
            //    //int jugadorId = Convert.ToInt32(inscripcion.Jugador_id); //seleccionando Id jugador
            //    //Jugadores jugador = _jug.Seleccionar(jugadorId); //OBTENEMOS FILA EN EL Jugadores (tenemos idJugador
            //}
            if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "Jugador_id" && e.Value != null)
            {
                int jugadorId = Convert.ToInt32(e.Value); //seleccionando Id jugador
                Jugadores jugador = _jug.Seleccionar(jugadorId); //OBTENEMOS FILA EN EL Jugadores (tenemos idJugador
                e.Value = jugador?.Ci_jugador ?? string.Empty; //y el valor lo pongo en la coumna
            }
            if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "Guiaprecios_id" && e.Value != null)
            {
                int Guiaprecios_idId = Convert.ToInt32(e.Value); //seleccionando Id jugador
                GuiaPrecios gPrecios = _gPre.Seleccionar(Guiaprecios_idId); //OBTENEMOS FILA EN EL Jugadores (tenemos idJugador
                e.Value = gPrecios?.Concepto ?? string.Empty; //y el valor lo pongo en la coumna
            }
            if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "Guiaprecios_id1" && e.Value != null)
            {
                int Guiaprecios_idId = Convert.ToInt32(e.Value); //seleccionando Id jugador
                GuiaPrecios gPrecios = _gPre.Seleccionar(Guiaprecios_idId); //OBTENEMOS FILA EN EL Jugadores (tenemos idJugador
                e.Value = gPrecios?.Precio ?? null; //y el valor lo pongo en la coumna
            }
            if (MensualidadesDataGridView.Columns[e.ColumnIndex].Name == "Usuario_id" && e.Value != null)
            {
                int userId = Convert.ToInt32(e.Value); //seleccionando Id jugador
                Usuarios usuario = _user.Seleccionar(userId); //OBTENEMOS FILA EN EL Jugadores (tenemos idJugador
                string NomC = usuario.Apellidos + " " + usuario.Nombres;
                e.Value = NomC;
            }
        }
        private string ConvertirNumeroATexto(decimal numero)
        {
            if (numero < 0 || numero > 5000)
            {
                throw new ArgumentOutOfRangeException("Número fuera del rango admitido (0-5000)");
            }

            if (numero == 0)
            {
                return "CERO";
            }

            // Dividir la parte entera y la parte decimal
            int parteEntera = (int)Math.Floor(numero);
            int parteDecimal = (int)((numero - parteEntera) * 100);

            string[] unidades = { "", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE" };
            string[] especiales = { "", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE" };
            string[] decenas = { "", "DIEZ", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
            string[] centenas = { "", "CIEN", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS" };

            // Función interna para convertir números menores a 1000
            string ConvertirMenorATexto(int num)
            {
                if (num < 10)
                {
                    return unidades[num];
                }
                else if (num >= 10 && num < 20)
                {
                    return especiales[num - 10];
                }
                else if (num < 100)
                {
                    int unidad = num % 10;
                    int decena = num / 10;
                    return $"{decenas[decena]} {unidades[unidad]}".Trim();
                }
                else
                {
                    int centena = num / 100;
                    int residuo = num % 100;
                    return $"{centenas[centena]} {(residuo > 0 ? ConvertirMenorATexto(residuo) : "")}".Trim();
                }
            }

            // Convertir la parte entera y la parte decimal por separado
            string parteEnteraTexto = ConvertirMenorATexto(parteEntera);
            string parteDecimalTexto = ConvertirMenorATexto(parteDecimal);

            // Construir el resultado final
            if (parteDecimal == 0)
            {
                return parteEnteraTexto;
            }
            else
            {
                return $"{parteEnteraTexto} CON {parteDecimalTexto} CENTAVOS";
            }
        }


        private void ImprimirBoleta(int idMensualidad, DateTime FechaPago, string NombreJugador, int MontoPagado,string ConceptoMensualidad,string Mesfila)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf"; //nombre del pdf
            string paginahtml_texto = Properties.Resources.BoletaPago.ToString();//agregarmos Plantilla.html como recurso desde Proyecto -> Propiedades
            //REEMPLAZANDO LOS @NAME
            string MontoenTexto = ConvertirNumeroATexto(MontoPagado);
            paginahtml_texto = paginahtml_texto.Replace("@NUMERO", idMensualidad.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@FECHATEXTO", FechaPago.ToString("dd/mm/yyyy"));
            paginahtml_texto = paginahtml_texto.Replace("@NOMBRE", NombreJugador.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@MONTOPAGADO", MontoPagado.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@MONTOTXT", MontoenTexto);
            //paginahtml_texto = paginahtml_texto.Replace("@CONCEPTOPAGO", ConceptoMensualidad.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@MES", Mesfila.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@ESPACIO", " ");

            //GENERACION DE PDF O MANIOBRAS PDF
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
                // formato de fecha
                DateTime fecha = (DateTime)row.Cells["FechPago"].Value;
                string fechaFormateada = fecha.ToString("dd/MM/yyyy");
                //

                int idPrecios = Convert.ToInt32(row.Cells["Guiaprecios_id"].Value);
                GuiaPrecios gPrecios = _gPre.Seleccionar(idPrecios); //OBTENEMOS FILA EN EL Jugadores (tenemos idJugador
                

                filas += "<tr>";
                filas += "<td>" + row.Cells["Gestion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Mes"].Value.ToString() + "</td>";
                filas += "<td>" + gPrecios.Concepto.ToString() + "</td>"; //DE Q ES EL PAGO GUIA PRECIO
                filas += "<td>" + gPrecios.Precio.ToString() + "</td>"; //MONTO A PAGAR
                filas += "<td>" + row.Cells["Concepto"].Value.ToString() + "</td>"; //DESCRIPCION MENSUALIDAD
                filas += "<td>" + row.Cells["CuotaFinal"].Value.ToString() + "</td>"; //MONTO PAGADO
                filas += "<td>" + fechaFormateada + "</td>"; //FECHA DE PAGO MENSUALIDAD
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