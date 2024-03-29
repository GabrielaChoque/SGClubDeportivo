﻿using SGClubDeportivo.Controlador;
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
    public partial class frmCrudGuiaPrecios : frmVentanas
    {
        private GuiaPrecioController _GuiaPrecioController = new GuiaPrecioController();
        private bool esNuevo = true;
        private int ide;

        public frmCrudGuiaPrecios()
        {
            InitializeComponent();
        }
        public frmCrudGuiaPrecios(int ideSeleccionado)
        {
            esNuevo = false;
            ide = ideSeleccionado;
            InitializeComponent();
        }


        private void frmCrudGuiaPrecios_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                // Configuración para un nuevo registro
                GuiaPreciosBindingSource.AddNew();
                lblTituloCrud.Text = "REGISTRAR NUEVA GUIA PRECIO";
            }
            else
            {
                lblTituloCrud.Text = "MODIFICAR GUIA PRECIO";
                // Cargar datos del categoria existente para edición
                GuiaPreciosBindingSource.DataSource = _GuiaPrecioController.Seleccionar(ide);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                var reg = PonerDatosForm();

                if (esNuevo)
                {
                    // Agregar nuevo categoria
                    if (_GuiaPrecioController.Insertar(reg))
                    {
                        MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        Close();
                    }
                }
                else
                {
                    // Actualizar categoria existente
                    if (_GuiaPrecioController.Modificar(reg))
                    {
                        MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
                        Close();
                    }
                }
            }
            else{
                MessageBox.Show("INTRODUZCA LOS CAMPOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); this.DialogResult = DialogResult.OK; // Establecer resultado del formulario
            }
                
        }

        private GuiaPrecios PonerDatosForm()
        {
            var reg = (GuiaPrecios)GuiaPreciosBindingSource.Current;
            return reg;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool CamposValidos() //PARA REALIZAR VALIDACIONES
        {
            // Aquí debes realizar las validaciones necesarias, por ejemplo:
            if (string.IsNullOrWhiteSpace(conceptoTextBox.Text) || string.IsNullOrWhiteSpace(precioTextBox.Text))
            {
                return false;
            }

            // Puedes agregar más validaciones según los requisitos de tus campos

            return true;
        }

        private void conceptoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
