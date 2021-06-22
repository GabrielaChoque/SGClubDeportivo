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
                           idcategoria = d.id_categoria
                       }).ToList();

            }
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
            try{ 
            List<EntrenamientoController> lsci = new List<EntrenamientoController>();
            List<HorarioController> listHour = new List<HorarioController>();

            int idcat = (int)cmbCategoria.SelectedValue;

            using (BdClubDeportivoEntities db = new BdClubDeportivoEntities())

            {
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
                    listHour= (from h in db.Horario
                        where h.id_categoria == idcat
                        select new HorarioController 
                        { 
                            dia=h.dia,
                            hora=h.hora
                        }).ToList();
                    cmbCarnet.DataSource = lsci;
                    comboDia1.DataSource = listHour;
                    comboDia2.DataSource = listHour;
                    cmbHora.DataSource = listHour;
                    cmbHora2.DataSource = listHour;
                    cmbCarnet.ValueMember = "ci";
                    cmbCarnet.DisplayMember = "ci";
                    comboDia1.ValueMember = "dia";
                    comboDia1.DisplayMember = "dia";
                    comboDia2.ValueMember = "dia";
                    comboDia2.DisplayMember = "dia";
                    cmbHora.ValueMember = "hora";
                    cmbHora.DisplayMember = "hora";
                    cmbHora2.ValueMember = "hora";
                    cmbHora2.DisplayMember = "hora";

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
