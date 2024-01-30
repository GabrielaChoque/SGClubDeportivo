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
            System.Windows.Forms.Label conceptoLabel;
            System.Windows.Forms.Label cuotaFinalLabel;
            System.Windows.Forms.Label conceptoLabel1;
            System.Windows.Forms.Label fechPagoLabel;
            this.MensualidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mesComboBox = new System.Windows.Forms.ComboBox();
            this.conceptoTextBox = new System.Windows.Forms.TextBox();
            this.cuotaFinalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.guiaPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.conceptoComboBox = new System.Windows.Forms.ComboBox();
            gestionLabel = new System.Windows.Forms.Label();
            mesLabel = new System.Windows.Forms.Label();
            conceptoLabel = new System.Windows.Forms.Label();
            cuotaFinalLabel = new System.Windows.Forms.Label();
            conceptoLabel1 = new System.Windows.Forms.Label();
            fechPagoLabel = new System.Windows.Forms.Label();
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
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gestionLabel
            // 
            gestionLabel.AutoSize = true;
            gestionLabel.Location = new System.Drawing.Point(135, 72);
            gestionLabel.Name = "gestionLabel";
            gestionLabel.Size = new System.Drawing.Size(46, 13);
            gestionLabel.TabIndex = 55;
            gestionLabel.Text = "Gestion:";
            // 
            // mesLabel
            // 
            mesLabel.AutoSize = true;
            mesLabel.Location = new System.Drawing.Point(141, 111);
            mesLabel.Name = "mesLabel";
            mesLabel.Size = new System.Drawing.Size(30, 13);
            mesLabel.TabIndex = 56;
            mesLabel.Text = "Mes:";
            // 
            // conceptoLabel
            // 
            conceptoLabel.AutoSize = true;
            conceptoLabel.Location = new System.Drawing.Point(81, 145);
            conceptoLabel.Name = "conceptoLabel";
            conceptoLabel.Size = new System.Drawing.Size(116, 13);
            conceptoLabel.TabIndex = 57;
            conceptoLabel.Text = "Concepto Mensualidad";
            // 
            // cuotaFinalLabel
            // 
            cuotaFinalLabel.AutoSize = true;
            cuotaFinalLabel.Location = new System.Drawing.Point(154, 173);
            cuotaFinalLabel.Name = "cuotaFinalLabel";
            cuotaFinalLabel.Size = new System.Drawing.Size(63, 13);
            cuotaFinalLabel.TabIndex = 58;
            cuotaFinalLabel.Text = "Cuota Final:";
            // 
            // conceptoLabel1
            // 
            conceptoLabel1.AutoSize = true;
            conceptoLabel1.Location = new System.Drawing.Point(113, 242);
            conceptoLabel1.Name = "conceptoLabel1";
            conceptoLabel1.Size = new System.Drawing.Size(84, 13);
            conceptoLabel1.TabIndex = 60;
            conceptoLabel1.Text = "Concepto Pago:";
            // 
            // fechPagoLabel
            // 
            fechPagoLabel.AutoSize = true;
            fechPagoLabel.Location = new System.Drawing.Point(153, 205);
            fechPagoLabel.Name = "fechPagoLabel";
            fechPagoLabel.Size = new System.Drawing.Size(62, 13);
            fechPagoLabel.TabIndex = 59;
            fechPagoLabel.Text = "Fech Pago:";
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
            this.gestionNumericUpDown.Location = new System.Drawing.Point(187, 72);
            this.gestionNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.gestionNumericUpDown.Name = "gestionNumericUpDown";
            this.gestionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.gestionNumericUpDown.TabIndex = 56;
            // 
            // mesComboBox
            // 
            this.mesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Mes", true));
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
            this.mesComboBox.Location = new System.Drawing.Point(177, 108);
            this.mesComboBox.Name = "mesComboBox";
            this.mesComboBox.Size = new System.Drawing.Size(121, 21);
            this.mesComboBox.TabIndex = 57;
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Concepto", true));
            this.conceptoTextBox.Location = new System.Drawing.Point(204, 138);
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(100, 20);
            this.conceptoTextBox.TabIndex = 58;
            // 
            // cuotaFinalNumericUpDown
            // 
            this.cuotaFinalNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MensualidadesBindingSource, "CuotaFinal", true));
            this.cuotaFinalNumericUpDown.Location = new System.Drawing.Point(223, 173);
            this.cuotaFinalNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cuotaFinalNumericUpDown.Name = "cuotaFinalNumericUpDown";
            this.cuotaFinalNumericUpDown.Size = new System.Drawing.Size(120, 20);
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
            this.fechPagoDateTimePicker.Location = new System.Drawing.Point(221, 201);
            this.fechPagoDateTimePicker.Name = "fechPagoDateTimePicker";
            this.fechPagoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechPagoDateTimePicker.TabIndex = 60;
            // 
            // conceptoComboBox
            // 
            this.conceptoComboBox.FormattingEnabled = true;
            this.conceptoComboBox.Location = new System.Drawing.Point(223, 242);
            this.conceptoComboBox.Name = "conceptoComboBox";
            this.conceptoComboBox.Size = new System.Drawing.Size(121, 21);
            this.conceptoComboBox.TabIndex = 61;
            this.conceptoComboBox.SelectedIndexChanged += new System.EventHandler(this.conceptoComboBox_SelectedIndexChanged);
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
            this.Name = "frmCrudMensualidades";
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
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.conceptoComboBox, 0);
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
        private System.Windows.Forms.TextBox conceptoTextBox;
        private System.Windows.Forms.NumericUpDown cuotaFinalNumericUpDown;
        private System.Windows.Forms.BindingSource guiaPreciosBindingSource;
        private System.Windows.Forms.DateTimePicker fechPagoDateTimePicker;
        private System.Windows.Forms.ComboBox conceptoComboBox;
    }
}