
namespace SGClubDeportivo.Vista.Gestiones
{
    partial class frmGestionHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionHorario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAceptarCategoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.selHorario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TituloCategoria = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            //this.jugadorTableAdapter = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter();
            //this.tableAdapterManager = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager();
            //this.bdClubDeportivoDataSet = new SGClubDeportivo.Data.BdClubDeportivoDataSet();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 43);
            this.panel1.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(157, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(317, 31);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "GESTION DE HORARIO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAceptarCategoria);
            this.panel2.Controls.Add(this.selHorario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 100);
            this.panel2.TabIndex = 12;
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAceptarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAceptarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptarCategoria.BorderRadius = 0;
            this.btnAceptarCategoria.ButtonText = "SELECCIONAR";
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
            this.btnAceptarCategoria.Location = new System.Drawing.Point(432, 12);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAceptarCategoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAceptarCategoria.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptarCategoria.selected = false;
            this.btnAceptarCategoria.Size = new System.Drawing.Size(143, 27);
            this.btnAceptarCategoria.TabIndex = 19;
            this.btnAceptarCategoria.Text = "SELECCIONAR";
            this.btnAceptarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarCategoria.Textcolor = System.Drawing.Color.White;
            this.btnAceptarCategoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // selHorario
            // 
            this.selHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selHorario.FormattingEnabled = true;
            this.selHorario.Items.AddRange(new object[] {
            "TODOS",
            "SUB 7",
            "SUB 9",
            "SUB 11",
            "SUB 13",
            "SUB 15",
            "SUB 17"});
            this.selHorario.Location = new System.Drawing.Point(233, 13);
            this.selHorario.Name = "selHorario";
            this.selHorario.Size = new System.Drawing.Size(171, 23);
            this.selHorario.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione categoría";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.TituloCategoria);
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 45);
            this.panel3.TabIndex = 16;
            // 
            // TituloCategoria
            // 
            this.TituloCategoria.AutoSize = true;
            this.TituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TituloCategoria.Location = new System.Drawing.Point(205, 10);
            this.TituloCategoria.Name = "TituloCategoria";
            this.TituloCategoria.Size = new System.Drawing.Size(161, 26);
            this.TituloCategoria.TabIndex = 5;
            this.TituloCategoria.Text = "CATEGORIA ()";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(25, 385);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 32);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // jugadorTableAdapter
            // 
            //this.jugadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.AdministradorTableAdapter = null;
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.CategoriaTableAdapter = null;
            //this.tableAdapterManager.HorarioTableAdapter = null;
            //this.tableAdapterManager.JugadorTableAdapter = this.jugadorTableAdapter;
            //this.tableAdapterManager.SecretariaTableAdapter = null;
            //this.tableAdapterManager.UpdateOrder = SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdClubDeportivoDataSet
            // 
            //this.bdClubDeportivoDataSet.DataSetName = "BdClubDeportivoDataSet";
            //this.bdClubDeportivoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.CI,
            this.NOMBRE,
            this.categoria});
            this.dgvJugadores.DataSource = this.jugadorBindingSource;
            this.dgvJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvJugadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvJugadores.Location = new System.Drawing.Point(4, 147);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowHeadersVisible = false;
            this.dgvJugadores.Size = new System.Drawing.Size(587, 227);
            this.dgvJugadores.TabIndex = 31;
            this.dgvJugadores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvJugadores_CellPainting_1);
            // 
            // CI
            // 
            this.CI.DataPropertyName = "ci_jugador";
            this.CI.FillWeight = 96.01413F;
            this.CI.HeaderText = "CI";
            this.CI.Name = "CI";
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "nom_jugador";
            this.NOMBRE.FillWeight = 116.8707F;
            this.NOMBRE.HeaderText = "NOMBRE COMPLETO";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "id_categoria";
            this.categoria.HeaderText = "ID_CATEGORIA";
            this.categoria.Name = "categoria";
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataMember = "Jugador";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(409, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 32);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Orange;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ad;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(217, 385);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(130, 32);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.Text = "NUEVO";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmGestionHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(595, 424);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionHorario";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "frmGestionHorario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptarCategoria;
        private System.Windows.Forms.ComboBox selHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TituloCategoria;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        //private Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter jugadorTableAdapter;
        //private Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        //private Data.BdClubDeportivoDataSet bdClubDeportivoDataSet;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}