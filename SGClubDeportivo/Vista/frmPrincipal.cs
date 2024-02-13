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
    public partial class frmPrincipal : Form
    {
        public string _Cargo;
        public string _Carnet;
        public frmPrincipal()
        {
            InitializeComponent();
            AbrirFormInPanel(new Vista.frmInicio(_Carnet, _Cargo));
        }
        public frmPrincipal(string carnet, string cargo)
        {
            InitializeComponent();
            _Cargo = cargo;
            _Carnet = carnet;
            AbrirFormInPanel(new Vista.frmInicio(_Carnet, _Cargo));
        }

        public void AbrirFormInPanel(object Formhijo)
        {
            this.PanelContenido.Controls.Clear();
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenido.Controls.Add(fh);
            this.PanelContenido.Tag = fh;
            fh.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionJugadors());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.frmInicio(_Carnet, _Cargo));
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionVentas());
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionHorario());
        }

        private void btnMensualidades_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionMensualidades());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionCategorias());
        }

        private void btnPagos_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionGuiaPrecios());
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionUsuarios());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void btnCambioPassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}
