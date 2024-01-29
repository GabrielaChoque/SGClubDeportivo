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
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label ci_jugadorLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label nombreLabel;
            this.JugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.ci_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            apellidosLabel = new System.Windows.Forms.Label();
            ci_jugadorLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
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
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            apellidosLabel.Location = new System.Drawing.Point(120, 95);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 41;
            apellidosLabel.Text = "Apellidos:";
            // 
            // ci_jugadorLabel
            // 
            ci_jugadorLabel.AutoSize = true;
            ci_jugadorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ci_jugadorLabel.Location = new System.Drawing.Point(120, 121);
            ci_jugadorLabel.Name = "ci_jugadorLabel";
            ci_jugadorLabel.Size = new System.Drawing.Size(57, 13);
            ci_jugadorLabel.TabIndex = 43;
            ci_jugadorLabel.Text = "Ci jugador:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fechaNacimientoLabel.Location = new System.Drawing.Point(120, 148);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 45;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nombresLabel.Location = new System.Drawing.Point(120, 173);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 47;
            nombresLabel.Text = "Nombres:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tipoLabel.Location = new System.Drawing.Point(120, 199);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 49;
            tipoLabel.Text = "Tipo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nombreLabel.Location = new System.Drawing.Point(125, 232);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 50;
            nombreLabel.Text = "Nombre:";
            // 
            // JugadoresBindingSource
            // 
            this.JugadoresBindingSource.DataSource = typeof(SGClubDeportivo.Data.Jugadores);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(222, 92);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 42;
            // 
            // ci_jugadorTextBox
            // 
            this.ci_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Ci_jugador", true));
            this.ci_jugadorTextBox.Location = new System.Drawing.Point(222, 118);
            this.ci_jugadorTextBox.Name = "ci_jugadorTextBox";
            this.ci_jugadorTextBox.Size = new System.Drawing.Size(200, 20);
            this.ci_jugadorTextBox.TabIndex = 44;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.JugadoresBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(222, 144);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 46;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(222, 170);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 48;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Tipo", true));
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(222, 196);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(200, 21);
            this.tipoComboBox.TabIndex = 50;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(SGClubDeportivo.Data.Categorias);
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Categorias.Nombre", true));
            this.nombreComboBox.DataSource = this.categoriasBindingSource;
            this.nombreComboBox.DisplayMember = "Nombre";
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(220, 229);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(202, 21);
            this.nombreComboBox.TabIndex = 51;
            // 
            // frmCrudJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 514);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreComboBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(ci_jugadorLabel);
            this.Controls.Add(this.ci_jugadorTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoComboBox);
            this.Name = "frmCrudJugadores";
            this.Text = "frmCrudJugadores";
            this.Load += new System.EventHandler(this.frmCrudjugador_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.tipoComboBox, 0);
            this.Controls.SetChildIndex(tipoLabel, 0);
            this.Controls.SetChildIndex(this.nombresTextBox, 0);
            this.Controls.SetChildIndex(nombresLabel, 0);
            this.Controls.SetChildIndex(this.fechaNacimientoDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaNacimientoLabel, 0);
            this.Controls.SetChildIndex(this.ci_jugadorTextBox, 0);
            this.Controls.SetChildIndex(ci_jugadorLabel, 0);
            this.Controls.SetChildIndex(this.apellidosTextBox, 0);
            this.Controls.SetChildIndex(apellidosLabel, 0);
            this.Controls.SetChildIndex(this.nombreComboBox, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource JugadoresBindingSource;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox ci_jugadorTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.ComboBox nombreComboBox;
    }
}