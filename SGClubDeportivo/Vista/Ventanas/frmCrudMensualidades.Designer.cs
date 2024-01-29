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
            System.Windows.Forms.Label conceptoLabel;
            System.Windows.Forms.Label correlativoLabel;
            System.Windows.Forms.Label cuotaFinalLabel;
            System.Windows.Forms.Label cuotaRegularLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label gestionLabel;
            System.Windows.Forms.Label mesLabel;
            System.Windows.Forms.Label ci_jugadorLabel;
            this.MensualidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conceptoTextBox = new System.Windows.Forms.TextBox();
            this.correlativoTextBox = new System.Windows.Forms.TextBox();
            this.cuotaFinalTextBox = new System.Windows.Forms.TextBox();
            this.cuotaRegularTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.gestionTextBox = new System.Windows.Forms.TextBox();
            this.mesComboBox = new System.Windows.Forms.ComboBox();
            this.ci_jugadorComboBox = new System.Windows.Forms.ComboBox();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            conceptoLabel = new System.Windows.Forms.Label();
            correlativoLabel = new System.Windows.Forms.Label();
            cuotaFinalLabel = new System.Windows.Forms.Label();
            cuotaRegularLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            gestionLabel = new System.Windows.Forms.Label();
            mesLabel = new System.Windows.Forms.Label();
            ci_jugadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MensualidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
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
            // conceptoLabel
            // 
            conceptoLabel.AutoSize = true;
            conceptoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            conceptoLabel.Location = new System.Drawing.Point(105, 79);
            conceptoLabel.Name = "conceptoLabel";
            conceptoLabel.Size = new System.Drawing.Size(56, 13);
            conceptoLabel.TabIndex = 41;
            conceptoLabel.Text = "Concepto:";
            // 
            // correlativoLabel
            // 
            correlativoLabel.AutoSize = true;
            correlativoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            correlativoLabel.Location = new System.Drawing.Point(105, 105);
            correlativoLabel.Name = "correlativoLabel";
            correlativoLabel.Size = new System.Drawing.Size(60, 13);
            correlativoLabel.TabIndex = 43;
            correlativoLabel.Text = "Correlativo:";
            // 
            // cuotaFinalLabel
            // 
            cuotaFinalLabel.AutoSize = true;
            cuotaFinalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cuotaFinalLabel.Location = new System.Drawing.Point(105, 131);
            cuotaFinalLabel.Name = "cuotaFinalLabel";
            cuotaFinalLabel.Size = new System.Drawing.Size(63, 13);
            cuotaFinalLabel.TabIndex = 45;
            cuotaFinalLabel.Text = "Cuota Final:";
            // 
            // cuotaRegularLabel
            // 
            cuotaRegularLabel.AutoSize = true;
            cuotaRegularLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cuotaRegularLabel.Location = new System.Drawing.Point(105, 157);
            cuotaRegularLabel.Name = "cuotaRegularLabel";
            cuotaRegularLabel.Size = new System.Drawing.Size(78, 13);
            cuotaRegularLabel.TabIndex = 47;
            cuotaRegularLabel.Text = "Cuota Regular:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            descuentoLabel.Location = new System.Drawing.Point(105, 183);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(62, 13);
            descuentoLabel.TabIndex = 49;
            descuentoLabel.Text = "Descuento:";
            // 
            // gestionLabel
            // 
            gestionLabel.AutoSize = true;
            gestionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            gestionLabel.Location = new System.Drawing.Point(105, 209);
            gestionLabel.Name = "gestionLabel";
            gestionLabel.Size = new System.Drawing.Size(46, 13);
            gestionLabel.TabIndex = 51;
            gestionLabel.Text = "Gestion:";
            // 
            // mesLabel
            // 
            mesLabel.AutoSize = true;
            mesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            mesLabel.Location = new System.Drawing.Point(105, 235);
            mesLabel.Name = "mesLabel";
            mesLabel.Size = new System.Drawing.Size(30, 13);
            mesLabel.TabIndex = 53;
            mesLabel.Text = "Mes:";
            // 
            // ci_jugadorLabel
            // 
            ci_jugadorLabel.AutoSize = true;
            ci_jugadorLabel.Location = new System.Drawing.Point(115, 274);
            ci_jugadorLabel.Name = "ci_jugadorLabel";
            ci_jugadorLabel.Size = new System.Drawing.Size(57, 13);
            ci_jugadorLabel.TabIndex = 54;
            ci_jugadorLabel.Text = "Ci jugador:";
            // 
            // MensualidadesBindingSource
            // 
            this.MensualidadesBindingSource.DataSource = typeof(SGClubDeportivo.Data.Mensualidades);
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Concepto", true));
            this.conceptoTextBox.Location = new System.Drawing.Point(189, 76);
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(121, 20);
            this.conceptoTextBox.TabIndex = 42;
            // 
            // correlativoTextBox
            // 
            this.correlativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Correlativo", true));
            this.correlativoTextBox.Location = new System.Drawing.Point(189, 102);
            this.correlativoTextBox.Name = "correlativoTextBox";
            this.correlativoTextBox.Size = new System.Drawing.Size(121, 20);
            this.correlativoTextBox.TabIndex = 44;
            // 
            // cuotaFinalTextBox
            // 
            this.cuotaFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "CuotaFinal", true));
            this.cuotaFinalTextBox.Location = new System.Drawing.Point(189, 128);
            this.cuotaFinalTextBox.Name = "cuotaFinalTextBox";
            this.cuotaFinalTextBox.Size = new System.Drawing.Size(121, 20);
            this.cuotaFinalTextBox.TabIndex = 46;
            // 
            // cuotaRegularTextBox
            // 
            this.cuotaRegularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "CuotaRegular", true));
            this.cuotaRegularTextBox.Location = new System.Drawing.Point(189, 154);
            this.cuotaRegularTextBox.Name = "cuotaRegularTextBox";
            this.cuotaRegularTextBox.Size = new System.Drawing.Size(121, 20);
            this.cuotaRegularTextBox.TabIndex = 48;
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(189, 180);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(121, 20);
            this.descuentoTextBox.TabIndex = 50;
            // 
            // gestionTextBox
            // 
            this.gestionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Gestion", true));
            this.gestionTextBox.Location = new System.Drawing.Point(189, 206);
            this.gestionTextBox.Name = "gestionTextBox";
            this.gestionTextBox.Size = new System.Drawing.Size(121, 20);
            this.gestionTextBox.TabIndex = 52;
            // 
            // mesComboBox
            // 
            this.mesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Mes", true));
            this.mesComboBox.FormattingEnabled = true;
            this.mesComboBox.Location = new System.Drawing.Point(189, 232);
            this.mesComboBox.Name = "mesComboBox";
            this.mesComboBox.Size = new System.Drawing.Size(121, 21);
            this.mesComboBox.TabIndex = 54;
            // 
            // ci_jugadorComboBox
            // 
            this.ci_jugadorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MensualidadesBindingSource, "Inscripciones.Jugadores.Ci_jugador", true));
            this.ci_jugadorComboBox.DataSource = this.jugadoresBindingSource;
            this.ci_jugadorComboBox.DisplayMember = "Ci_jugador";
            this.ci_jugadorComboBox.FormattingEnabled = true;
            this.ci_jugadorComboBox.Location = new System.Drawing.Point(189, 271);
            this.ci_jugadorComboBox.Name = "ci_jugadorComboBox";
            this.ci_jugadorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ci_jugadorComboBox.TabIndex = 55;
            // 
            // jugadoresBindingSource
            // 
            this.jugadoresBindingSource.DataSource = typeof(SGClubDeportivo.Data.Jugadores);
            // 
            // frmCrudMensualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 501);
            this.Controls.Add(ci_jugadorLabel);
            this.Controls.Add(this.ci_jugadorComboBox);
            this.Controls.Add(conceptoLabel);
            this.Controls.Add(this.conceptoTextBox);
            this.Controls.Add(correlativoLabel);
            this.Controls.Add(this.correlativoTextBox);
            this.Controls.Add(cuotaFinalLabel);
            this.Controls.Add(this.cuotaFinalTextBox);
            this.Controls.Add(cuotaRegularLabel);
            this.Controls.Add(this.cuotaRegularTextBox);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(gestionLabel);
            this.Controls.Add(this.gestionTextBox);
            this.Controls.Add(mesLabel);
            this.Controls.Add(this.mesComboBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmCrudMensualidades";
            this.Text = "frmCrudMensualidades";
            this.Load += new System.EventHandler(this.frmCrudMensualidades_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.mesComboBox, 0);
            this.Controls.SetChildIndex(mesLabel, 0);
            this.Controls.SetChildIndex(this.gestionTextBox, 0);
            this.Controls.SetChildIndex(gestionLabel, 0);
            this.Controls.SetChildIndex(this.descuentoTextBox, 0);
            this.Controls.SetChildIndex(descuentoLabel, 0);
            this.Controls.SetChildIndex(this.cuotaRegularTextBox, 0);
            this.Controls.SetChildIndex(cuotaRegularLabel, 0);
            this.Controls.SetChildIndex(this.cuotaFinalTextBox, 0);
            this.Controls.SetChildIndex(cuotaFinalLabel, 0);
            this.Controls.SetChildIndex(this.correlativoTextBox, 0);
            this.Controls.SetChildIndex(correlativoLabel, 0);
            this.Controls.SetChildIndex(this.conceptoTextBox, 0);
            this.Controls.SetChildIndex(conceptoLabel, 0);
            this.Controls.SetChildIndex(this.ci_jugadorComboBox, 0);
            this.Controls.SetChildIndex(ci_jugadorLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MensualidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource MensualidadesBindingSource;
        private System.Windows.Forms.TextBox conceptoTextBox;
        private System.Windows.Forms.TextBox correlativoTextBox;
        private System.Windows.Forms.TextBox cuotaFinalTextBox;
        private System.Windows.Forms.TextBox cuotaRegularTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox gestionTextBox;
        private System.Windows.Forms.ComboBox mesComboBox;
        private System.Windows.Forms.ComboBox ci_jugadorComboBox;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
    }
}