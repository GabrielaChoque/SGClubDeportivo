using SGClubDeportivo.Controlador;
using SGClubDeportivo.Data;
using SGClubDeportivo.Vista;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SGClubDeportivo
{
    public partial class Login : Form
    {
        private readonly UsuarioController _user = new UsuarioController();

        public Login()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //string tipoUsuario = "";

            //string resultadoAutenticacion = _user.Autenticar(txtUsuario.Text, txtContrasenia.Text);

            //if (resultadoAutenticacion == "SECRETARIA")
            //{
            //    tipoUsuario = "SECRETARIA";
            //}
            //else if (resultadoAutenticacion == "ADMINISTRATIVO")
            //{
            //    tipoUsuario = "ADMIN";
            //}
            //else
            //{
            //    MessageBox.Show("LA CUENTA O CONTRASEÑA SON INCORRECTOS", "NO SE PUDO INICIAR SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return; // Salir del método si la autenticación no tiene éxito
            //}

            try
            {
                Usuarios usuarioseleccionado = _user.SeleccionarPorCI(txtUsuario.Text, txtContrasenia.Text);

                // ASIGNACION DE VARIABLES GLOBALES
                
                if (usuarioseleccionado == null)
                {
                    GlobalVariables.UsuarioActual = " ";
                    GlobalVariables.NomC = " ";
                    GlobalVariables.Rol = " ";
                    GlobalVariables.idUsuario = 0;
                    MessageBox.Show("LA CUENTA O CONTRASEÑA SON INCORRECTOS", "NO SE PUDO INICIAR SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    GlobalVariables.UsuarioActual = usuarioseleccionado.Username;
                    GlobalVariables.NomC = usuarioseleccionado.Nombres + " " + usuarioseleccionado.Apellidos;
                    GlobalVariables.Rol = usuarioseleccionado.Rol;
                    GlobalVariables.idUsuario = usuarioseleccionado.id;

                    if (usuarioseleccionado.Rol == "ADMINISTRATIVO")
                    {
                        this.Hide();
                        frmPrincipal frmAdmin = new Vista.frmPrincipal();
                        frmAdmin.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        frmPrincipalSecretario frm = new Vista.frmPrincipalSecretario();
                        frm.ShowDialog();
                    }
                } 

               
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error con información detallada sobre la excepción
                // Crear un formulario personalizado para mostrar el mensaje de error
                using (var errorForm = new Form())
                {
                    errorForm.Text = "Error";
                    errorForm.Size = new Size(400, 300); // Establecer el tamaño del formulario

                    // Crear un cuadro de texto para mostrar el mensaje de error
                    TextBox textBox = new TextBox();
                    textBox.Multiline = true;
                    textBox.ReadOnly = true;
                    textBox.ScrollBars = ScrollBars.Vertical;
                    textBox.Dock = DockStyle.Fill;
                    textBox.Text = $"Se produjo una excepción:\n{ex.Message}\n\nDetalles de la excepción:\n{ex.ToString()}";

                    // Agregar el cuadro de texto al formulario
                    errorForm.Controls.Add(textBox);

                    // Mostrar el formulario como un cuadro de diálogo modal
                    errorForm.ShowDialog();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
