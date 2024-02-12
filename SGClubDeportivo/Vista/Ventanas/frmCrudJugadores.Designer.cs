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
            System.Windows.Forms.Label categoria_idLabel;
            this.JugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.ci_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoria_idComboBox = new System.Windows.Forms.ComboBox();
            this.guiaPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            apellidosLabel = new System.Windows.Forms.Label();
            ci_jugadorLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            categoria_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaPreciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            apellidosLabel.Location = new System.Drawing.Point(36, 175);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(112, 28);
            apellidosLabel.TabIndex = 41;
            apellidosLabel.Text = "APELLIDOS: ";
            // 
            // ci_jugadorLabel
            // 
            ci_jugadorLabel.AutoSize = true;
            ci_jugadorLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ci_jugadorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ci_jugadorLabel.Location = new System.Drawing.Point(33, 61);
            ci_jugadorLabel.Name = "ci_jugadorLabel";
            ci_jugadorLabel.Size = new System.Drawing.Size(183, 28);
            ci_jugadorLabel.TabIndex = 43;
            ci_jugadorLabel.Text = "NÚMERO DE CARNET:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNacimientoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fechaNacimientoLabel.Location = new System.Drawing.Point(36, 237);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(198, 28);
            fechaNacimientoLabel.TabIndex = 45;
            fechaNacimientoLabel.Text = "FECHA DE NACIMIENTO";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nombresLabel.Location = new System.Drawing.Point(33, 118);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(104, 28);
            nombresLabel.TabIndex = 47;
            nombresLabel.Text = "NOMBRES :";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tipoLabel.Location = new System.Drawing.Point(36, 294);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(138, 28);
            tipoLabel.TabIndex = 49;
            tipoLabel.Text = "TIPO JUGADOR:";
            // 
            // categoria_idLabel
            // 
            categoria_idLabel.AutoSize = true;
            categoria_idLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoria_idLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            categoria_idLabel.Location = new System.Drawing.Point(39, 353);
            categoria_idLabel.Name = "categoria_idLabel";
            categoria_idLabel.Size = new System.Drawing.Size(109, 28);
            categoria_idLabel.TabIndex = 50;
            categoria_idLabel.Text = "CATEGORIA:";
            categoria_idLabel.Click += new System.EventHandler(this.categoria_idLabel_Click);
            // 
            // JugadoresBindingSource
            // 
            this.JugadoresBindingSource.DataSource = typeof(SGClubDeportivo.Data.Jugadores);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Apellidos", true));
            this.apellidosTextBox.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTextBox.Location = new System.Drawing.Point(240, 172);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(256, 31);
            this.apellidosTextBox.TabIndex = 2;
            // 
            // ci_jugadorTextBox
            // 
            this.ci_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Ci_jugador", true));
            this.ci_jugadorTextBox.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ci_jugadorTextBox.Location = new System.Drawing.Point(240, 58);
            this.ci_jugadorTextBox.Name = "ci_jugadorTextBox";
            this.ci_jugadorTextBox.Size = new System.Drawing.Size(200, 31);
            this.ci_jugadorTextBox.TabIndex = 0;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.JugadoresBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(240, 234);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(256, 31);
            this.fechaNacimientoDateTimePicker.TabIndex = 3;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Nombres", true));
            this.nombresTextBox.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombresTextBox.Location = new System.Drawing.Point(240, 115);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(256, 31);
            this.nombresTextBox.TabIndex = 1;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.JugadoresBindingSource, "Tipo", true));
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guiaPreciosBindingSource, "Concepto", true));
            this.tipoComboBox.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "ANUAL",
            "VACACIONAL"});
            this.tipoComboBox.Location = new System.Drawing.Point(240, 295);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(256, 32);
            this.tipoComboBox.TabIndex = 4;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(SGClubDeportivo.Data.Categorias);
            // 
            // categoria_idComboBox
            // 
            this.categoria_idComboBox.DataSource = this.categoriasBindingSource;
            this.categoria_idComboBox.DisplayMember = "Nombre";
            this.categoria_idComboBox.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria_idComboBox.FormattingEnabled = true;
            this.categoria_idComboBox.Location = new System.Drawing.Point(240, 353);
            this.categoria_idComboBox.Name = "categoria_idComboBox";
            this.categoria_idComboBox.Size = new System.Drawing.Size(256, 32);
            this.categoria_idComboBox.TabIndex = 5;
            this.categoria_idComboBox.ValueMember = "Nombre";
            // 
            // guiaPreciosBindingSource
            // 
            this.guiaPreciosBindingSource.DataSource = typeof(SGClubDeportivo.Data.GuiaPrecios);
            // 
            // frmCrudJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 509);
            this.Controls.Add(this.categoria_idComboBox);
            this.Controls.Add(categoria_idLabel);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.Controls.SetChildIndex(categoria_idLabel, 0);
            this.Controls.SetChildIndex(this.categoria_idComboBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaPreciosBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox categoria_idComboBox;
        private System.Windows.Forms.BindingSource guiaPreciosBindingSource;
    }
}