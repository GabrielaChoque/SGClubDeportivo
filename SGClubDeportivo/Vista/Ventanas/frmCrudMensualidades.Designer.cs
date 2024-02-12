namespace SGClubDeportivo.Vista.Ventanas
{
    partial class frmCrudMensualidades
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
            System.Windows.Forms.Label gestionLabel;
            System.Windows.Forms.Label mesLabel;
            System.Windows.Forms.Label cuotaFinalLabel;
            System.Windows.Forms.Label conceptoLabel1;
            System.Windows.Forms.Label fechPagoLabel;
            System.Windows.Forms.Label conceptoLabel;
            this.MensualidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mesComboBox = new System.Windows.Forms.ComboBox();
            this.cuotaFinalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.guiaPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.conceptoComboBox = new System.Windows.Forms.ComboBox();
            this.conceptoTextBox = new System.Windows.Forms.TextBox();
            gestionLabel = new System.Windows.Forms.Label();
            mesLabel = new System.Windows.Forms.Label();
            cuotaFinalLabel = new System.Windows.Forms.Label();
            conceptoLabel1 = new System.Windows.Forms.Label();
            fechPagoLabel = new System.Windows.Forms.Label();
            conceptoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MensualidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaFinalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaPreciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(81, 432);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTituloCrud
            // 
            this.lblTituloCrud.Location = new System.Drawing.Point(111, 9);
            // 
            // gestionLabel
            // 
            gestionLabel.AutoSize = true;
            gestionLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gestionLabel.Location = new System.Drawing.Point(48, 70);
            gestionLabel.Name = "gestionLabel";
            gestionLabel.Size = new System.Drawing.Size(88, 28);
            gestionLabel.TabIndex = 55;
            gestionLabel.Text = "GESTION:";
            // 
            // mesLabel
            // 
            mesLabel.AutoSize = true;
            mesLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mesLabel.Location = new System.Drawing.Point(48, 129);
            mesLabel.Name = "mesLabel";
            mesLabel.Size = new System.Drawing.Size(52, 28);
            mesLabel.TabIndex = 56;
            mesLabel.Text = "MES:";
            // 
            // cuotaFinalLabel
            // 
            cuotaFinalLabel.AutoSize = true;
            cuotaFinalLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cuotaFinalLabel.Location = new System.Drawing.Point(45, 250);
            cuotaFinalLabel.Name = "cuotaFinalLabel";
            cuotaFinalLabel.Size = new System.Drawing.Size(183, 28);
            cuotaFinalLabel.TabIndex = 58;
            cuotaFinalLabel.Text = "MONTO A CANCELAR:";
            // 
            // conceptoLabel1
            // 
            conceptoLabel1.AutoSize = true;
            conceptoLabel1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conceptoLabel1.Location = new System.Drawing.Point(48, 307);
            conceptoLabel1.Name = "conceptoLabel1";
            conceptoLabel1.Size = new System.Drawing.Size(164, 28);
            conceptoLabel1.TabIndex = 60;
            conceptoLabel1.Text = "TIPO DE JUGADOR:";
            // 
            // fechPagoLabel
            // 
            fechPagoLabel.AutoSize = true;
            fechPagoLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechPagoLabel.Location = new System.Drawing.Point(48, 191);
            fechPagoLabel.Name = "fechPagoLabel";
            fechPagoLabel.Size = new System.Drawing.Size(145, 28);
            fechPagoLabel.TabIndex = 59;
            fechPagoLabel.Text = "FECHA DE PAGO:";
            // 
            // conceptoLabel
            // 
            conceptoLabel.AutoSize = true;
            conceptoLabel.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conceptoLabel.Location = new System.Drawing.Point(45, 368);
            conceptoLabel.Name = "conceptoLabel";
            conceptoLabel.Size = new System.Drawing.Size(180, 28);
            conceptoLabel.TabIndex = 57;
            conceptoLabel.Text = "CONCEPTO DE PAGO:";
            // 
            // MensualidadesBindingSource
            // 
            this.MensualidadesBindingSource.DataSource = typeof(SGClubDeportivo.Data.Mensualidades);
            // 
            // jugadoresBindingSource
            // 
            this.jugadoresBindingSource.DataSource = typeof(SGClubDeportivo.Data.Jugadores);
            // 
            // gestionNumericUpDown
            // 
            this.gestionNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MensualidadesBindingSource, "Gestion", true));
            this.gestionNumericUpDown.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionNumericUpDown.Location = new System.Drawing.Point(273, 70);
            this.gestionNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.gestionNumericUpDown.Name = "gestionNumericUpDown";
            this.gestionNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.gestionNumericUpDown.TabIndex = 56;
            // 
            // mesComboBox
            // 
            this.mesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Mes", true));
            this.mesComboBox.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesComboBox.FormattingEnabled = true;
            this.mesComboBox.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.mesComboBox.Location = new System.Drawing.Point(273, 125);
            this.mesComboBox.Name = "mesComboBox";
            this.mesComboBox.Size = new System.Drawing.Size(199, 32);
            this.mesComboBox.TabIndex = 57;
            // 
            // cuotaFinalNumericUpDown
            // 
            this.cuotaFinalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MensualidadesBindingSource, "CuotaFinal", true));
            this.cuotaFinalNumericUpDown.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotaFinalNumericUpDown.Location = new System.Drawing.Point(274, 247);
            this.cuotaFinalNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cuotaFinalNumericUpDown.Name = "cuotaFinalNumericUpDown";
            this.cuotaFinalNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.cuotaFinalNumericUpDown.TabIndex = 59;
            // 
            // guiaPreciosBindingSource
            // 
            this.guiaPreciosBindingSource.DataSource = typeof(SGClubDeportivo.Data.GuiaPrecios);
            // 
            // fechPagoDateTimePicker
            // 
            this.fechPagoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MensualidadesBindingSource, "FechPago", true));
            this.fechPagoDateTimePicker.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechPagoDateTimePicker.Location = new System.Drawing.Point(272, 188);
            this.fechPagoDateTimePicker.Name = "fechPagoDateTimePicker";
            this.fechPagoDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.fechPagoDateTimePicker.TabIndex = 60;
            // 
            // conceptoComboBox
            // 
            this.conceptoComboBox.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conceptoComboBox.FormattingEnabled = true;
            this.conceptoComboBox.Location = new System.Drawing.Point(273, 303);
            this.conceptoComboBox.Name = "conceptoComboBox";
            this.conceptoComboBox.Size = new System.Drawing.Size(199, 32);
            this.conceptoComboBox.TabIndex = 61;
            this.conceptoComboBox.SelectedIndexChanged += new System.EventHandler(this.conceptoComboBox_SelectedIndexChanged);
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Concepto", true));
            this.conceptoTextBox.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conceptoTextBox.Location = new System.Drawing.Point(272, 359);
            this.conceptoTextBox.Multiline = true;
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(200, 51);
            this.conceptoTextBox.TabIndex = 58;
            this.conceptoTextBox.Text = "Pago de mensualidad de entrenamiento";
            // 
            // frmCrudMensualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 501);
            this.Controls.Add(this.conceptoComboBox);
            this.Controls.Add(conceptoLabel1);
            this.Controls.Add(fechPagoLabel);
            this.Controls.Add(this.fechPagoDateTimePicker);
            this.Controls.Add(cuotaFinalLabel);
            this.Controls.Add(this.cuotaFinalNumericUpDown);
            this.Controls.Add(conceptoLabel);
            this.Controls.Add(this.conceptoTextBox);
            this.Controls.Add(mesLabel);
            this.Controls.Add(this.mesComboBox);
            this.Controls.Add(gestionLabel);
            this.Controls.Add(this.gestionNumericUpDown);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudMensualidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrudMensualidades";
            this.Load += new System.EventHandler(this.frmCrudMensualidades_Load);
            this.Controls.SetChildIndex(this.gestionNumericUpDown, 0);
            this.Controls.SetChildIndex(gestionLabel, 0);
            this.Controls.SetChildIndex(this.mesComboBox, 0);
            this.Controls.SetChildIndex(mesLabel, 0);
            this.Controls.SetChildIndex(this.conceptoTextBox, 0);
            this.Controls.SetChildIndex(conceptoLabel, 0);
            this.Controls.SetChildIndex(this.cuotaFinalNumericUpDown, 0);
            this.Controls.SetChildIndex(cuotaFinalLabel, 0);
            this.Controls.SetChildIndex(this.fechPagoDateTimePicker, 0);
            this.Controls.SetChildIndex(fechPagoLabel, 0);
            this.Controls.SetChildIndex(conceptoLabel1, 0);
            this.Controls.SetChildIndex(this.conceptoComboBox, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MensualidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaFinalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaPreciosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource MensualidadesBindingSource;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private System.Windows.Forms.NumericUpDown gestionNumericUpDown;
        private System.Windows.Forms.ComboBox mesComboBox;
        private System.Windows.Forms.NumericUpDown cuotaFinalNumericUpDown;
        private System.Windows.Forms.BindingSource guiaPreciosBindingSource;
        private System.Windows.Forms.DateTimePicker fechPagoDateTimePicker;
        private System.Windows.Forms.ComboBox conceptoComboBox;
        private System.Windows.Forms.TextBox conceptoTextBox;
    }
}