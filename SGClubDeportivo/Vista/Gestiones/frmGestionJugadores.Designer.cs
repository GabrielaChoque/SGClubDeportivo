
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionJugadores));
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label ci_jugadorLabel;
            System.Windows.Forms.Label ci_jugadorLabel2;
            System.Windows.Forms.Label nom_jugadorLabel;
            System.Windows.Forms.Label fecha_nacLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label fecha_registroLabel;
            System.Windows.Forms.Label nom_categoriaLabel;
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
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdClubDeportivoDataSet = new SGClubDeportivo.Data.BdClubDeportivoDataSet();
            this.jugadorTableAdapter = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter();
            this.tableAdapterManager = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager();
            this.id_categoriaLabel1 = new System.Windows.Forms.Label();
            this.ci_jugadorLabel1 = new System.Windows.Forms.Label();
            this.panelVentanaCrud = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTituloCrud = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.ci_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.nom_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbCategoriaCrud = new System.Windows.Forms.ComboBox();
            this.bdClubDeportivoDataSet1 = new SGClubDeportivo.Data.BdClubDeportivoDataSet();
            this.jugadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cijugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomjugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cisecretariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_registroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MoverVentanaCrud = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.CategoriaTableAdapter();
            this.nom_categoriaLabel1 = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            ci_jugadorLabel = new System.Windows.Forms.Label();
            ci_jugadorLabel2 = new System.Windows.Forms.Label();
            nom_jugadorLabel = new System.Windows.Forms.Label();
            fecha_nacLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            fecha_registroLabel = new System.Windows.Forms.Label();
            nom_categoriaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).BeginInit();
            this.panelVentanaCrud.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(622, 43);
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
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.ForeColor = System.Drawing.SystemColors.Control;
            id_categoriaLabel.Location = new System.Drawing.Point(481, 422);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(65, 13);
            id_categoriaLabel.TabIndex = 14;
            id_categoriaLabel.Text = "id categoria:";
            // 
            // id_categoriaLabel1
            // 
            this.id_categoriaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "id_categoria", true));
            this.id_categoriaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.id_categoriaLabel1.Location = new System.Drawing.Point(545, 422);
            this.id_categoriaLabel1.Name = "id_categoriaLabel1";
            this.id_categoriaLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_categoriaLabel1.TabIndex = 15;
            this.id_categoriaLabel1.Text = "label3";
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
            // panelVentanaCrud
            // 
            this.panelVentanaCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.panelVentanaCrud.Controls.Add(fecha_registroLabel);
            this.panelVentanaCrud.Controls.Add(this.fecha_registroDateTimePicker);
            this.panelVentanaCrud.Controls.Add(label3);
            this.panelVentanaCrud.Controls.Add(this.cmbCategoriaCrud);
            this.panelVentanaCrud.Controls.Add(fecha_nacLabel);
            this.panelVentanaCrud.Controls.Add(this.fecha_nacDateTimePicker);
            this.panelVentanaCrud.Controls.Add(nom_jugadorLabel);
            this.panelVentanaCrud.Controls.Add(this.nom_jugadorTextBox);
            this.panelVentanaCrud.Controls.Add(ci_jugadorLabel2);
            this.panelVentanaCrud.Controls.Add(this.ci_jugadorTextBox);
            this.panelVentanaCrud.Controls.Add(this.btnCancelar);
            this.panelVentanaCrud.Controls.Add(this.btnAceptar);
            this.panelVentanaCrud.Controls.Add(this.panel4);
            this.panelVentanaCrud.Location = new System.Drawing.Point(163, 142);
            this.panelVentanaCrud.Name = "panelVentanaCrud";
            this.panelVentanaCrud.Size = new System.Drawing.Size(301, 277);
            this.panelVentanaCrud.TabIndex = 17;
            this.panelVentanaCrud.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel4.Controls.Add(this.lblTituloCrud);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 44);
            this.panel4.TabIndex = 0;
            // 
            // lblTituloCrud
            // 
            this.lblTituloCrud.AutoSize = true;
            this.lblTituloCrud.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloCrud.Location = new System.Drawing.Point(81, 8);
            this.lblTituloCrud.Name = "lblTituloCrud";
            this.lblTituloCrud.Size = new System.Drawing.Size(80, 23);
            this.lblTituloCrud.TabIndex = 0;
            this.lblTituloCrud.Text = "TITULO";
            this.lblTituloCrud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Typo Oval Demo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(21, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Typo Oval Demo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAceptar.IconColor = System.Drawing.Color.White;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 25;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(171, 231);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 32);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // ci_jugadorLabel2
            // 
            ci_jugadorLabel2.AutoSize = true;
            ci_jugadorLabel2.Location = new System.Drawing.Point(20, 57);
            ci_jugadorLabel2.Name = "ci_jugadorLabel2";
            ci_jugadorLabel2.Size = new System.Drawing.Size(81, 13);
            ci_jugadorLabel2.TabIndex = 10;
            ci_jugadorLabel2.Text = "NRO. CARNET";
            // 
            // ci_jugadorTextBox
            // 
            this.ci_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "ci_jugador", true));
            this.ci_jugadorTextBox.Location = new System.Drawing.Point(21, 71);
            this.ci_jugadorTextBox.Name = "ci_jugadorTextBox";
            this.ci_jugadorTextBox.Size = new System.Drawing.Size(116, 20);
            this.ci_jugadorTextBox.TabIndex = 11;
            // 
            // nom_jugadorLabel
            // 
            nom_jugadorLabel.AutoSize = true;
            nom_jugadorLabel.Location = new System.Drawing.Point(18, 96);
            nom_jugadorLabel.Name = "nom_jugadorLabel";
            nom_jugadorLabel.Size = new System.Drawing.Size(119, 13);
            nom_jugadorLabel.TabIndex = 11;
            nom_jugadorLabel.Text = "NOMBRE COMPLETO:";
            // 
            // nom_jugadorTextBox
            // 
            this.nom_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "nom_jugador", true));
            this.nom_jugadorTextBox.Location = new System.Drawing.Point(21, 109);
            this.nom_jugadorTextBox.Name = "nom_jugadorTextBox";
            this.nom_jugadorTextBox.Size = new System.Drawing.Size(261, 20);
            this.nom_jugadorTextBox.TabIndex = 12;
            // 
            // fecha_nacLabel
            // 
            fecha_nacLabel.AutoSize = true;
            fecha_nacLabel.Location = new System.Drawing.Point(20, 134);
            fecha_nacLabel.Name = "fecha_nacLabel";
            fecha_nacLabel.Size = new System.Drawing.Size(133, 13);
            fecha_nacLabel.TabIndex = 12;
            fecha_nacLabel.Text = "FECHA DE NACIMIENTO:";
            // 
            // fecha_nacDateTimePicker
            // 
            this.fecha_nacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadorBindingSource, "fecha_nac", true));
            this.fecha_nacDateTimePicker.Location = new System.Drawing.Point(21, 150);
            this.fecha_nacDateTimePicker.Name = "fecha_nacDateTimePicker";
            this.fecha_nacDateTimePicker.Size = new System.Drawing.Size(261, 20);
            this.fecha_nacDateTimePicker.TabIndex = 13;
            // 
            // cmbCategoriaCrud
            // 
            this.cmbCategoriaCrud.Font = new System.Drawing.Font("Typo Oval Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaCrud.FormattingEnabled = true;
            this.cmbCategoriaCrud.Items.AddRange(new object[] {
            "SUB 7",
            "SUB 9",
            "SUB 11",
            "SUB 13",
            "SUB 15",
            "SUB 17"});
            this.cmbCategoriaCrud.Location = new System.Drawing.Point(156, 71);
            this.cmbCategoriaCrud.Name = "cmbCategoriaCrud";
            this.cmbCategoriaCrud.Size = new System.Drawing.Size(126, 21);
            this.cmbCategoriaCrud.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(153, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 13);
            label3.TabIndex = 19;
            label3.Text = "CATEGORIA";
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
            // fecha_registroLabel
            // 
            fecha_registroLabel.AutoSize = true;
            fecha_registroLabel.Location = new System.Drawing.Point(20, 180);
            fecha_registroLabel.Name = "fecha_registroLabel";
            fecha_registroLabel.Size = new System.Drawing.Size(119, 13);
            fecha_registroLabel.TabIndex = 19;
            fecha_registroLabel.Text = "FECHA DE REGISTRO";
            // 
            // fecha_registroDateTimePicker
            // 
            this.fecha_registroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadorBindingSource, "fecha_registro", true));
            this.fecha_registroDateTimePicker.Location = new System.Drawing.Point(23, 196);
            this.fecha_registroDateTimePicker.Name = "fecha_registroDateTimePicker";
            this.fecha_registroDateTimePicker.Size = new System.Drawing.Size(259, 20);
            this.fecha_registroDateTimePicker.TabIndex = 20;
            // 
            // MoverVentanaCrud
            // 
            this.MoverVentanaCrud.Fixed = true;
            this.MoverVentanaCrud.Horizontal = true;
            this.MoverVentanaCrud.TargetControl = this.panelVentanaCrud;
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
            // nom_categoriaLabel
            // 
            nom_categoriaLabel.AutoSize = true;
            nom_categoriaLabel.ForeColor = System.Drawing.SystemColors.Control;
            nom_categoriaLabel.Location = new System.Drawing.Point(45, 422);
            nom_categoriaLabel.Name = "nom_categoriaLabel";
            nom_categoriaLabel.Size = new System.Drawing.Size(77, 13);
            nom_categoriaLabel.TabIndex = 17;
            nom_categoriaLabel.Text = "nom categoria:";
            // 
            // nom_categoriaLabel1
            // 
            this.nom_categoriaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "nom_categoria", true));
            this.nom_categoriaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.nom_categoriaLabel1.Location = new System.Drawing.Point(128, 422);
            this.nom_categoriaLabel1.Name = "nom_categoriaLabel1";
            this.nom_categoriaLabel1.Size = new System.Drawing.Size(100, 23);
            this.nom_categoriaLabel1.TabIndex = 18;
            this.nom_categoriaLabel1.Text = "label4";
            // 
            // frmGestionJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(622, 465);
            this.Controls.Add(nom_categoriaLabel);
            this.Controls.Add(this.nom_categoriaLabel1);
            this.Controls.Add(this.panelVentanaCrud);
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
            this.panelVentanaCrud.ResumeLayout(false);
            this.panelVentanaCrud.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panelVentanaCrud;
        private System.Windows.Forms.ComboBox cmbCategoriaCrud;
        private System.Windows.Forms.DateTimePicker fecha_nacDateTimePicker;
        private System.Windows.Forms.TextBox nom_jugadorTextBox;
        private System.Windows.Forms.TextBox ci_jugadorTextBox;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloCrud;
        private Data.BdClubDeportivoDataSet bdClubDeportivoDataSet1;
        private System.Windows.Forms.BindingSource jugadorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomjugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisecretariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
        private System.Windows.Forms.DateTimePicker fecha_registroDateTimePicker;
        private Bunifu.Framework.UI.BunifuDragControl MoverVentanaCrud;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Data.BdClubDeportivoDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.Label nom_categoriaLabel1;
    }
}