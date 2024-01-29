namespace SGClubDeportivo.Vista.Ventanas
{
    partial class frmCrudInscripciones
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
            System.Windows.Forms.Label correlativoLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label ci_jugadorLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label conceptoLabel;
            this.correlativoTextBox = new System.Windows.Forms.TextBox();
            this.InscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.GuiaPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ci_jugadorComboBox = new System.Windows.Forms.ComboBox();
            this.JugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombresComboBox = new System.Windows.Forms.ComboBox();
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conceptoComboBox = new System.Windows.Forms.ComboBox();
            correlativoLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ci_jugadorLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            conceptoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuiaPreciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // correlativoLabel
            // 
            correlativoLabel.AutoSize = true;
            correlativoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            correlativoLabel.Location = new System.Drawing.Point(136, 97);
            correlativoLabel.Name = "correlativoLabel";
            correlativoLabel.Size = new System.Drawing.Size(60, 13);
            correlativoLabel.TabIndex = 41;
            correlativoLabel.Text = "Correlativo:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            descuentoLabel.Location = new System.Drawing.Point(136, 123);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(62, 13);
            descuentoLabel.TabIndex = 43;
            descuentoLabel.Text = "Descuento:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fechaLabel.Location = new System.Drawing.Point(136, 150);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 45;
            fechaLabel.Text = "Fecha:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tipoLabel.Location = new System.Drawing.Point(136, 175);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 47;
            tipoLabel.Text = "Tipo:";
            // 
            // ci_jugadorLabel
            // 
            ci_jugadorLabel.AutoSize = true;
            ci_jugadorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ci_jugadorLabel.Location = new System.Drawing.Point(158, 286);
            ci_jugadorLabel.Name = "ci_jugadorLabel";
            ci_jugadorLabel.Size = new System.Drawing.Size(57, 13);
            ci_jugadorLabel.TabIndex = 49;
            ci_jugadorLabel.Text = "Ci jugador:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nombresLabel.Location = new System.Drawing.Point(160, 330);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 50;
            nombresLabel.Text = "Nombres:";
            // 
            // correlativoTextBox
            // 
            this.correlativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InscripcionesBindingSource, "Correlativo", true));
            this.correlativoTextBox.Location = new System.Drawing.Point(204, 94);
            this.correlativoTextBox.Name = "correlativoTextBox";
            this.correlativoTextBox.Size = new System.Drawing.Size(200, 20);
            this.correlativoTextBox.TabIndex = 42;
            // 
            // InscripcionesBindingSource
            // 
            //this.InscripcionesBindingSource.DataSource = typeof(SGClubDeportivo.Data.Inscripciones);
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InscripcionesBindingSource, "Descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(204, 120);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.descuentoTextBox.TabIndex = 44;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.InscripcionesBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(204, 146);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 46;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InscripcionesBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(204, 172);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipoTextBox.TabIndex = 48;
            // 
            // GuiaPreciosBindingSource
            // 
            this.GuiaPreciosBindingSource.DataSource = typeof(SGClubDeportivo.Data.GuiaPrecios);
            // 
            // ci_jugadorComboBox
            // 
            this.ci_jugadorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InscripcionesBindingSource, "Jugadores.Ci_jugador", true));
            this.ci_jugadorComboBox.DataSource = this.JugadoresBindingSource;
            this.ci_jugadorComboBox.DisplayMember = "Ci_jugador";
            this.ci_jugadorComboBox.FormattingEnabled = true;
            this.ci_jugadorComboBox.Location = new System.Drawing.Point(221, 283);
            this.ci_jugadorComboBox.Name = "ci_jugadorComboBox";
            this.ci_jugadorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ci_jugadorComboBox.TabIndex = 50;
            // 
            // JugadoresBindingSource
            // 
            this.JugadoresBindingSource.DataSource = typeof(SGClubDeportivo.Data.Jugadores);
            // 
            // nombresComboBox
            // 
            this.nombresComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InscripcionesBindingSource, "Usuarios.Nombres", true));
            this.nombresComboBox.DataSource = this.UsuariosBindingSource;
            this.nombresComboBox.DisplayMember = "Nombres";
            this.nombresComboBox.FormattingEnabled = true;
            this.nombresComboBox.Location = new System.Drawing.Point(218, 327);
            this.nombresComboBox.Name = "nombresComboBox";
            this.nombresComboBox.Size = new System.Drawing.Size(121, 21);
            this.nombresComboBox.TabIndex = 51;
            // 
            // UsuariosBindingSource
            // 
            this.UsuariosBindingSource.DataSource = typeof(SGClubDeportivo.Data.Usuarios);
            // 
            // conceptoLabel
            // 
            conceptoLabel.AutoSize = true;
            conceptoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            conceptoLabel.Location = new System.Drawing.Point(165, 250);
            conceptoLabel.Name = "conceptoLabel";
            conceptoLabel.Size = new System.Drawing.Size(56, 13);
            conceptoLabel.TabIndex = 51;
            conceptoLabel.Text = "Concepto:";
            // 
            // conceptoComboBox
            // 
            this.conceptoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InscripcionesBindingSource, "GuiaPrecios.Concepto", true));
            this.conceptoComboBox.DataSource = this.GuiaPreciosBindingSource;
            this.conceptoComboBox.DisplayMember = "Concepto";
            this.conceptoComboBox.FormattingEnabled = true;
            this.conceptoComboBox.Location = new System.Drawing.Point(227, 247);
            this.conceptoComboBox.Name = "conceptoComboBox";
            this.conceptoComboBox.Size = new System.Drawing.Size(121, 21);
            this.conceptoComboBox.TabIndex = 52;
            // 
            // frmCrudInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 530);
            this.Controls.Add(conceptoLabel);
            this.Controls.Add(this.conceptoComboBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresComboBox);
            this.Controls.Add(ci_jugadorLabel);
            this.Controls.Add(this.ci_jugadorComboBox);
            this.Controls.Add(correlativoLabel);
            this.Controls.Add(this.correlativoTextBox);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Name = "frmCrudInscripciones";
            this.Text = "frmCrudInscripciones";
            this.Load += new System.EventHandler(this.frmCrudInscripciones_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.tipoTextBox, 0);
            this.Controls.SetChildIndex(tipoLabel, 0);
            this.Controls.SetChildIndex(this.fechaDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaLabel, 0);
            this.Controls.SetChildIndex(this.descuentoTextBox, 0);
            this.Controls.SetChildIndex(descuentoLabel, 0);
            this.Controls.SetChildIndex(this.correlativoTextBox, 0);
            this.Controls.SetChildIndex(correlativoLabel, 0);
            this.Controls.SetChildIndex(this.ci_jugadorComboBox, 0);
            this.Controls.SetChildIndex(ci_jugadorLabel, 0);
            this.Controls.SetChildIndex(this.nombresComboBox, 0);
            this.Controls.SetChildIndex(nombresLabel, 0);
            this.Controls.SetChildIndex(this.conceptoComboBox, 0);
            this.Controls.SetChildIndex(conceptoLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuiaPreciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource InscripcionesBindingSource;
        private System.Windows.Forms.TextBox correlativoTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.ComboBox ci_jugadorComboBox;
        private System.Windows.Forms.ComboBox nombresComboBox;
        private System.Windows.Forms.BindingSource GuiaPreciosBindingSource;
        private System.Windows.Forms.BindingSource JugadoresBindingSource;
        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private System.Windows.Forms.ComboBox conceptoComboBox;
    }
}