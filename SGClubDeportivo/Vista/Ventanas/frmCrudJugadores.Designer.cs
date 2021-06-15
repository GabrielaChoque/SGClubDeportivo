
namespace SGClubDeportivo.Vista.Ventanas
{
    partial class frmCrudJugadores
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
            System.Windows.Forms.Label fecha_registroLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label fecha_nacLabel;
            System.Windows.Forms.Label nom_jugadorLabel;
            System.Windows.Forms.Label ci_jugadorLabel2;
            this.bdClubDeportivoDataSet = new SGClubDeportivo.Data.BdClubDeportivoDataSet();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadorTableAdapter = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter();
            this.tableAdapterManager = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager();
            this.fecha_registroDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fecha_nacDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nom_jugadorTextBox1 = new System.Windows.Forms.TextBox();
            this.ci_jugadorTextBox1 = new System.Windows.Forms.TextBox();
            this.cmbCategoriaCrud = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTituloCrud = new System.Windows.Forms.Label();
            fecha_registroLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            fecha_nacLabel = new System.Windows.Forms.Label();
            nom_jugadorLabel = new System.Windows.Forms.Label();
            ci_jugadorLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdClubDeportivoDataSet
            // 
            this.bdClubDeportivoDataSet.DataSetName = "BdClubDeportivoDataSet";
            this.bdClubDeportivoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataMember = "Jugador";
            this.jugadorBindingSource.DataSource = this.bdClubDeportivoDataSet;
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
            // fecha_registroDateTimePicker1
            // 
            this.fecha_registroDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadorBindingSource, "fecha_registro", true));
            this.fecha_registroDateTimePicker1.Location = new System.Drawing.Point(30, 190);
            this.fecha_registroDateTimePicker1.Name = "fecha_registroDateTimePicker1";
            this.fecha_registroDateTimePicker1.Size = new System.Drawing.Size(261, 20);
            this.fecha_registroDateTimePicker1.TabIndex = 36;
            // 
            // fecha_nacDateTimePicker1
            // 
            this.fecha_nacDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadorBindingSource, "fecha_nac", true));
            this.fecha_nacDateTimePicker1.Location = new System.Drawing.Point(30, 144);
            this.fecha_nacDateTimePicker1.Name = "fecha_nacDateTimePicker1";
            this.fecha_nacDateTimePicker1.Size = new System.Drawing.Size(261, 20);
            this.fecha_nacDateTimePicker1.TabIndex = 35;
            // 
            // nom_jugadorTextBox1
            // 
            this.nom_jugadorTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "nom_jugador", true));
            this.nom_jugadorTextBox1.Location = new System.Drawing.Point(30, 105);
            this.nom_jugadorTextBox1.Name = "nom_jugadorTextBox1";
            this.nom_jugadorTextBox1.Size = new System.Drawing.Size(261, 20);
            this.nom_jugadorTextBox1.TabIndex = 34;
            // 
            // ci_jugadorTextBox1
            // 
            this.ci_jugadorTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "ci_jugador", true));
            this.ci_jugadorTextBox1.Location = new System.Drawing.Point(30, 65);
            this.ci_jugadorTextBox1.Name = "ci_jugadorTextBox1";
            this.ci_jugadorTextBox1.Size = new System.Drawing.Size(116, 20);
            this.ci_jugadorTextBox1.TabIndex = 33;
            // 
            // fecha_registroLabel
            // 
            fecha_registroLabel.AutoSize = true;
            fecha_registroLabel.Location = new System.Drawing.Point(29, 174);
            fecha_registroLabel.Name = "fecha_registroLabel";
            fecha_registroLabel.Size = new System.Drawing.Size(122, 13);
            fecha_registroLabel.TabIndex = 31;
            fecha_registroLabel.Text = "FECHA DE REGISTRO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(162, 51);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 13);
            label3.TabIndex = 32;
            label3.Text = "CATEGORIA:";
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
            this.cmbCategoriaCrud.Location = new System.Drawing.Point(165, 65);
            this.cmbCategoriaCrud.Name = "cmbCategoriaCrud";
            this.cmbCategoriaCrud.Size = new System.Drawing.Size(126, 21);
            this.cmbCategoriaCrud.TabIndex = 30;
            // 
            // fecha_nacLabel
            // 
            fecha_nacLabel.AutoSize = true;
            fecha_nacLabel.Location = new System.Drawing.Point(29, 128);
            fecha_nacLabel.Name = "fecha_nacLabel";
            fecha_nacLabel.Size = new System.Drawing.Size(133, 13);
            fecha_nacLabel.TabIndex = 29;
            fecha_nacLabel.Text = "FECHA DE NACIMIENTO:";
            // 
            // nom_jugadorLabel
            // 
            nom_jugadorLabel.AutoSize = true;
            nom_jugadorLabel.Location = new System.Drawing.Point(27, 90);
            nom_jugadorLabel.Name = "nom_jugadorLabel";
            nom_jugadorLabel.Size = new System.Drawing.Size(119, 13);
            nom_jugadorLabel.TabIndex = 28;
            nom_jugadorLabel.Text = "NOMBRE COMPLETO:";
            // 
            // ci_jugadorLabel2
            // 
            ci_jugadorLabel2.AutoSize = true;
            ci_jugadorLabel2.Location = new System.Drawing.Point(29, 51);
            ci_jugadorLabel2.Name = "ci_jugadorLabel2";
            ci_jugadorLabel2.Size = new System.Drawing.Size(84, 13);
            ci_jugadorLabel2.TabIndex = 26;
            ci_jugadorLabel2.Text = "NRO. CARNET:";
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
            this.btnCancelar.Location = new System.Drawing.Point(30, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 32);
            this.btnCancelar.TabIndex = 27;
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
            this.btnAceptar.Location = new System.Drawing.Point(180, 225);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 32);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel4.Controls.Add(this.lblTituloCrud);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 44);
            this.panel4.TabIndex = 37;
            // 
            // lblTituloCrud
            // 
            this.lblTituloCrud.AutoSize = true;
            this.lblTituloCrud.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloCrud.Location = new System.Drawing.Point(55, 9);
            this.lblTituloCrud.Name = "lblTituloCrud";
            this.lblTituloCrud.Size = new System.Drawing.Size(205, 23);
            this.lblTituloCrud.TabIndex = 0;
            this.lblTituloCrud.Text = "MODIFICAR JUGADOR";
            this.lblTituloCrud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCrudJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(319, 277);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.fecha_registroDateTimePicker1);
            this.Controls.Add(this.fecha_nacDateTimePicker1);
            this.Controls.Add(this.nom_jugadorTextBox1);
            this.Controls.Add(this.ci_jugadorTextBox1);
            this.Controls.Add(fecha_registroLabel);
            this.Controls.Add(label3);
            this.Controls.Add(this.cmbCategoriaCrud);
            this.Controls.Add(fecha_nacLabel);
            this.Controls.Add(nom_jugadorLabel);
            this.Controls.Add(ci_jugadorLabel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudJugadores";
            this.Text = "frmCrudJugadores";
            this.Load += new System.EventHandler(this.frmCrudJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Data.BdClubDeportivoDataSet bdClubDeportivoDataSet;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter jugadorTableAdapter;
        private Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fecha_registroDateTimePicker1;
        private System.Windows.Forms.DateTimePicker fecha_nacDateTimePicker1;
        private System.Windows.Forms.TextBox nom_jugadorTextBox1;
        private System.Windows.Forms.TextBox ci_jugadorTextBox1;
        private System.Windows.Forms.ComboBox cmbCategoriaCrud;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloCrud;
    }
}