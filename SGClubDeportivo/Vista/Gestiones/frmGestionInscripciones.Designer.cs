namespace SGClubDeportivo.Vista.Gestiones
{
    partial class frmGestionInscripciones
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
            this.InscripcionesDataGridView = new System.Windows.Forms.DataGridView();
            this.InscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guiaprecios_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.Text = "GESTION INSCRIPCIONES";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // InscripcionesDataGridView
            // 
            this.InscripcionesDataGridView.AllowUserToAddRows = false;
            this.InscripcionesDataGridView.AllowUserToDeleteRows = false;
            this.InscripcionesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InscripcionesDataGridView.AutoGenerateColumns = false;
            this.InscripcionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InscripcionesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InscripcionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InscripcionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Usuario_id,
            this.Jugador_id,
            this.Guiaprecios_id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.Editar,
            this.Eliminar});
            this.InscripcionesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InscripcionesDataGridView.DataSource = this.InscripcionesBindingSource;
            this.InscripcionesDataGridView.Location = new System.Drawing.Point(12, 109);
            this.InscripcionesDataGridView.Name = "InscripcionesDataGridView";
            this.InscripcionesDataGridView.ReadOnly = true;
            this.InscripcionesDataGridView.RowHeadersVisible = false;
            this.InscripcionesDataGridView.Size = new System.Drawing.Size(776, 329);
            this.InscripcionesDataGridView.TabIndex = 61;
            this.InscripcionesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InscripcionesDataGridView_CellContentClick);
            this.InscripcionesDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.InscripcionesDataGridView_CellFormatting);
            // 
            // InscripcionesBindingSource
            // 
            this.InscripcionesBindingSource.DataSource = typeof(SGClubDeportivo.Data.Inscripciones);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Usuario_id
            // 
            this.Usuario_id.DataPropertyName = "Usuario_id";
            this.Usuario_id.HeaderText = "Usuario_id";
            this.Usuario_id.Name = "Usuario_id";
            this.Usuario_id.ReadOnly = true;
            // 
            // Jugador_id
            // 
            this.Jugador_id.DataPropertyName = "Jugador_id";
            this.Jugador_id.HeaderText = "Jugador_id";
            this.Jugador_id.Name = "Jugador_id";
            this.Jugador_id.ReadOnly = true;
            // 
            // Guiaprecios_id
            // 
            this.Guiaprecios_id.DataPropertyName = "Guiaprecios_id";
            this.Guiaprecios_id.HeaderText = "Guiaprecios_id";
            this.Guiaprecios_id.Name = "Guiaprecios_id";
            this.Guiaprecios_id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Correlativo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Correlativo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Descuento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::SGClubDeportivo.Properties.Resources.editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::SGClubDeportivo.Properties.Resources.eliminar;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmGestionInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InscripcionesDataGridView);
            this.Name = "frmGestionInscripciones";
            this.Text = "frmGestionInscripciones";
            this.Load += new System.EventHandler(this.frmGestionInscripciones_Load);
            this.Controls.SetChildIndex(this.InscripcionesDataGridView, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource InscripcionesBindingSource;
        private System.Windows.Forms.DataGridView InscripcionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guiaprecios_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}