using SGClubDeportivo.Controlador;
using SGClubDeportivo.Data;
using SGClubDeportivo.Vista.Ventanas;
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
    public partial class frmGestionHorario : Form
    {
        JugadorController _objJugador = new JugadorController();
        CategoriaController _objCategoria = new CategoriaController();
        HorarioController _objHorario = new HorarioController();
        public int[] rowHora = new int[50];
        public int[] colDia = new int[50];
        public frmGestionHorario()
        {
            InitializeComponent();
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            ListarPorCategoria(selHorario.Text);
        }
       public void refrescar()
        {
            using (BdClubDeportivoEntities db = new BdClubDeportivoEntities()) {
                var lst = from d in db.Jugadores select d;
                //dataListJugador.DataSource = lst.ToList();
            }
        }
        private void ListarPorCategoria(string pNomCategoria)
        {
            switch (pNomCategoria)
            {
                case "SUB 7":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 1);
                    TituloCategoria.Text = "CATEGORIA (SUB 7)";
                    break;
                case "SUB 9":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 2);
                    TituloCategoria.Text = "CATEGORIA (SUB 9)";
                    break;
                case "SUB 11":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 3);
                    TituloCategoria.Text = "CATEGORIA (SUB 11)";
                    break;
                case "SUB 13":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 4);
                    TituloCategoria.Text = "CATEGORIA (SUB 13)";
                    break;
                case "SUB 15":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 5);
                    TituloCategoria.Text = "CATEGORIA (SUB 15)";
                    break;
                case "SUB 17":
                    jugadorBindingSource.DataSource = _objJugador.ListarPorCategoria("", 6);
                    TituloCategoria.Text = "CATEGORIA (SUB 17)";
                    break;
                case "TODOS":
                    jugadorBindingSource.DataSource = _objJugador.Listar("");
                    TituloCategoria.Text = "CATEGORIA (TODOS)";
                    break;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESTA SEGURO SALIR OPERACION?","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            this.Close();       
        }

        private void PanelHorario_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
           // BorrarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
        }

        private void dgvJugadores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvJugadores.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

//DataGridViewButtonCell celBoton = this.dgvJugadores.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                System.Drawing.Icon icoEditar = new System.Drawing.Icon(Environment.CurrentDirectory + @"\\editar.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvJugadores.Rows[e.RowIndex].Height = icoEditar.Height + 8;
                this.dgvJugadores.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmCrudHorarios frhora = new frmCrudHorarios();
            frhora.Show();
        }

        private void selHorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

            frmCrudHorarios crudHorarios = new frmCrudHorarios();
            crudHorarios.Show();
            //VerHorario verHorario = new VerHorario();
            //verHorario.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //frmCrudEntrenamiento frmCrud = new frmCrudEntrenamiento();
            //frmCrud.Show();
        }

        private void dgvJugadores_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}
