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

namespace SGClubDeportivo.Vista.Ventanas
{
    public partial class frmCrudHorarios : Form
    {
        BdClubDeportivoEntities db = new BdClubDeportivoEntities();
        CategoriaController _objCategoria = new CategoriaController();
        EntrenamientoController objEntrenamiento = new EntrenamientoController();
        List<EntrenamientoController> lst = new List<EntrenamientoController>();
        List<EntrenamientoController> lsci = new List<EntrenamientoController>();
        Entrenamiento editEnt = null;
        string a, b, c, d;
        private string _carnet;
        private bool _esNuevo = true;
        private int _idCategoria;
        public int ActMover, x, y;
        public string ci_Jugador;
        public frmCrudHorarios()
        {
            _esNuevo = true;
            InitializeComponent();
            cmbCarnet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDia1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDia2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHora1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHora2.DropDownStyle = ComboBoxStyle.DropDownList;
            //  cargarEntrenamiento();
        }
        public frmCrudHorarios(string pCarnet, int pIdCategoria)
        {
            _esNuevo = false;
            _carnet = pCarnet;
            _idCategoria = pIdCategoria;
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //cargarDatos();
            
            try
            {
                     ci_Jugador = ObtenerCiJugador(cmbCarnet.SelectedValue.ToString());
                     a = cmbDia1.Text;
                     b = cmbDia2.Text;
                     c = cmbHora1.Text;
                     d = cmbHora2.Text;

                var reg= (from b in db.Entrenamiento
                                    where b.ci_jugador == ci_Jugador
                                    select b).FirstOrDefault();

                if (reg != null)
                {
                    reg.primerdia = a;
                    reg.segundodia = b;
                    reg.primerhorario = c;
                    reg.segundohorario = d;
                    db.SaveChanges();

                    MessageBox.Show("Horario de Entrenamiento Actualizado", "Success!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                /*  
                   editEnt = db.Entrenamiento.Find(ci_Jugador);
                   editEnt.primerdia = "Martes";
                   editEnt.segundodia = "Jueves";
                   editEnt.primerhorario = "9";
                   editEnt.segundohorario = "11";
                  /* if (editEnt!=null)
               { 
                     objEntrenamiento.ModificarEntrenamiento(editEnt);
                    //diaLabel.Text = editEnt.primerdia;
                    MessageBox.Show("Horario de Entrenamiento Actualizado","Success!!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
               }*/
 
              else
              {
                  MessageBox.Show("Revise los datos sean correctos", "ERROR!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            }
            catch (Exception)
            {
                MessageBox.Show("Revise los datos sean correctos", "ERROR!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        private string getCi()
        {
            try
            {
               var ci = cmbCarnet.SelectedValue.ToString();
                return ci;
            }
            catch
            {
                return null;
            }
        }
/*        private Entrenamiento CargarDatos()
        {
            int pIdCategoria = _objCategoria.ObtenerIdCategoria(cmbCategoria.Text);


        //    var reg = (Entrenamiento)jugadorBind.Current;

            reg.id_categoria = pIdCategoria;
            reg.ci_secretaria = "7392393";
            reg.fecha_registro = Convert.ToDateTime(DateTime.Now.ToString());
            return reg;
        }*/
        public Entrenamiento entrenamientoSelect(string ciJugador)
        {
            
                var datos = (from sel in db.Entrenamiento
                             where sel.ci_jugador == ciJugador
                             select sel).FirstOrDefault();
                return datos;
           
        }
        public void cargarDatos()
        {

            if (ci_Jugador!=null)
            {
            using (BdClubDeportivoEntities context = new BdClubDeportivoEntities())
            {

                ci_Jugador = ObtenerCiJugador(cmbCarnet.SelectedValue.ToString());
                editEnt = context.Entrenamiento.Find(ci_Jugador);
                label1.Text = editEnt.ci_jugador;
                diaLabel.Text = editEnt.primerdia;
            }
            }
            else
            {

            }
        }
        public void editarHorario(string ci, string pdia, string sdia, string phora, string shora)
        {
         
                Entrenamiento entrenamiento = this.entrenamientoSelect(ci);
                entrenamiento.primerdia = pdia;
                entrenamiento.segundodia = sdia;
                entrenamiento.primerhorario = phora;
                entrenamiento.segundohorario = shora;
                db.SaveChanges();
            
        }

        private void linkLabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmCrudHorarios_Load(object sender, EventArgs e)
        { 
                lst = (from d in db.Entrenamiento
                       select new EntrenamientoController
                       {
                           idcategoria = d.id_categoria
                       }).ToList();
            cmbCategoria.DataSource = lst;
            cmbCategoria.ValueMember = "idcategoria";
            cmbCategoria.DisplayMember = "idcategoria";
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public bool EsVacio(string componente)
        {
            if (componente == "" || componente == null)
                return true;
            else
                return false;

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
               

                int idcat = (int)cmbCategoria.SelectedValue;

                    lsci = (from d in db.Entrenamiento
                            where d.id_categoria == idcat
                            select new EntrenamientoController
                            {
                                ci = d.ci_jugador,
                                primerdia = d.primerdia,
                                segundodia = d.segundodia,
                                primerhorario = d.primerhorario,
                                segundohorario = d.segundohorario
                            }).ToList();

                    cmbCarnet.DataSource = lsci;
                    cmbCarnet.ValueMember = "ci";
                    cmbCarnet.DisplayMember = "ci";
                    ci_Jugador = lsci.ElementAt(0).ci;
                 a=cmbDia1.Text = lsci.ElementAt(0).primerdia;
                    b=cmbDia2.Text= lsci.ElementAt(0).segundodia;
                    c=cmbHora1.Text = lsci.ElementAt(0).primerhorario;
                   d=cmbHora2.Text = lsci.ElementAt(0).segundohorario;
                    label1.Text = ci_Jugador;
   
                //diaLabel.Text = lsci.ElementAt(0).primerdia;

                //  diaLabel.Text = cmbCarnet.SelectedValue.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
          /*  Label lunes = new Label();
            lunes.Text = "LUNES";
            lunes.BackColor = Color.Gold;
            lunes.Dock = DockStyle.Fill;
            lunes.ForeColor = Color.White;
            lunes.TextAlign = ContentAlignment.MiddleCenter;
            PanelEditHorario.Controls.Add(lunes,1,0);*/
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ActMover = 1;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ActMover == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            VerHorario verHorario = new VerHorario();
            verHorario.Show();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ActMover = 1;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (ActMover == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            ActMover = 0;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ActMover = 0;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            VerHorario verHorario = new VerHorario();
            verHorario.Show();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public string ObtenerCiJugador(string ci)
        {

            var lista = db.Entrenamiento.Where(x => x.ci_jugador == ci).FirstOrDefault();
            return lista.ci_jugador;

        }
        public string ObtenerPrimerDia(string ci)
        {

            var lista = db.Entrenamiento.Where(x => x.ci_jugador == ci).FirstOrDefault();
            return lista.primerdia;
        }
        public string ObtenerSegundoDia(string ci)
        {

            var lista = db.Entrenamiento.Where(x => x.ci_jugador == ci).FirstOrDefault();
            return lista.segundodia;
        }
        public string ObtenerPrimerHorario(string ci)
        {

            var lista = db.Entrenamiento.Where(x => x.ci_jugador == ci).FirstOrDefault();
            return lista.primerhorario;
        }
        public string ObtenerSegundoHorario(string ci)
        {

            var lista = db.Entrenamiento.Where(x => x.ci_jugador == ci).FirstOrDefault();
            return lista.segundohorario;
        }
    }
}
