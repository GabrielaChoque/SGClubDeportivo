namespace SGClubDeportivo.Vista.Gestiones
{
    partial class frmGestionGuiaPrecios
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
            this.GuiaPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuiaPreciosDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GuiaPreciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuiaPreciosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(268, 16);
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.Text = "GESTION PRECIOS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // GuiaPreciosBindingSource
            // 
            this.GuiaPreciosBindingSource.DataSource = typeof(SGClubDeportivo.Data.GuiaPrecios);
            // 
            // GuiaPreciosDataGridView
            // 
            this.GuiaPreciosDataGridView.AllowUserToAddRows = false;
            this.GuiaPreciosDataGridView.AllowUserToDeleteRows = false;
            this.GuiaPreciosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuiaPreciosDataGridView.AutoGenerateColumns = false;
            this.GuiaPreciosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GuiaPreciosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GuiaPreciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuiaPreciosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Editar,
            this.Eliminar});
            this.GuiaPreciosDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuiaPreciosDataGridView.DataSource = this.GuiaPreciosBindingSource;
            this.GuiaPreciosDataGridView.Location = new System.Drawing.Point(12, 96);
            this.GuiaPreciosDataGridView.Name = "GuiaPreciosDataGridView";
            this.GuiaPreciosDataGridView.ReadOnly = true;
            this.GuiaPreciosDataGridView.RowHeadersVisible = false;
            this.GuiaPreciosDataGridView.Size = new System.Drawing.Size(776, 342);
            this.GuiaPreciosDataGridView.TabIndex = 60;
            this.GuiaPreciosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guiaPreciossDataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Concepto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            // frmGestionGuiaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuiaPreciosDataGridView);
            this.Name = "frmGestionGuiaPrecios";
            this.Text = "frmGestionGuiaPrecios";
            this.Load += new System.EventHandler(this.frmGestionGuiaPrecios_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.GuiaPreciosDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GuiaPreciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuiaPreciosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource GuiaPreciosBindingSource;
        private System.Windows.Forms.DataGridView GuiaPreciosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}