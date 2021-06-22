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
                var lst = from d in db.Jugador select d;
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
            /*  public void listaHorarios(string sel)
              {
                  BorrarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                  switch (sel)
                  {
                      case "SUB 7":
                          seleccionCategoria(1);
                          TituloCategoria.Text = "Categoria(SUB 7)";
                          dibujarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                        //  BorrarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                          break;
                      case "SUB 9":
                          seleccionCategoria(2);
                          TituloCategoria.Text = "Categoria(SUB 9)";
                          dibujarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                         // BorrarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                          break;
                      case "SUB 11":
                          seleccionCategoria(3);
                          TituloCategoria.Text = "Categoria(SUB 11)";
                          dibujarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                         // BorrarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                          break;
                      case "SUB 13":
                          seleccionCategoria(4);
                          TituloCategoria.Text = "Categoria(SUB 13)";
                          dibujarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                       //   BorrarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                          break;
                      case "SUB 15":
                          seleccionCategoria(5);
                          TituloCategoria.Text = "Categoria(SUB 15)";
                          dibujarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                         // BorrarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                          break;
                      case "SUB 17":
                          seleccionCategoria(6);
                          TituloCategoria.Text = "Categoria(SUB 17)";
                          dibujarHorarios(PanelHorario, colDia[0], rowHora[0], colDia[1], rowHora[1], colDia[2], rowHora[2], colDia[3], rowHora[3]);
                          break;
                  }
              }*/
            public void dibujarHorarios(TableLayoutPanel referencia, int x, int y, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Button dib = new Button();
            Button dib1 = new Button();
            Button dib2 = new Button();
            Button dib3 = new Button();
            setStyles(dib);
            setStyles(dib1);
            setStyles(dib2);
            setStyles(dib3);
            /*  dib.Text = "";
              dib.BackColor = Color.Goldenrod;
              dib.Dock = DockStyle.Fill;
               h1.Padding = new System.Windows.Forms.Padding(0);*/
            referencia.Controls.Add(dib, x, y);
            referencia.Controls.Add(dib1, x1, y1);
            referencia.Controls.Add(dib2, x2, y2);
            referencia.Controls.Add(dib3, x3, y3);
        }
        public void BorrarHorarios(TableLayoutPanel referencia, int x, int y, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Control control1 = referencia.GetControlFromPosition(x, y);
            Control control2 = referencia.GetControlFromPosition(x1, y1);
            Control control3 = referencia.GetControlFromPosition(x2, y2);
            Control control4 = referencia.GetControlFromPosition(x3, y3);
            referencia.Controls.Remove(control1);
            referencia.Controls.Remove(control2);
            referencia.Controls.Remove(control3);
            referencia.Controls.Remove(control4);

        }
        public void setStyles(Button nuevo)
        {
            nuevo.Text = "";
            nuevo.BackColor = Color.OrangeRed;
            nuevo.Dock = DockStyle.Fill;
        }
        public void seleccionCategoria(int valcCat)
        {
            int fil = 0, col = 0;
            _objHorario.Listardias(valcCat);
            _objHorario.ListarHoras(valcCat);
            foreach (var hora in _objHorario.horas)
            {
                rowHora[fil] = hora;
                fil++;
            }
            foreach (var dia in _objHorario.dias)
            {
                colDia[col] = dia;
                col++;
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

                DataGridViewButtonCell celBoton = this.dgvJugadores.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
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
    }
}
