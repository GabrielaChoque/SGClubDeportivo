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

namespace SGClubDeportivo.Vista
{
    public partial class frmInicio : Form
    {
        AdministradorController _objAdministrador = new AdministradorController();
        SecretariaController _objSecretaria = new SecretariaController();

        public string _Cargo;
        public string _Carnet;
        public frmInicio(string carnet, string cargo)
        {
            InitializeComponent();
            //_Cargo = cargo;
            //_Carnet = carnet;
            //NombreLabel();
        }
        public void NombreLabel()
        {
            //if (_Cargo == "SECRETARIA")
            //    lblNombre.Text = _objSecretaria.nombreSecretaria(_Carnet);
            //if (_Cargo == "ADMIN")
            //    lblNombre.Text = _objAdministrador.nombreAdmin(_Carnet);

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

            lblRol.Text = GlobalVariables.Rol.ToString();
            lblNomC.Text = GlobalVariables.NomC.ToString();
        }
    }
}
