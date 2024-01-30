using SGClubDeportivo.Controlador;
using SGClubDeportivo.Data;
using SGClubDeportivo.Vista;
using System;
using System.Windows.Forms;

namespace SGClubDeportivo
{
    public partial class Login : Form
    {
        private readonly AdministradorController _objAdministrador = new AdministradorController();
        private readonly SecretariaController _objSecretaria = new SecretariaController();
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
            catch (Exception)
            {
                MessageBox.Show("LA CUENTA O CONTRASEÑA SON INCORRECTOS", "NO SE PUDO INICIAR SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
