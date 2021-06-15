
namespace SGClubDeportivo.Vista.Gestiones
{
    partial class frmGestionJugadores
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
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label ci_jugadorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionJugadores));
            this.linkLabelSalir = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptarCategoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscarJugador = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnNuevoJugador = new FontAwesome.Sharp.IconButton();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.cijugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomjugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cisecretariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdClubDeportivoDataSet = new SGClubDeportivo.Data.BdClubDeportivoDataSet();
            this.jugadorTableAdapter = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter();
            this.tableAdapterManager = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager();
            this.id_categoriaLabel1 = new System.Windows.Forms.Label();
            this.ci_jugadorLabel1 = new System.Windows.Forms.Label();
            this.bdClubDeportivoDataSet1 = new SGClubDeportivo.Data.BdClubDeportivoDataSet();
            this.jugadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MoverVentanaCrud = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.CategoriaTableAdapter();
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblIdCatInsert = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            ci_jugadorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.ForeColor = System.Drawing.SystemColors.Control;
            id_categoriaLabel.Location = new System.Drawing.Point(426, 422);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(65, 13);
            id_categoriaLabel.TabIndex = 14;
            id_categoriaLabel.Text = "id categoria:";
            // 
            // ci_jugadorLabel
            // 
            ci_jugadorLabel.AutoSize = true;
            ci_jugadorLabel.ForeColor = System.Drawing.SystemColors.Control;
            ci_jugadorLabel.Location = new System.Drawing.Point(258, 422);
            ci_jugadorLabel.Name = "ci_jugadorLabel";
            ci_jugadorLabel.Size = new System.Drawing.Size(56, 13);
            ci_jugadorLabel.TabIndex = 15;
            ci_jugadorLabel.Text = "ci jugador:";
            // 
            // linkLabelSalir
            // 
            this.linkLabelSalir.AutoSize = true;
            this.linkLabelSalir.Font = new System.Drawing.Font("Robot Crush", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSalir.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabelSalir.Location = new System.Drawing.Point(572, 9);
            this.linkLabelSalir.Name = "linkLabelSalir";
            this.linkLabelSalir.Size = new System.Drawing.Size(21, 23);
            this.linkLabelSalir.TabIndex = 1;
            this.linkLabelSalir.TabStop = true;
            this.linkLabelSalir.Text = "X";
            this.linkLabelSalir.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabelSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSalir_LinkClicked);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Minehead DEMO", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(188, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 34);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "GESTION DE JUGADORES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.linkLabelSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 43);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.lblTituloCategoria);
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 32);
            this.panel2.TabIndex = 7;
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Minehead DEMO", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloCategoria.Location = new System.Drawing.Point(228, 0);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(158, 30);
            this.lblTituloCategoria.TabIndex = 5;
            this.lblTituloCategoria.Text = "CATEGORIA (TODOS)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Typo Oval Demo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione categoría";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Typo Oval Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "TODOS",
            "SUB 7",
            "SUB 9",
            "SUB 11",
            "SUB 13",
            "SUB 15",
            "SUB 17"});
            this.cmbCategoria.Location = new System.Drawing.Point(211, 55);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(171, 21);
            this.cmbCategoria.TabIndex = 9;
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAceptarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAceptarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptarCategoria.BorderRadius = 0;
            this.btnAceptarCategoria.ButtonText = "ACEPTAR";
            this.btnAceptarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarCategoria.DisabledColor = System.Drawing.Color.Gray;
            this.btnAceptarCategoria.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAceptarCategoria.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAceptarCategoria.Iconimage")));
            this.btnAceptarCategoria.Iconimage_right = null;
            this.btnAceptarCategoria.Iconimage_right_Selected = null;
            this.btnAceptarCategoria.Iconimage_Selected = null;
            this.btnAceptarCategoria.IconMarginLeft = 0;
            this.btnAceptarCategoria.IconMarginRight = 0;
            this.btnAceptarCategoria.IconRightVisible = true;
            this.btnAceptarCategoria.IconRightZoom = 0D;
            this.btnAceptarCategoria.IconVisible = true;
            this.btnAceptarCategoria.IconZoom = 90D;
            this.btnAceptarCategoria.IsTab = false;
            this.btnAceptarCategoria.Location = new System.Drawing.Point(393, 54);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAceptarCategoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAceptarCategoria.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptarCategoria.selected = false;
            this.btnAceptarCategoria.Size = new System.Drawing.Size(129, 27);
            this.btnAceptarCategoria.TabIndex = 10;
            this.btnAceptarCategoria.Text = "ACEPTAR";
            this.btnAceptarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarCategoria.Textcolor = System.Drawing.Color.White;
            this.btnAceptarCategoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // txtBuscarJugador
            // 
            this.txtBuscarJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.txtBuscarJugador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarJugador.BackgroundImage")));
            this.txtBuscarJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarJugador.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.txtBuscarJugador.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarJugador.Icon")));
            this.txtBuscarJugador.Location = new System.Drawing.Point(194, 128);
            this.txtBuscarJugador.Name = "txtBuscarJugador";
            this.txtBuscarJugador.Size = new System.Drawing.Size(380, 33);
            this.txtBuscarJugador.TabIndex = 12;
            this.txtBuscarJugador.text = "";
            this.txtBuscarJugador.OnTextChange += new System.EventHandler(this.txtBuscarJugador_OnTextChange);
            // 
            // btnNuevoJugador
            // 
            this.btnNuevoJugador.BackColor = System.Drawing.Color.Orange;
            this.btnNuevoJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoJugador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoJugador.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNuevoJugador.IconColor = System.Drawing.Color.White;
            this.btnNuevoJugador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoJugador.IconSize = 30;
            this.btnNuevoJugador.Location = new System.Drawing.Point(27, 128);
            this.btnNuevoJugador.Name = "btnNuevoJugador";
            this.btnNuevoJugador.Size = new System.Drawing.Size(161, 33);
            this.btnNuevoJugador.TabIndex = 13;
            this.btnNuevoJugador.Text = "NUEVO JUGADOR";
            this.btnNuevoJugador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoJugador.UseVisualStyleBackColor = false;
            this.btnNuevoJugador.Click += new System.EventHandler(this.btnNuevoJugador_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.AutoGenerateColumns = false;
            this.dgvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJugadores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvJugadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cijugadorDataGridViewTextBoxColumn,
            this.nomjugadorDataGridViewTextBoxColumn,
            this.fechanacDataGridViewTextBoxColumn,
            this.cisecretariaDataGridViewTextBoxColumn,
            this.idcategoriaDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar});
            this.dgvJugadores.DataSource = this.jugadorBindingSource;
            this.dgvJugadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvJugadores.Location = new System.Drawing.Point(27, 178);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowHeadersVisible = false;
            this.dgvJugadores.Size = new System.Drawing.Size(547, 227);
            this.dgvJugadores.TabIndex = 14;
            this.dgvJugadores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.jugadorDataGridView_CellPainting);
            // 
            // cijugadorDataGridViewTextBoxColumn
            // 
            this.cijugadorDataGridViewTextBoxColumn.DataPropertyName = "ci_jugador";
            this.cijugadorDataGridViewTextBoxColumn.HeaderText = "CI";
            this.cijugadorDataGridViewTextBoxColumn.Name = "cijugadorDataGridViewTextBoxColumn";
            // 
            // nomjugadorDataGridViewTextBoxColumn
            // 
            this.nomjugadorDataGridViewTextBoxColumn.DataPropertyName = "nom_jugador";
            this.nomjugadorDataGridViewTextBoxColumn.HeaderText = "NOMBRE COMPLETO";
            this.nomjugadorDataGridViewTextBoxColumn.Name = "nomjugadorDataGridViewTextBoxColumn";
            // 
            // fechanacDataGridViewTextBoxColumn
            // 
            this.fechanacDataGridViewTextBoxColumn.DataPropertyName = "fecha_nac";
            this.fechanacDataGridViewTextBoxColumn.HeaderText = "FECHA NAC";
            this.fechanacDataGridViewTextBoxColumn.Name = "fechanacDataGridViewTextBoxColumn";
            // 
            // cisecretariaDataGridViewTextBoxColumn
            // 
            this.cisecretariaDataGridViewTextBoxColumn.DataPropertyName = "ci_secretaria";
            this.cisecretariaDataGridViewTextBoxColumn.HeaderText = "ci_secretaria";
            this.cisecretariaDataGridViewTextBoxColumn.Name = "cisecretariaDataGridViewTextBoxColumn";
            this.cisecretariaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idcategoriaDataGridViewTextBoxColumn
            // 
            this.idcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.HeaderText = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.Name = "idcategoriaDataGridViewTextBoxColumn";
            this.idcategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Modificar
            // 
            this.Modificar.FillWeight = 188.2036F;
            this.Modificar.HeaderText = "Editar";
            this.Modificar.Name = "Modificar";
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 204.7744F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataMember = "Jugador";
            this.jugadorBindingSource.DataSource = this.bdClubDeportivoDataSet;
            // 
            // bdClubDeportivoDataSet
            // 
            this.bdClubDeportivoDataSet.DataSetName = "BdClubDeportivoDataSet";
            this.bdClubDeportivoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadorTableAdapter
            // 
            this.jugadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministradorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.JugadorTableAdapter = this.jugadorTableAdapter;
            this.tableAdapterManager.SecretariaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_categoriaLabel1
            // 
            this.id_categoriaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "id_categoria", true));
            this.id_categoriaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.id_categoriaLabel1.Location = new System.Drawing.Point(503, 422);
            this.id_categoriaLabel1.Name = "id_categoriaLabel1";
            this.id_categoriaLabel1.Size = new System.Drawing.Size(56, 23);
            this.id_categoriaLabel1.TabIndex = 15;
            this.id_categoriaLabel1.Text = "label3";
            // 
            // ci_jugadorLabel1
            // 
            this.ci_jugadorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "ci_jugador", true));
            this.ci_jugadorLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.ci_jugadorLabel1.Location = new System.Drawing.Point(320, 422);
            this.ci_jugadorLabel1.Name = "ci_jugadorLabel1";
            this.ci_jugadorLabel1.Size = new System.Drawing.Size(100, 23);
            this.ci_jugadorLabel1.TabIndex = 16;
            this.ci_jugadorLabel1.Text = "label3";
            // 
            // bdClubDeportivoDataSet1
            // 
            this.bdClubDeportivoDataSet1.DataSetName = "BdClubDeportivoDataSet";
            this.bdClubDeportivoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadorBindingSource1
            // 
            this.jugadorBindingSource1.DataMember = "Jugador";
            this.jugadorBindingSource1.DataSource = this.bdClubDeportivoDataSet1;
            // 
            // MoverVentanaCrud
            // 
            this.MoverVentanaCrud.Fixed = true;
            this.MoverVentanaCrud.Horizontal = true;
            this.MoverVentanaCrud.TargetControl = null;
            this.MoverVentanaCrud.Vertical = true;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.bdClubDeportivoDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataMember = "Categoria";
            this.categoriaBindingSource1.DataSource = this.bdClubDeportivoDataSet1;
            // 
            // lblIdCatInsert
            // 
            this.lblIdCatInsert.AutoSize = true;
            this.lblIdCatInsert.Location = new System.Drawing.Point(47, 422);
            this.lblIdCatInsert.Name = "lblIdCatInsert";
            this.lblIdCatInsert.Size = new System.Drawing.Size(35, 13);
            this.lblIdCatInsert.TabIndex = 18;
            this.lblIdCatInsert.Text = "label1";
            // 
            // frmGestionJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(612, 469);
            this.Controls.Add(this.lblIdCatInsert);
            this.Controls.Add(ci_jugadorLabel);
            this.Controls.Add(this.ci_jugadorLabel1);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaLabel1);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnNuevoJugador);
            this.Controls.Add(this.txtBuscarJugador);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionJugadores";
            this.Text = "frmGestionJugadores";
            this.Load += new System.EventHandler(this.frmGestionJugadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptarCategoria;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarJugador;
        private FontAwesome.Sharp.IconButton btnNuevoJugador;
        private Data.BdClubDeportivoDataSet bdClubDeportivoDataSet;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter jugadorTableAdapter;
        private Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Label id_categoriaLabel1;
        private System.Windows.Forms.Label ci_jugadorLabel1;
        private Data.BdClubDeportivoDataSet bdClubDeportivoDataSet1;
        private System.Windows.Forms.BindingSource jugadorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomjugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisecretariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
        private Bunifu.Framework.UI.BunifuDragControl MoverVentanaCrud;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Data.BdClubDeportivoDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource1;
        private System.Windows.Forms.Label lblIdCatInsert;
    }
}