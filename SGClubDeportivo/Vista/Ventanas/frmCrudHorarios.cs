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
        JugadorController _objJugador = new JugadorController();
        CategoriaController _objCategoria = new CategoriaController();
        private string _carnet;
        private bool _esNuevo = true;
        private int _idCategoria;
        public frmCrudHorarios()
        {
            _esNuevo = true;
            InitializeComponent();
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

        }

        private void linkLabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmCrudHorarios_Load(object sender, EventArgs e)
        {
            List<EntrenamientoController> lst = new List<EntrenamientoController>();


            using (BdClubDeportivoEntities db = new BdClubDeportivoEntities())
            {
                lst = (from d in db.Entrenamiento
                       select new EntrenamientoController
                       {
                           id = d.id_entrenamiento
                       }).ToList();

            }
            cmbCategoria.DataSource = lst;
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "id";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{ 
            List<EntrenamientoController> lsci = new List<EntrenamientoController>();
            string idcat = cmbCategoria.SelectedValue.ToString();

            using (BdClubDeportivoEntities db = new BdClubDeportivoEntities())

            {
                    lsci = (from d in db.Entrenamiento
                            where d.id_entrenamiento == idcat
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

                }
            }catch (InvalidCastException ex)
            {

            }
        }

        private void PrimerDia_Click(object sender, EventArgs e)
        {

        }
    }
}
