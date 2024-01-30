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
    public partial class frmCrudCategorias : frmVentanas
    {
        
        private CategoriaController categoriaController = new CategoriaController();
        private bool esNuevo = true;
        private int ide;

        public frmCrudCategorias()
        {
            InitializeComponent();
        }

        public frmCrudCategorias(int ideSeleccionado)
        {
            esNuevo = false;
            ide = ideSeleccionado;
            InitializeComponent();
        }

        private void frmCrudcategorias_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                // Configuración para un nuevo registro
                categoriasBindingSource.AddNew();
                lblTituloCrud.Text = "REGISTRAR NUEVA CATEGORIA";
                // Puedes inicializar otros controles según tu diseño
            }
            else
            {
                lblTituloCrud.Text = "MODIFICAR CATEGORIA";
                // Cargar datos del categoria existente para edición
                categoriasBindingSource.DataSource = categoriaController.Seleccionar(ide);
                // Puedes asignar valores a otros controles según tu diseño
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                var reg = CargarDatos();

                if (esNuevo)
                {
                    // Agregar nuevo categoria
                    if (categoriaController.AgregarCategoria(reg))
                    {
                        MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        Close();
                    }
                }
                else
                {
                    // Actualizar categoria existente
                    if (categoriaController.ActualizarCategoria(reg))
                    {
                        MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("INTRODUZCA LOS CAMPOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
            }
                
        }

        private Categorias CargarDatos()
        {
            // Aquí debes asignar los valores desde los controles del formulario a un objeto categoria
            var reg = (Categorias)categoriasBindingSource.Current;
            return reg;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool CamposValidos() //PARA REALIZAR VALIDACIONES
        {
            // Aquí debes realizar las validaciones necesarias, por ejemplo:
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                return false;
            }

            // Puedes agregar más validaciones según los requisitos de tus campos

            return true;
        }
    }
}
