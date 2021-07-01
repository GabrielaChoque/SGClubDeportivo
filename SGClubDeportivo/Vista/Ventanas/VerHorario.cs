using SGClubDeportivo.Controlador;
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
    public partial class VerHorario : Form
    {
        CategoriaController _objCategoria = new CategoriaController();
        HorarioController _objHorario = new HorarioController();
        public int[] rowHora = new int[50];
        public int[] colDia = new int[50];
        public int ActMover, x, y;
        public VerHorario()
        {
            InitializeComponent();
        }
        public void listaHorarios(string sel)
        {
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
        }
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ActMover = 1;
            x = e.X;
            y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ActMover == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            ActMover = 0;
        }

        private void linkLabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            listaHorarios(selHorario.Text);
        }
    }
}
