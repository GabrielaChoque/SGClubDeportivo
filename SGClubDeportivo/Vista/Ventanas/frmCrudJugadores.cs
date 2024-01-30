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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                lblTituloCrud.Text = "REGISTRAR NUEVO JUGADOR";
            }
            else
            {
                lblTituloCrud.Text = "MODIFICAR JUGADOR";
                // Cargar datos del categoria existente para edición
                dataJugadoresSeleccionado = _JugadoreController.Seleccionar(ide); //ES CASO DE TENER FK SELECCIOAMOS
                JugadoresBindingSource.DataSource = dataJugadoresSeleccionado;
            }
            CargarCategorias(); //en el comboBox
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
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
            else
            {
                MessageBox.Show("INTRODUZCA LOS CAMPOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
            }
                
        }

        private Jugadores PonerDatosForm()
        {
           
            var reg = (Jugadores)JugadoresBindingSource.Current;
            //categoria_idComboBox.DataSource = admins.Select(a => new { a.Id, NombreCompleto = $"{a.Ap_Paterno} {a.Ap_Materno} {a.Nombre}" }).ToList();


            // EN CASO DE TENER FK
            //int codId = categoria_idComboBox.SelectedIndex;

            //Categorias selectedCategoria = (Categorias)categoria_idComboBox.SelectedItem; //SELECCIONANDO LA FILA SELECCIONADA DEL FORMULARIO del FK
            //reg.Categoria_id = selectedCategoria.id;  //OBTENIENDO LA id DEL FK
            object valorSeleccionado = categoria_idComboBox.SelectedValue;
            if (valorSeleccionado != null)
            {
                int idSeleccionado = Convert.ToInt32(valorSeleccionado);
                reg.Categoria_id = idSeleccionado;  //OBTENIENDO LA id DEL FK
            }

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
                categoria_idComboBox.DisplayMember = "Nombre";
                categoria_idComboBox.ValueMember = "id";
                categoria_idComboBox.DataSource = _cat.Listar("");
                //categoria_idComboBox.SelectedIndex = 0;
                //opcion 2
                //var r = from ru in _entity.Categorias
                //        select new { ru.Nombre };
                //categoria_idComboBox.DisplayMember = "Nombre";
                //categoria_idComboBox.DataSource = r.ToList();
                //categoria_idComboBox.SelectedIndex = 0;
            }
            else
            {
                try
                {
                    categoria_idComboBox.DisplayMember = "Nombre";
                    categoria_idComboBox.ValueMember = "id";
                    categoria_idComboBox.DataSource = _cat.Listar("");
                    //conceptoComboBox.SelectedItem = dataMensualidadesSeleccionado.Guiaprecios_id;
                    if (dataJugadoresSeleccionado != null)
                    {
                        //ESTO AHCE Q SE SELECCIONE CORRECTAMENTE EL VALOR EN EL comboboxGuiaPrecios
                        Categorias catSeleccionado = _cat.Seleccionar(dataJugadoresSeleccionado.Categoria_id ?? 0); //si saca null entonces poner 0
                        categoria_idComboBox.SelectedItem = catSeleccionado;
                    }
                    else
                    {
                        // Manejo de la situación cuando dataMensualidadesSeleccionado es null
                        categoria_idComboBox.SelectedItem = 0;  // O cualquier otro valor predeterminado que desees
                    }


                }
                catch (Exception ex)
                {
                    //USADO CUANDO ESTE FORM SE ABRE DESDE UN FORM EXTERNO QUE NO CORRESPONDA

                    categoria_idComboBox.DisplayMember = "Nombre";
                    categoria_idComboBox.ValueMember = "id";
                    categoria_idComboBox.DataSource = _cat.Listar("");
                    categoria_idComboBox.SelectedIndex = 0;
                }
            }

        }
        private void categoria_idComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            //USADO SI QUIEREMOS MOSTRAR MAS ATRIBUTOS EN UN COMBOBOX
            if (e.DesiredType == typeof(string))
            {
                Categorias a = e.ListItem as Categorias;

                if (a != null)
                {
                    // Personaliza cómo se mostrará cada elemento en el ComboBox
                    e.Value = $"{a.id} - {a.Nombre}";
                }
            }
        }
        private bool CamposValidos() //PARA REALIZAR VALIDACIONES
        {
            // Aquí debes realizar las validaciones necesarias, por ejemplo:
            if (string.IsNullOrWhiteSpace(apellidosTextBox.Text) || string.IsNullOrWhiteSpace(nombresTextBox.Text) || string.IsNullOrWhiteSpace(ci_jugadorTextBox.Text) || string.IsNullOrWhiteSpace(tipoComboBox.Text) || string.IsNullOrWhiteSpace(fechaNacimientoDateTimePicker.Text) || string.IsNullOrWhiteSpace(categoria_idComboBox.Text))
            {
                return false;
            }

            // Puedes agregar más validaciones según los requisitos de tus campos

            return true;
        }
    }
}
