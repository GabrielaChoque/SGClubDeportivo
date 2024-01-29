using SGClubDeportivo.Controlador;
using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubDeportivo.Vista.Ventanas
{
    public partial class frmCrudMensualidades : frmVentanas
    {
        private MensualidadController _MensualidadeController = new MensualidadController();
        private bool esNuevo = true;
        private int ide;

        public frmCrudMensualidades()
        {
            InitializeComponent();
        }
        public frmCrudMensualidades(int ideSeleccionado)
        {
            esNuevo = false;
            ide = ideSeleccionado;
            InitializeComponent();
        }


        private void frmCrudMensualidades_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                // Configuración para un nuevo registro
                MensualidadesBindingSource.AddNew();
                lblTituloCrud.Text = "REGISTRAR NUEVO";
            }
            else
            {
                lblTituloCrud.Text = "MODIFICAR ";
                // Cargar datos del categoria existente para edición
                MensualidadesBindingSource.DataSource = _MensualidadeController.Seleccionar(ide);
            }
            CargarInscripcionesJugadores();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var reg = PonerDatosForm();

            if (esNuevo)
            {
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
                // Actualizar categoria existente
                if (_MensualidadeController.Modificar(reg))
                {
                    MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                    this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                    Close();
                }
            }
        }

        private Mensualidades PonerDatosForm()
        {
            //    var reg = (Mensualidades)MensualidadesBindingSource.Current;
            //    Jugadores selectedJugadores = (Jugadores)ci_jugadorComboBox.SelectedItem;

            //    Inscripciones selectedInscripciones = (Inscripciones)_ins.BuscarPorIdJugador(selectedJugadores.id); //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            //    reg.Inscripcion_id = selectedInscripciones.id;  //OBTENIENDO LA id DEL FK
            //    return reg;

            var reg = (Mensualidades)MensualidadesBindingSource.Current;
            Jugadores selectedJugadores = (Jugadores)ci_jugadorComboBox.SelectedItem;

            Inscripciones selectedInscripciones = _ins.BuscarPorIdJugador(selectedJugadores.id); //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            reg.Inscripcion_id = selectedInscripciones.id;  //OBTENIENDO LA id DEL FK
            return reg;

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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //----FK------//
        JugadorController _jug = new JugadorController();
        InscripcionController _ins = new InscripcionController();
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
            List<Jugadores> jugadores = _jug.Listar("");

            // Enlaza los datos al ComboBox
            ci_jugadorComboBox.DisplayMember = "Ci_jugador";
            ci_jugadorComboBox.DataSource = jugadores;

            // Si estás en modo de edición (no es un nuevo registro), selecciona el jugador correcto
            if (!esNuevo)
            {
                if (reg.Inscripciones != null && reg.Inscripciones.Jugador_id.HasValue)
                {
                    // Busca el jugador asociado a la inscripción actual
                    Jugadores jugadorSeleccionado = _jug.Seleccionar(reg.Inscripciones.Jugador_id.Value);

                    // Si se encuentra el jugador, lo selecciona en el ComboBox
                    if (jugadorSeleccionado != null)
                    {
                        ci_jugadorComboBox.SelectedItem = jugadorSeleccionado;
                    }
                    else
                    {
                        // Maneja el caso donde no se encuentra el jugador
                        MessageBox.Show("No se encontró el jugador asociado a la inscripción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Maneja el caso donde el Jugador_id es nulo en la inscripción
                    MessageBox.Show("La inscripción no tiene un jugador asociado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Si es un nuevo registro, selecciona el primer elemento por defecto
                ci_jugadorComboBox.SelectedIndex = 0;
            }

        }
    }
}
