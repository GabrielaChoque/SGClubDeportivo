namespace SGClubDeportivo.Vista.Gestiones
{
    partial class frmGestionJugadors
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
            this.JugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JugadoresDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(267, 16);
            this.label2.Size = new System.Drawing.Size(276, 25);
            this.label2.Text = "GESTION DE JUGADORES";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // JugadoresBindingSource
            // 
            this.JugadoresBindingSource.DataSource = typeof(SGClubDeportivo.Data.Jugadores);
            // 
            // JugadoresDataGridView
            // 
            this.JugadoresDataGridView.AllowUserToAddRows = false;
            this.JugadoresDataGridView.AllowUserToDeleteRows = false;
            this.JugadoresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JugadoresDataGridView.AutoGenerateColumns = false;
            this.JugadoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JugadoresDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.JugadoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JugadoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Categoria_id,
            this.Editar,
            this.Eliminar});
            this.JugadoresDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JugadoresDataGridView.DataSource = this.JugadoresBindingSource;
            this.JugadoresDataGridView.Location = new System.Drawing.Point(12, 107);
            this.JugadoresDataGridView.Name = "JugadoresDataGridView";
            this.JugadoresDataGridView.ReadOnly = true;
            this.JugadoresDataGridView.RowHeadersVisible = false;
            this.JugadoresDataGridView.Size = new System.Drawing.Size(776, 331);
            this.JugadoresDataGridView.TabIndex = 61;
            this.JugadoresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JugadorsDataGridView_CellContentClick);
            this.JugadoresDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.JugadoresDataGridView_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ci_jugador";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ci_jugador";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Categoria_id
            // 
            this.Categoria_id.DataPropertyName = "Categoria_id";
            this.Categoria_id.HeaderText = "Categoria";
            this.Categoria_id.Name = "Categoria_id";
            this.Categoria_id.ReadOnly = true;
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
            // frmGestionJugadors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JugadoresDataGridView);
            this.Name = "frmGestionJugadors";
            this.Text = "frmGestionJugadors";
            this.Load += new System.EventHandler(this.frmGestionjugadores_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.JugadoresDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource JugadoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView JugadoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_id;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}