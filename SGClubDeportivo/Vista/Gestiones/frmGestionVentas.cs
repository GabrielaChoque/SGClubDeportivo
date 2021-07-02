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

namespace SGClubDeportivo.Vista.Gestiones
{
    public partial class frmGestionVentas : Form
    {
        JugadorController _objJugador = new JugadorController();
        MensualidadController _objMensualidad = new MensualidadController();
        public frmGestionVentas()
        {
            InitializeComponent();
            jugadorBindingSource.DataSource = _objJugador.Listar("123456789");
            mensualidadesBindingSource.DataSource = _objMensualidad.Listar("1234567890123");
        }
        private void ListarJugadores_TextChanged(object sender, EventArgs e)
        {
            jugadorBindingSource.DataSource = _objJugador.Listar(txtBuscarJ.Text);
        }

        private void btnSelecJugador_Click(object sender, EventArgs e)
        {
            panelJugadores.Visible = false;
            btnAceptar.Enabled = false;
            CargarInfoJugador();

        }

        private void CargarInfoJugador()
        {
            mensualidadesBindingSource.DataSource = _objMensualidad.Listar(ci_jugadorLabel1.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelJugadores.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var reg = (Jugador)jugadorBindingSource.Current;
            jugadorBindingSource.DataSource = _objJugador.BuscarPorPK(txtBuscarJugador.Text);

            
            if (ci_jugadorLabel1.Text != "")
            {
                btnAceptar.Enabled = false;
                CargarInfoJugador();
            }
            else
            {
                MessageBox.Show("NO EXISTE UN JUGADOR CON CI: " + txtBuscarJugador.Text + "!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                mensualidadesBindingSource.AddNew();
                var reg = CargarDatosMensualidades();

                MessageBox.Show(reg.ciJugador + reg.Estado + reg.Mes);
                if (_objMensualidad.Insertar(reg))
                {
                    MessageBox.Show("MENSUALIDAD REGISTRADA SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                
        }
        private Mensualidades CargarDatosMensualidades()
        {
            int indice = mesComboBox.SelectedIndex; //selecciona el numero de fila de entre los items del combobox
            var reg = (Mensualidades)mensualidadesBindingSource.Current;
            reg.Mes = mesComboBox.Items[indice].ToString(); //selecciona el dato del combobox correcto
            reg.Estado = "Pagado";
            reg.ciJugador = ci_jugadorLabel1.Text;
            return reg;
        }
    }
}
