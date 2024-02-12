namespace SGClubDeportivo.Vista.Gestiones
{
    partial class frmGestionMensualidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MensualidadesDataGridView = new System.Windows.Forms.DataGridView();
            this.MensualidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guiaprecios_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guiaprecios_id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintBoleta = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MensualidadesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensualidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.Text = "GESTION MENSUALIDADES";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(521, 57);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 57);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(12, 405);
            this.btnAgregar.Size = new System.Drawing.Size(19, 33);
            this.btnAgregar.Text = "";
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // MensualidadesDataGridView
            // 
            this.MensualidadesDataGridView.AllowUserToAddRows = false;
            this.MensualidadesDataGridView.AllowUserToDeleteRows = false;
            this.MensualidadesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MensualidadesDataGridView.AutoGenerateColumns = false;
            this.MensualidadesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MensualidadesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MensualidadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MensualidadesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Gestion,
            this.Guiaprecios_id,
            this.Jugador_id,
            this.Guiaprecios_id1,
            this.Mes,
            this.CuotaFinal,
            this.FechPago,
            this.Concepto,
            this.PrintBoleta,
            this.Editar,
            this.Eliminar,
            this.Usuario_id});
            this.MensualidadesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MensualidadesDataGridView.DataSource = this.MensualidadesBindingSource;
            this.MensualidadesDataGridView.Location = new System.Drawing.Point(12, 95);
            this.MensualidadesDataGridView.Name = "MensualidadesDataGridView";
            this.MensualidadesDataGridView.ReadOnly = true;
            this.MensualidadesDataGridView.RowHeadersVisible = false;
            this.MensualidadesDataGridView.Size = new System.Drawing.Size(776, 343);
            this.MensualidadesDataGridView.TabIndex = 61;
            this.MensualidadesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MensualidadesDataGridView_CellContentClick);
            this.MensualidadesDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MensualidadesDataGridView_CellFormatting);
            // 
            // MensualidadesBindingSource
            // 
            this.MensualidadesBindingSource.DataSource = typeof(SGClubDeportivo.Data.Mensualidades);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(641, 57);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(207, 32);
            this.btnImprimir.TabIndex = 62;
            this.btnImprimir.Text = "IMPRIMIR REPORTE";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Gestion
            // 
            this.Gestion.DataPropertyName = "Gestion";
            this.Gestion.HeaderText = "AÑO";
            this.Gestion.Name = "Gestion";
            this.Gestion.ReadOnly = true;
            // 
            // Guiaprecios_id
            // 
            this.Guiaprecios_id.DataPropertyName = "Guiaprecios_id";
            this.Guiaprecios_id.HeaderText = "TIPO JUGADOR";
            this.Guiaprecios_id.Name = "Guiaprecios_id";
            this.Guiaprecios_id.ReadOnly = true;
            // 
            // Jugador_id
            // 
            this.Jugador_id.DataPropertyName = "Jugador_id";
            this.Jugador_id.HeaderText = "CI JUGADOR";
            this.Jugador_id.Name = "Jugador_id";
            this.Jugador_id.ReadOnly = true;
            // 
            // Guiaprecios_id1
            // 
            this.Guiaprecios_id1.DataPropertyName = "Guiaprecios_id";
            this.Guiaprecios_id1.HeaderText = "GPrecioMonto";
            this.Guiaprecios_id1.Name = "Guiaprecios_id1";
            this.Guiaprecios_id1.ReadOnly = true;
            this.Guiaprecios_id1.Visible = false;
            // 
            // Mes
            // 
            this.Mes.DataPropertyName = "Mes";
            this.Mes.HeaderText = "MES";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            // 
            // CuotaFinal
            // 
            this.CuotaFinal.DataPropertyName = "CuotaFinal";
            this.CuotaFinal.HeaderText = "MONTO";
            this.CuotaFinal.Name = "CuotaFinal";
            this.CuotaFinal.ReadOnly = true;
            // 
            // FechPago
            // 
            this.FechPago.DataPropertyName = "FechPago";
            this.FechPago.HeaderText = "FECHA PAGO";
            this.FechPago.Name = "FechPago";
            this.FechPago.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "CONCEPTO";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // PrintBoleta
            // 
            this.PrintBoleta.HeaderText = "IMPRIMIR BOLETA";
            this.PrintBoleta.Image = global::SGClubDeportivo.Properties.Resources.calendario;
            this.PrintBoleta.Name = "PrintBoleta";
            this.PrintBoleta.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "EDITAR";
            this.Editar.Image = global::SGClubDeportivo.Properties.Resources.editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "ELIMINAR";
            this.Eliminar.Image = global::SGClubDeportivo.Properties.Resources.eliminar;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Usuario_id
            // 
            this.Usuario_id.DataPropertyName = "Usuario_id";
            this.Usuario_id.HeaderText = "USUARIO";
            this.Usuario_id.Name = "Usuario_id";
            this.Usuario_id.ReadOnly = true;
            // 
            // frmGestionMensualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.MensualidadesDataGridView);
            this.Name = "frmGestionMensualidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionMensualidades";
            this.Load += new System.EventHandler(this.frmGestionMensualidades_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.MensualidadesDataGridView, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MensualidadesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensualidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource MensualidadesBindingSource;
        private System.Windows.Forms.DataGridView MensualidadesDataGridView;
        public FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscripcion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotaRegular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guiaprecios_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guiaprecios_id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewImageColumn PrintBoleta;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_id;
    }
}