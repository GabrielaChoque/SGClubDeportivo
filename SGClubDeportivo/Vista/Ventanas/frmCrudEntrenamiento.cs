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
    public partial class frmCrudEntrenamiento : Form
    {
        public frmCrudEntrenamiento()
        {
            InitializeComponent();
        }

        private void ci_jugadorLabel_Click(object sender, EventArgs e)
        {

        }

        private void frmCrudEntrenamiento_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            VerHorario verHorario = new VerHorario();
            verHorario.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
