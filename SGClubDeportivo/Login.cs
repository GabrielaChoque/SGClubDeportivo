using SGClubDeportivo.Controlador;
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
            string tipoUsuario= _objSecretaria.Autenticar(txtUsuario.Text, txtContrasenia.Text);
            switch (tipoUsuario)
            {
                case "SECRETARIA":
                    this.Hide();
                    frmPrincipal frm = new Vista.frmPrincipal();
                    frm.ShowDialog();
                    break;
                case "ADMINISTRADOR":
                    this.Hide();
                    
                    break;
                case "":
                    MessageBox.Show("LA CUENTA O CONTRASEÑA SON INCORRECTOS", "NO SE PUDO INICIAR SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
