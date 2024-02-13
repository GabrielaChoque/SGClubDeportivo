using SGClubDeportivo.Controlador;
using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubDeportivo.Vista.Ventanas
{
    public partial class frmCrudMensualidades : frmVentanas
    {
        private MensualidadController _MensualidadeController = new MensualidadController();
        private bool esNuevo = true;
        private bool esExterno = false; //para saber si este formulario fue invocado desde una ventana que no le corresponde
        private int ide;
        Mensualidades dataMensualidadesSeleccionado = new Mensualidades();

        public frmCrudMensualidades()
        {
            InitializeComponent();
        }
        //SI ES MODIFICAR SOLO SE REQUIERE ID MENSUALIZADO
        public frmCrudMensualidades(int ideSeleccionado)
        {
            esNuevo = false;
            ide = ideSeleccionado;
            InitializeComponent();
        }
        //SI ES AGREGAR NUEVA MENSUALIDAD NECESITAMOS ESTOS PARAMETROS
        private int _idJugador, _idGuiaPrecio;
        public frmCrudMensualidades(int idJugador, int idGuiaPrecio) //SI ES 0 GUIA DE PRECIO ESTA VENTANA SE ABRIA ASI NOMAS EXTERNAMENTE
        {
            esNuevo = true;
            _idJugador = idJugador;
            if (idGuiaPrecio != 0)
            {
                _idGuiaPrecio = idGuiaPrecio;
            }
            else
            {
                esExterno = true;
                _idGuiaPrecio = 0;
            }
            InitializeComponent();
        }

        private void frmCrudMensualidades_Load(object sender, EventArgs e)
        {
            conceptoTextBox.Text = "Pago de mensualidad de entrenamiento";
            //if (esNuevo)
            //{
            //    // Configuración para un nuevo registro
            //    MensualidadesBindingSource.AddNew();
            //    lblTituloCrud.Text = "REGISTRAR NUEVO";
            //    AutoSeleccionAlgunosParametros(); //auto seleccionamos algunos campos

            //}
            //else
            //{
            //    //MessageBox.Show("ss",esNuevo.ToString());
            //    lblTituloCrud.Text = "MODIFICAR ";
            //    // Cargar datos del categoria existente para edición
            //    try
            //    {
            //        //INTENTANDO PONER LOS DATOS EN LA VENTANA SI SE PUEDE (NORMALMENTE SE PONE CUANDO LOS DATOS PROVIENEN DE LA GESTION QUE CORRESPONDO, SI ES EXTERNO ENTONCES PASARA POR CATCH EL CODIGO
            //        dataMensualidadesSeleccionado = _MensualidadeController.Seleccionar(ide);
            //        MensualidadesBindingSource.DataSource = dataMensualidadesSeleccionado;
            //    }catch(Exception ex)
            //    {
            //        //DA ERROR PORQUE DEBE SER PORQUE ABRIMOS DESDE UN FORM QUE NO CORRESPONDE O EXTERNO

            //        esNuevo = true; //por lo tanto es nuevo
            //        AutoSeleccionAlgunosParametros(); //auto seleccionamos algunos campos


            //    }

            //}
            if (esNuevo)
            {
                // Configuración para un nuevo registro
                MensualidadesBindingSource.AddNew();                
                lblTituloCrud.Text = "REGISTRAR NUEVA MENSUALIDAD";
                AutoSeleccionAlgunosParametros(); //auto seleccionamos algunos campos

            }
            else
            {
                if (esExterno)
                {
                    esNuevo = true;
                }else{
                    lblTituloCrud.Text = "MODIFICAR MENSUALIDAD";
                    dataMensualidadesSeleccionado = _MensualidadeController.Seleccionar(ide);
                    MensualidadesBindingSource.DataSource = dataMensualidadesSeleccionado;
                }
               
            }
            //CargarInscripcionesJugadores();
            AutoSeleccionAlgunosParametros();
            CargarGuiaPrecios();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //var reg = PonerDatosForm((int)dataMensualidadesSeleccionado.Jugador_id,GlobalVariables.idUsuario,(int)dataMensualidadesSeleccionado.Guiaprecios_id);

            if (CamposValidos())
            {
                if (esNuevo)
                {
                    var reg = PonerDatosForm(_idJugador, GlobalVariables.idUsuario, _idGuiaPrecio);
                    // Agregar nuevo categoria
                    if (_MensualidadeController.Insertar(reg))
                    {
                        MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        Close();
                    }
                }
                else
                {
                    var reg = PonerDatosForm((int)dataMensualidadesSeleccionado.Jugador_id, GlobalVariables.idUsuario, (int)dataMensualidadesSeleccionado.Guiaprecios_id);
                    // Actualizar categoria existente
                    if (_MensualidadeController.Modificar(reg))
                    {
                        MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("INTRODUZCA LOS CAMPOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
            }
               
        }

        GuiaPrecioController _gPre =new GuiaPrecioController();
        private Mensualidades PonerDatosForm(int idJugador, int idUsuario, int idGuiaPrecio)
        {
            //    var reg = (Mensualidades)MensualidadesBindingSource.Current;
            //    Jugadores selectedJugadores = (Jugadores)ci_jugadorComboBox.SelectedItem;

            //    Inscripciones selectedInscripciones = (Inscripciones)_ins.BuscarPorIdJugador(selectedJugadores.id); //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            //    reg.Inscripcion_id = selectedInscripciones.id;  //OBTENIENDO LA id DEL FK
            //    return reg;

            //ESTO ERA PARA OBTENER LA FILA SELECCIONADA DEL COMBOBOX DE JUGADORES; PERO NO ES NECESARIO YA Q MODIFICAREMOS DEL JUGADOR SELECCIONADO
            //var reg = (Mensualidades)MensualidadesBindingSource.Current;
            //Jugadores selectedJugadores = (Jugadores)ci_jugadorComboBox.SelectedItem;

            //Inscripciones selectedInscripciones = _ins.BuscarPorIdJugador(selectedJugadores.id); //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            //reg.Inscripcion_id = selectedInscripciones.id;  //OBTENIENDO LA id DEL FK
            //return reg;

            //var reg = (Mensualidades)MensualidadesBindingSource.Current;
            //Jugadores selectedJugadores = (Jugadores)ci_jugadorComboBox.SelectedItem;

            //Inscripciones selectedInscripciones = _ins.BuscarPorIdJugador(selectedJugadores.id);

            //if (selectedInscripciones != null)
            //{
            //    reg.Inscripcion_id = selectedInscripciones.id;
            //}
            //else
            //{
            //    Manejar el caso donde no se encuentra la inscripción
            //    MessageBox.Show("No se encontró la inscripción para el jugador seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //return reg;


            var reg = (Mensualidades)MensualidadesBindingSource.Current;
            reg.Jugador_id = idJugador;
            reg.Usuario_id = idUsuario;
            reg.FechPago = DateTime.Now;
            reg.CuotaFinal = (int)cuotaFinalNumericUpDown.Value;
            

            object valorSeleccionado = conceptoComboBox.SelectedValue;
            if (valorSeleccionado != null)
            {
                int idSeleccionado = Convert.ToInt32(valorSeleccionado);
                reg.Guiaprecios_id = idSeleccionado;  //OBTENIENDO LA id DEL FK
            }
            //GuiaPrecios selectedGuiaPrecios = (GuiaPrecios)conceptoComboBox.SelectedItem; //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            //reg.Guiaprecios_id = selectedGuiaPrecios.id;  //OBTENIENDO LA id DEL FK
            //GuiaPrecios selectedGuiaPrecio = _gPre.Seleccionar(idGuiaPrecio); //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            //reg.Guiaprecios_id = selectedGuiaPrecio.id;
            return reg;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //----FK------//
        JugadorController _jug = new JugadorController();
        //InscripcionController _ins = new InscripcionController();
        BdClubDeportivoEntities _entity = new BdClubDeportivoEntities();
        private void CargarInscripcionesJugadores()
        {
            //opcion 1
            //ci_jugadorComboBox.DisplayMember = "Ci_jugador"; //esto es del MOSTRAR MIEMBRO, el mismo nombre en el cmb
            //ci_jugadorComboBox.DataSource = _jug.Listar("");
            //ci_jugadorComboBox.SelectedIndex = 0;
            //opcion 2
            //var r = from ru in _entity.Categorias
            //        select new { ru.Nombre };
            //nombreComboBox.DisplayMember = "Nombre";
            //nombreComboBox.DataSource = r.ToList();
            //nombreComboBox.SelectedIndex = 0;
            //opcion 3
            // Obtén el objeto Mensualidades actualmente enlazado al formulario
            var reg = (Mensualidades)MensualidadesBindingSource.Current;

            // Lista de jugadores para llenar el ComboBox
            //List<Jugadores> jugadores = _jug.Listar("");

            // Enlaza los datos al ComboBox
            //ci_jugadorComboBox.DisplayMember = "Ci_jugador";
            //ci_jugadorComboBox.DataSource = jugadores;

            // Si estás en modo de edición (no es un nuevo registro), selecciona el jugador correcto
            //if (!esNuevo)
            //{
            //    if (reg.Inscripciones != null && reg.Inscripciones.Jugador_id.HasValue)
            //    {
            //        // Busca el jugador asociado a la inscripción actual
            //        Jugadores jugadorSeleccionado = _jug.Seleccionar(reg.Inscripciones.Jugador_id.Value);

            //        // Si se encuentra el jugador, lo selecciona en el ComboBox
            //        if (jugadorSeleccionado != null)
            //        {
            //            ci_jugadorComboBox.SelectedItem = jugadorSeleccionado;
            //        }
            //        else
            //        {
            //            // Maneja el caso donde no se encuentra el jugador
            //            MessageBox.Show("No se encontró el jugador asociado a la inscripción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //    else
            //    {
            //        // Maneja el caso donde el Jugador_id es nulo en la inscripción
            //        MessageBox.Show("La inscripción no tiene un jugador asociado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    // Si es un nuevo registro, selecciona el primer elemento por defecto
            //    ci_jugadorComboBox.SelectedIndex = 0;
            //}

        }
        List<GuiaPrecios> listaGuiaPrecios; //equivalente a lista = []
        private void CargarGuiaPrecios()
        {
            if (esNuevo)
            {
                //opcion 1
                conceptoComboBox.DisplayMember = "Concepto";
                conceptoComboBox.ValueMember = "id";
                listaGuiaPrecios = _gPre.Listar("");
                conceptoComboBox.DataSource = listaGuiaPrecios;
                //conceptoComboBox.SelectedIndex = 0;
                //opcion 2
                //var r = from ru in _entity.Categorias
                //        select new { ru.Nombre };
                //nombreComboBox.DisplayMember = "Nombre";
                //nombreComboBox.DataSource = r.ToList();
                //nombreComboBox.SelectedIndex = 0;
            }
            else
            {
                try
                {
                    conceptoComboBox.DisplayMember = "Concepto";
                    conceptoComboBox.ValueMember = "id";
                    listaGuiaPrecios = _gPre.Listar("");
                    conceptoComboBox.DataSource = listaGuiaPrecios;
                    //conceptoComboBox.SelectedItem = dataMensualidadesSeleccionado.Guiaprecios_id;
                    if (dataMensualidadesSeleccionado != null)
                    {
                        //ESTO AHCE Q SE SELECCIONE CORRECTAMENTE EL VALOR EN EL comboboxGuiaPrecios
                        GuiaPrecios guiaSeleccionado = _gPre.Seleccionar(dataMensualidadesSeleccionado.Guiaprecios_id ?? 0); //si saca null entonces poner 0
                        conceptoComboBox.SelectedItem = guiaSeleccionado;
                    }
                    else
                    {
                        // Manejo de la situación cuando dataMensualidadesSeleccionado es null
                        conceptoComboBox.SelectedItem = 0;  // O cualquier otro valor predeterminado que desees
                    }


                }
                catch (Exception ex)
                {
                    //USADO CUANDO ESTE FORM SE ABRE DESDE UN FORM EXTERNO QUE NO CORRESPONDA
                    conceptoComboBox.DisplayMember = "Concepto";
                    conceptoComboBox.ValueMember = "id";
                    listaGuiaPrecios = _gPre.Listar("");
                    conceptoComboBox.DataSource = listaGuiaPrecios;
                    conceptoComboBox.SelectedIndex = 0;
                }
               
            }
        }

        private void conceptoComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            //USADO SI QUIEREMOS MOSTRAR MAS ATRIBUTOS EN UN COMBOBOX
            if (e.DesiredType == typeof(string))
            {
                GuiaPrecios guiaPrecios = e.ListItem as GuiaPrecios;

                if (guiaPrecios != null)
                {
                    // Personaliza cómo se mostrará cada elemento en el ComboBox
                    e.Value = $"{guiaPrecios.Concepto} - {guiaPrecios.Precio}Bs";
                }
            }
        }
        private void AutoSeleccionAlgunosParametros()
        {
            if (esNuevo)
            {
                DateTime fechaActual = DateTime.Now;

                // Obtener el año
                int anio = fechaActual.Year;

                // Obtener el mes como número (1 para enero, 2 para febrero, etc.)
                int numeroMes = fechaActual.Month;

                // Obtener el nombre del mes
                string nombreMes = fechaActual.ToString("MMMM");

                // Para obtener el nombre del mes en mayúsculas
                string nombreMesMayusculas = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numeroMes).ToUpper();

                //PONER VALORES FISICAMENTE
                mesComboBox.Text = nombreMesMayusculas;
                gestionNumericUpDown.Value = anio;
                fechPagoDateTimePicker.Value = fechaActual;
                conceptoTextBox.Text = "Pago de mensualidad de entrenamiento";

                //PONER VALORES INTERNAMENTE para que se ponga por el data binding
                var reg = (Mensualidades)MensualidadesBindingSource.Current;
                reg.Mes = nombreMesMayusculas;
                reg.Gestion = anio;
                reg.FechPago = fechaActual;
                reg.Concepto = "Pago de mensualidad de entrenamiento";
            }

        }

        private void conceptoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var GuiaPrecioSeleccionado = (GuiaPrecios)conceptoComboBox.SelectedItem;

            if (GuiaPrecioSeleccionado != null)
            {
                GuiaPrecios filagPrecios = _gPre.Seleccionar(GuiaPrecioSeleccionado.id);
                cuotaFinalNumericUpDown.Value = (int)filagPrecios.Precio;
            }
        }

        private bool CamposValidos() //PARA REALIZAR VALIDACIONES
        {
            // Aquí debes realizar las validaciones necesarias, por ejemplo:
            
            if (string.IsNullOrWhiteSpace(mesComboBox.Text) || string.IsNullOrWhiteSpace(cuotaFinalNumericUpDown.Text) || string.IsNullOrWhiteSpace(conceptoComboBox.Text) || string.IsNullOrWhiteSpace(fechPagoDateTimePicker.Text))
            {
                return false;
            }

            // Puedes agregar más validaciones según los requisitos de tus campos

            return true;
        }
    }
}
