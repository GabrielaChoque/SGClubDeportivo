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
    public partial class frmCrudUsuarios : frmVentanas
    {
        //CRUD VIRGEN ORIGINAL
        private UsuarioController _UsuarioController = new UsuarioController();
        private bool esNuevo = true;
        private int ide;

        public frmCrudUsuarios()
        {
            InitializeComponent();
        }
        public frmCrudUsuarios(int ideSeleccionado)
        {
            esNuevo = false;
            ide = ideSeleccionado;
            InitializeComponent();
        }


        private void frmCrudUsuarios_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                // Configuración para un nuevo registro
                UsuariosBindingSource.AddNew();
                lblTituloCrud.Text = "REGISTRAR NUEVO USUARIO";
            }
            else
            {
                lblTituloCrud.Text = "MODIFICAR USUARIO";
                // Cargar datos del categoria existente para edición
                UsuariosBindingSource.DataSource = _UsuarioController.Seleccionar(ide);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CamposValidos()) //PUESTO PARA VAIDACIONES
            {
                var reg = PonerDatosForm();

                if (esNuevo)
                {
                    // Agregar nuevo categoria
                    if (_UsuarioController.Insertar(reg))
                    {
                        MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        Close();
                    }
                }
                else
                {
                    // Actualizar categoria existente
                    if (_UsuarioController.Modificar(reg))
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

        private Usuarios PonerDatosForm()
        {
            var reg = (Usuarios)UsuariosBindingSource.Current;
            return reg;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //HASTA ACA
        private bool CamposValidos() //PARA REALIZAR VALIDACIONES
        {
            // Aquí debes realizar las validaciones necesarias, por ejemplo:
            if (string.IsNullOrWhiteSpace(apellidosTextBox.Text) || string.IsNullOrWhiteSpace(nombresTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.IsNullOrWhiteSpace(rolComboBox.Text) || string.IsNullOrWhiteSpace(telefonoNumericUpDown.Text) || string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                return false;
            }

            // Puedes agregar más validaciones según los requisitos de tus campos

            return true;
        }
    }
}
