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
        public frmPrincipal(string carnet, string cargo)
        {
            InitializeComponent();
            _Cargo = cargo;
            _Carnet = carnet;
            AbrirFormInPanel(new Vista.frmInicio(_Carnet, _Cargo));
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenido.Controls.Count > 0)
                this.PanelContenido.Controls.RemoveAt(0);
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
            AbrirFormInPanel(new Vista.Gestiones.frmGestionJugadores());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.frmInicio(_Carnet, _Cargo));
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionHorario());
        }
    }
}
