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
using SGClubDeportivo.Vista;

namespace SGClubDeportivo.Vista.Ventanas
{
    public partial class frmCrudJugadores : Form
    {
        JugadorController _objJugador = new JugadorController();
        CategoriaController _objCategoria = new CategoriaController();
        private string _carnet;
        private bool _esNuevo=true;
        private int _idCategoria;
        public frmCrudJugadores()
        {
            _esNuevo = true;
            InitializeComponent();
        }
        public frmCrudJugadores(string pCarnet, int pIdCategoria)
        {
            _esNuevo = false;
            _carnet = pCarnet;
            _idCategoria = pIdCategoria;
            InitializeComponent();
        }

        private void frmCrudJugadores_Load(object sender, EventArgs e)
        {

            if (_esNuevo)
            {
                jugadorBindingSource.AddNew();
                lblTituloCrud.Text = "REGISTRAR NUEVO";
                cmbCategoria.SelectedIndex = 0;
            }
            else
            {
                jugadorBindingSource.DataSource = _objJugador.BuscarPorPK(_carnet);
                //this.jugadorTableAdapter.Fill(this.bdClubDeportivoDataSet.Jugador);
                cmbCategoria.SelectedIndex = _idCategoria-1;
            }
        }

        

       /* private void jugadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdClubDeportivoDataSet);
        }*/

        private void btnAceptar_Click(object sender, EventArgs e)
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
                else
                {
                    if (_objJugador.Modificar(reg))
                    {
                        MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
        private Jugador CargarDatos()
        {
            int pIdCategoria = _objCategoria.ObtenerIdCategoria(cmbCategoria.Text);


            var reg = (Jugador)jugadorBindingSource.Current;

            reg.id_categoria = pIdCategoria;
            reg.ci_secretaria = "7392393";
            reg.fecha_registro = Convert.ToDateTime(DateTime.Now.ToString());
            return reg;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fecha_nacDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
