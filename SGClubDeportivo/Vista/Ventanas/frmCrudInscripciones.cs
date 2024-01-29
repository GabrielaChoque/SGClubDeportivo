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
    public partial class frmCrudInscripciones : frmVentanas
    {
        private InscripcionController _Inscripciones = new InscripcionController();
        private bool esNuevo = true;
        private int ide;
        private Inscripciones dataInscripcionesSeleccionado;

        public frmCrudInscripciones()
        {
            InitializeComponent();
        }
        public frmCrudInscripciones(int ideSeleccionado)
        {
            esNuevo = false;
            ide = ideSeleccionado;
            InitializeComponent();
        }


        private void frmCrudInscripciones_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                // Configuración para un nuevo registro
                InscripcionesBindingSource.AddNew();
                lblTituloCrud.Text = "REGISTRAR NUEVO";
            }
            else
            {
                lblTituloCrud.Text = "MODIFICAR ";
                // Cargar datos del categoria existente para edición
                dataInscripcionesSeleccionado = _Inscripciones.Seleccionar(ide); //EN CASO DE FK
                InscripcionesBindingSource.DataSource = dataInscripcionesSeleccionado;
            }
            CargarGuiaPrecios();
            CargarJugadores();
            CargarUsuarios();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var reg = PonerDatosForm();

            if (esNuevo)
            {
                // Agregar nuevo categoria
                if (_Inscripciones.Insertar(reg))
                {
                    MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                    Close();
                }
            }
            else
            {
                // Actualizar categoria existente
                if (_Inscripciones.Modificar(reg))
                {
                    MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                    this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                    Close();
                }
            }
        }

        private Inscripciones PonerDatosForm()
        {
            var reg = (Inscripciones)InscripcionesBindingSource.Current;
            Usuarios selectedUsuario = (Usuarios)nombresComboBox.SelectedItem; //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            Jugadores selectedJugador = (Jugadores)ci_jugadorComboBox.SelectedItem; //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            GuiaPrecios selectedGuiaPrecio = (GuiaPrecios)conceptoComboBox.SelectedItem; //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            reg.Usuario_id = selectedUsuario.id;  //OBTENIENDO LA id DEL FK
            reg.Jugador_id = selectedJugador.id;  //OBTENIENDO LA id DEL FK
            reg.Guiaprecios_id = selectedGuiaPrecio.id;  //OBTENIENDO LA id DEL FK
            return reg;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //----FK----//
        UsuarioController _user = new UsuarioController();
        JugadorController _jug = new JugadorController();
        GuiaPrecioController _gPrecio = new GuiaPrecioController();
        BdClubDeportivoEntities _entity = new BdClubDeportivoEntities();
        private void CargarUsuarios()
        {
            if (esNuevo)
            {
                nombresComboBox.DisplayMember = "Nombres";
                nombresComboBox.DataSource = _user.Listar("");
                nombresComboBox.SelectedIndex = 0;
            }
            else{
                MessageBox.Show("edit");
                nombresComboBox.DisplayMember = "Nombres";
                nombresComboBox.DataSource = _user.Listar("");
                nombresComboBox.SelectedItem = dataInscripcionesSeleccionado.Usuario_id;

                //nombreComboBox.SelectedItem = dataJugadoresSeleccionado.Categoria_id;
            }
                
        }
        private void CargarJugadores()
        {
            if (esNuevo)
            {
                ci_jugadorComboBox.DisplayMember = "Ci_jugador";
                ci_jugadorComboBox.DataSource = _jug.Listar("");
                ci_jugadorComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("edit2");
                ci_jugadorComboBox.DisplayMember = "Ci_jugador";
                ci_jugadorComboBox.DataSource = _jug.Listar("");
                ci_jugadorComboBox.SelectedItem = dataInscripcionesSeleccionado.Jugador_id;
            }
                

        }
        private void CargarGuiaPrecios()
        {
            if (esNuevo)
            {
                conceptoComboBox.DisplayMember = "Concepto";
                conceptoComboBox.DataSource = _gPrecio.Listar("");
                conceptoComboBox.SelectedIndex = 0;
            }
            else{
                MessageBox.Show("edit3");
                conceptoComboBox.DisplayMember = "Concepto";
                conceptoComboBox.DataSource = _gPrecio.Listar("");
                conceptoComboBox.SelectedItem = dataInscripcionesSeleccionado.Guiaprecios_id;
            }
                

        }
    }
}
