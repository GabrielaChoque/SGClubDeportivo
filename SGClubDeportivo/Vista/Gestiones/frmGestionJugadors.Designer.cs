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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionJugadors));
            this.JugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JugadoresDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ci_jugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMensualidad = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.btnBuscar.Location = new System.Drawing.Point(478, 57);
            this.btnBuscar.Size = new System.Drawing.Size(310, 44);
            this.btnBuscar.Text = "IMPRIMIR LISTA DE JUGADORES";
            this.btnBuscar.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(131, 57);
            this.txtBuscar.Size = new System.Drawing.Size(341, 45);
            this.txtBuscar.OnTextChange += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 57);
            this.btnAgregar.Size = new System.Drawing.Size(113, 44);
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
            this.Ci_jugador,
            this.Tipo,
            this.Nombres,
            this.Apellidos,
            this.FechaNacimiento,
            this.Categoria_id,
            this.AddMensualidad,
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
            // Ci_jugador
            // 
            this.Ci_jugador.DataPropertyName = "Ci_jugador";
            this.Ci_jugador.HeaderText = "CARNET JUGADOR";
            this.Ci_jugador.Name = "Ci_jugador";
            this.Ci_jugador.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "TIPO JUGADOR";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "NOMBRES";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "APELLIDOS";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FECHA NACIMIENTO";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Categoria_id
            // 
            this.Categoria_id.DataPropertyName = "Categoria_id";
            this.Categoria_id.HeaderText = "CATEGORIA";
            this.Categoria_id.Name = "Categoria_id";
            this.Categoria_id.ReadOnly = true;
            // 
            // AddMensualidad
            // 
            this.AddMensualidad.HeaderText = "ADD MENSUALIDAD";
            this.AddMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("AddMensualidad.Image")));
            this.AddMensualidad.Name = "AddMensualidad";
            this.AddMensualidad.ReadOnly = true;
            this.AddMensualidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddMensualidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ci_jugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_id;
        private System.Windows.Forms.DataGridViewImageColumn AddMensualidad;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}