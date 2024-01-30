using SGClubDeportivo.Controlador;
using SGClubDeportivo.Data;
using SGClubDeportivo.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubDeportivo
{
    public partial class Login : Form
    {
        AdministradorController _objAdministrador = new AdministradorController();
        SecretariaController _objSecretaria = new SecretariaController();
        UsuarioController _user = new UsuarioController();
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

            string tipoUsuario="";

            if (_user.Autenticar(txtUsuario.Text, txtContrasenia.Text) == "SECRETARIA")
                tipoUsuario = "SECRETARIA";
            if (_user.Autenticar(txtUsuario.Text, txtContrasenia.Text) == "ADMINISTRATIVO")
                tipoUsuario = "ADMIN";

            if (tipoUsuario == "NO LOG")
            {
                MessageBox.Show("LA CUENTA O CONTRASEÑA SON INCORRECTOS", "NO SE PUDO INICIAR SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Usuarios usuarioseleccionado = _user.SeleccionarPorCI(txtUsuario.Text, txtContrasenia.Text);
                if (tipoUsuario=="ADMIN")
                {
                    this.Hide();
                    frmPrincipal frmAdmin = new Vista.frmPrincipal(txtUsuario.Text, tipoUsuario);
                    frmAdmin.ShowDialog();
                    //ASIGNACION DE VARIABLES GLOBALES
                    GlobalVariables.UsuarioActual = usuarioseleccionado.Username;
                    GlobalVariables.NomC = usuarioseleccionado.Nombres + " " + usuarioseleccionado.Apellidos;
                    GlobalVariables.Rol = usuarioseleccionado.Rol;
                    GlobalVariables.idUsuario = usuarioseleccionado.id;
                }
                else {
                    this.Hide();
                    frmPrincipalSecretario frm = new Vista.frmPrincipalSecretario(txtUsuario.Text, tipoUsuario);
                    frm.ShowDialog();
                }
                
            }
                                
        }
    }
}
