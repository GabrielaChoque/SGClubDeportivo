using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Ocsp;
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

namespace SGClubDeportivo.Vista
{
    public partial class frmChangePassword : frmVentanas
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        UsuarioController _user=new UsuarioController();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuarios usuarioseleccionado = _user.SeleccionarPorCI(GlobalVariables.UsuarioActual, txtContraseniaActual.Text);
            if (usuarioseleccionado == null)
            {
                //CONTRASEÑA FALLIDA
                MessageBox.Show("LA CONTRASEÑA ACTUAL ES INCORRECTA", "DATOS INCORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContraseniaActual.Text = " ";
            }
            else
            {
                //SI PUSO LA CONTRASEÑA ACTUAL CORRECTAMENTE... PROSEGUIR A PONER NUEVA CONTRASEÑA
                if (txtNewContrasenia.Text == txtConfirmarNewContrasenia.Text) //VERIFICAR QUE SEAN IGUALES
                {
                    //SI SON IGUALES PROCEDER A CAMBIAR LA CONTRASEÑA
                    //Usuarios reg = _user.Seleccionar(GlobalVariables.idUsuario);
                    usuarioseleccionado.Password = txtConfirmarNewContrasenia.Text;

                    if (_user.Modificar(usuarioseleccionado))
                    {
                        //SE MODIFICO CORRECTAMENTE LA CONTRASEÑA
                        MessageBox.Show("SE MODIFICO LA CONTRASEÑA EXITOSAMENTE", "CAMBIO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("TODOS LOS CAMPOS SON CORRECTOS; PERO NO SE PUDO CAMBIAR LA CONTRASEÑA", "DATOS CORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //LAS NUEVAS CONTRASEÑAS NO COINCIDEN
                    MessageBox.Show("LOS CAMPOS DE NUEVA CONTRASEÑA NO COINCIDEN", "DATOS INCORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewContrasenia.Text = " ";
                    txtConfirmarNewContrasenia.Text = " ";
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
