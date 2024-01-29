using Bunifu.Framework.Lib;
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
    public partial class frmCrudJugadores : frmVentanas
    {
        private JugadorController _JugadoreController = new JugadorController();
        private bool esNuevo = true;
        private int ide;
        private Jugadores dataJugadoresSeleccionado; //ES CASO DE TENER FK SELECCIOAMOS

        public frmCrudJugadores()
        {
            InitializeComponent();
        }
        public frmCrudJugadores(int ideSeleccionado)
        {
            esNuevo = false;
            ide = ideSeleccionado;
            InitializeComponent();
        }


        private void frmCrudjugador_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                // Configuración para un nuevo registro
                JugadoresBindingSource.AddNew();
                lblTituloCrud.Text = "REGISTRAR NUEVO";
            }
            else
            {
                lblTituloCrud.Text = "MODIFICAR ";
                // Cargar datos del categoria existente para edición
                dataJugadoresSeleccionado = _JugadoreController.Seleccionar(ide); //ES CASO DE TENER FK SELECCIOAMOS
                JugadoresBindingSource.DataSource = dataJugadoresSeleccionado;
            }
            CargarCategorias(); //en el comboBox
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var reg = PonerDatosForm();

            if (esNuevo)
            {
                // Agregar nuevo categoria
                if (_JugadoreController.Insertar(reg))
                {
                    MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                    Close();
                }
            }
            else
            {
                // Actualizar categoria existente
                if (_JugadoreController.Modificar(reg))
                {
                    MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                    this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                    Close();
                }
            }
        }

        private Jugadores PonerDatosForm()
        {
            var reg = (Jugadores)JugadoresBindingSource.Current;
            // EN CASO DE TENER FK
            //int codId = nombreComboBox.SelectedIndex;
            Categorias selectedCategoria = (Categorias)nombreComboBox.SelectedItem; //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            reg.Categoria_id = selectedCategoria.id;  //OBTENIENDO LA id DEL FK

            return reg;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //----PARA EL FK y SE JALA NOMAS DESDE EL ORIGEN DE DATOS EN FORMATO COMBOBOX DEBE ESTAR EN MODO Origen de DAtos y Mstrar Miembro, lo demas vacio-----//
        CategoriaController _cat = new CategoriaController();
        BdClubDeportivoEntities _entity = new BdClubDeportivoEntities();
        private void CargarCategorias()
        {
            if (esNuevo)
            {
                //opcion 1
                nombreComboBox.DisplayMember = "Nombre";
                nombreComboBox.DataSource = _cat.Listar("");
                nombreComboBox.SelectedIndex = 0;
                //opcion 2
                //var r = from ru in _entity.Categorias
                //        select new { ru.Nombre };
                //nombreComboBox.DisplayMember = "Nombre";
                //nombreComboBox.DataSource = r.ToList();
                //nombreComboBox.SelectedIndex = 0;
            }
            else
            {
                nombreComboBox.DisplayMember = "Nombre";
                nombreComboBox.DataSource = _cat.Listar("");
                nombreComboBox.SelectedItem = dataJugadoresSeleccionado.Categoria_id;
            }

        }
    }
}
