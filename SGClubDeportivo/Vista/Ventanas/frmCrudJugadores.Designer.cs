
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
            System.Windows.Forms.Label ci_jugadorLabel;
            System.Windows.Forms.Label fecha_nacLabel;
            System.Windows.Forms.Label fecha_registroLabel;
            System.Windows.Forms.Label nom_jugadorLabel;
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTituloCrud = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ci_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_registroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nom_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ci_jugadorLabel = new System.Windows.Forms.Label();
            fecha_nacLabel = new System.Windows.Forms.Label();
            fecha_registroLabel = new System.Windows.Forms.Label();
            nom_jugadorLabel = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(178, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 32);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(12, 238);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 32);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel4.Controls.Add(this.lblTituloCrud);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 44);
            this.panel4.TabIndex = 37;
            // 
            // lblTituloCrud
            // 
            this.lblTituloCrud.AutoSize = true;
            this.lblTituloCrud.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloCrud.Location = new System.Drawing.Point(45, 13);
            this.lblTituloCrud.Name = "lblTituloCrud";
            this.lblTituloCrud.Size = new System.Drawing.Size(205, 23);
            this.lblTituloCrud.TabIndex = 0;
            this.lblTituloCrud.Text = "MODIFICAR JUGADOR";
            this.lblTituloCrud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Typo Oval Demo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "SUB 7",
            "SUB 9",
            "SUB 11",
            "SUB 13",
            "SUB 15",
            "SUB 17"});
            this.cmbCategoria.Location = new System.Drawing.Point(170, 64);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(119, 21);
            this.cmbCategoria.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "CATEGORIA";
            // 
            // ci_jugadorLabel
            // 
            ci_jugadorLabel.AutoSize = true;
            ci_jugadorLabel.Location = new System.Drawing.Point(9, 48);
            ci_jugadorLabel.Name = "ci_jugadorLabel";
            ci_jugadorLabel.Size = new System.Drawing.Size(81, 13);
            ci_jugadorLabel.TabIndex = 48;
            ci_jugadorLabel.Text = "NRO CARNET:";
            // 
            // ci_jugadorTextBox
            // 
            this.ci_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "ci_jugador", true));
            this.ci_jugadorTextBox.Location = new System.Drawing.Point(12, 64);
            this.ci_jugadorTextBox.Name = "ci_jugadorTextBox";
            this.ci_jugadorTextBox.Size = new System.Drawing.Size(143, 20);
            this.ci_jugadorTextBox.TabIndex = 49;
            // 
            // fecha_nacLabel
            // 
            fecha_nacLabel.AutoSize = true;
            fecha_nacLabel.Location = new System.Drawing.Point(9, 133);
            fecha_nacLabel.Name = "fecha_nacLabel";
            fecha_nacLabel.Size = new System.Drawing.Size(130, 13);
            fecha_nacLabel.TabIndex = 50;
            fecha_nacLabel.Text = "FECHA DE NACIMIENTO";
            // 
            // fecha_nacDateTimePicker
            // 
            this.fecha_nacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadorBindingSource, "fecha_nac", true));
            this.fecha_nacDateTimePicker.Location = new System.Drawing.Point(12, 149);
            this.fecha_nacDateTimePicker.Name = "fecha_nacDateTimePicker";
            this.fecha_nacDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.fecha_nacDateTimePicker.TabIndex = 51;
            // 
            // fecha_registroLabel
            // 
            fecha_registroLabel.AutoSize = true;
            fecha_registroLabel.Location = new System.Drawing.Point(8, 177);
            fecha_registroLabel.Name = "fecha_registroLabel";
            fecha_registroLabel.Size = new System.Drawing.Size(119, 13);
            fecha_registroLabel.TabIndex = 52;
            fecha_registroLabel.Text = "FECHA DE REGISTRO";
            // 
            // fecha_registroDateTimePicker
            // 
            this.fecha_registroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadorBindingSource, "fecha_registro", true));
            this.fecha_registroDateTimePicker.Enabled = false;
            this.fecha_registroDateTimePicker.Location = new System.Drawing.Point(12, 193);
            this.fecha_registroDateTimePicker.Name = "fecha_registroDateTimePicker";
            this.fecha_registroDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.fecha_registroDateTimePicker.TabIndex = 53;
            // 
            // nom_jugadorLabel
            // 
            nom_jugadorLabel.AutoSize = true;
            nom_jugadorLabel.Location = new System.Drawing.Point(9, 90);
            nom_jugadorLabel.Name = "nom_jugadorLabel";
            nom_jugadorLabel.Size = new System.Drawing.Size(195, 13);
            nom_jugadorLabel.TabIndex = 54;
            nom_jugadorLabel.Text = "NOMBRE COMPLETO DEL JUGADOR";
            // 
            // nom_jugadorTextBox
            // 
            this.nom_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "nom_jugador", true));
            this.nom_jugadorTextBox.Location = new System.Drawing.Point(12, 107);
            this.nom_jugadorTextBox.Name = "nom_jugadorTextBox";
            this.nom_jugadorTextBox.Size = new System.Drawing.Size(277, 20);
            this.nom_jugadorTextBox.TabIndex = 55;
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(SGClubDeportivo.Data.Jugador);
            // 
            // frmCrudJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(305, 284);
            this.Controls.Add(ci_jugadorLabel);
            this.Controls.Add(this.ci_jugadorTextBox);
            this.Controls.Add(fecha_nacLabel);
            this.Controls.Add(this.fecha_nacDateTimePicker);
            this.Controls.Add(fecha_registroLabel);
            this.Controls.Add(this.fecha_registroDateTimePicker);
            this.Controls.Add(nom_jugadorLabel);
            this.Controls.Add(this.nom_jugadorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrudJugadores";
            this.Load += new System.EventHandler(this.frmCrudJugadores_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloCrud;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ci_jugadorTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_registroDateTimePicker;
        private System.Windows.Forms.TextBox nom_jugadorTextBox;
    }
}