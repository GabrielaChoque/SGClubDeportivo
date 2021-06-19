using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGClubDeportivo.Data;
using SGClubDeportivo.Controlador;

namespace SGClubDeportivo.Vista.Gestiones
{
    public partial class Insertar : Form
    {
        private bool _esNuevo = true;
        JugadorController _objJugador = new JugadorController();
        public Insertar()
        {
            InitializeComponent();
        }

        private void jugadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdClubDeportivoDataSet);

        }

        private void Insertar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdClubDeportivoDataSet.Jugador' Puede moverla o quitarla según sea necesario.
            //this.jugadorTableAdapter.Fill(this.bdClubDeportivoDataSet.Jugador);
            jugadorBindingSource.AddNew();
        }
        private Jugador CargarDatos()
        {
            var reg = (Jugador)jugadorBindingSource.Current;
            return reg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var reg = CargarDatos();
                if (_esNuevo)
                {
                    if (_objJugador.Insertar(reg))
                    {
                        MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    { MessageBox.Show("YA EXISTE UN USUARIO CON CI: '" + "'", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
