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
        public frmCrudJugadores()
        {
            InitializeComponent();
        }

        private void frmCrudJugadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdClubDeportivoDataSet.Jugador' Puede moverla o quitarla según sea necesario.
            this.jugadorTableAdapter.Fill(this.bdClubDeportivoDataSet.Jugador);
            _objCategoria.CargarCategoria(cmbCategoriaCrud);
            cmbCategoriaCrud.SelectedIndex = 0;
        }

        private Jugador CargarDatos()
        {
            int pIdCategoria = _objCategoria.ObtenerIdCategoria(cmbCategoriaCrud.Text);
            var reg = (Jugador)jugadorBindingSource.Current;
            reg.id_categoria = pIdCategoria;
            return reg;
        }

        private void jugadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdClubDeportivoDataSet);

        }

        private void panelVentanaCrud_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
