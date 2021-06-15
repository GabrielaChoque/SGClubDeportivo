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
using SGClubDeportivo.Data;

namespace SGClubDeportivo.Vista.Gestiones
{
    public partial class frmGestionJugadores : Form
    {
        JugadorController _objJugador = new JugadorController();
        CategoriaController _objCategoria = new CategoriaController();

        public bool _esNuevo =true;
        public frmGestionJugadores()
        {
            InitializeComponent();
        }

        private void linkLabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void Listar(string pBuscar, string pNomCategoria)
        {
           // jugadorBindingSource.DataSource = _objJugadores.ListarCategoría(pNomCategoria);
        }
        private void jugadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdClubDeportivoDataSet);
        }

        private void frmGestionJugadores_Load(object sender, EventArgs e)
        {
            jugadorBindingSource.DataSource = _objJugador.Listar("");

            
            cmbCategoria.SelectedIndex=0;
        }

        private void jugadorDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvJugadores.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvJugadores.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                System.Drawing.Icon icoEditar = new System.Drawing.Icon(Environment.CurrentDirectory + @"\\editar.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvJugadores.Rows[e.RowIndex].Height = icoEditar.Height + 8;
                this.dgvJugadores.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.dgvJugadores.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvJugadores.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                System.Drawing.Icon icoEliminar = new System.Drawing.Icon(Environment.CurrentDirectory + @"\\eliminar.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoEliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvJugadores.Rows[e.RowIndex].Height = icoEliminar.Height + 8;
                this.dgvJugadores.Columns[e.ColumnIndex].Width = icoEliminar.Width + 8;

                e.Handled = true;
            }
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            switch (cmbCategoria.Text)
            {
                case "SUB 7": 
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("",1);
                    lblTituloCategoria.Text = "CATEGORIA (SUB 7)";
                    break;
                case "SUB 9":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 2);
                    lblTituloCategoria.Text = "CATEGORIA (SUB 9)";
                    break;
                case "SUB 11":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 3);
                    lblTituloCategoria.Text = "CATEGORIA (SUB 11)";
                    break;
                case "SUB 13":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 4);
                    lblTituloCategoria.Text = "CATEGORIA (SUB 13)";
                    break;
                case "SUB 15":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 5);
                    lblTituloCategoria.Text = "CATEGORIA (SUB 15)";
                    break;
                case "SUB 17":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 6);
                    lblTituloCategoria.Text = "CATEGORIA (SUB 17)";
                    break;
                case "TODOS":
                    jugadorBindingSource.DataSource = _objJugador.Listar("");
                    lblTituloCategoria.Text = "CATEGORIA (TODOS)";
                    break;
            }
        }

        private void txtBuscarJugador_OnTextChange(object sender, EventArgs e)
        {
            jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 6);
        }

        private void btnNuevoJugador_Click(object sender, EventArgs e)
        {

        }
    }
}
