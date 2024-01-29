namespace SGClubDeportivo.Vista.Ventanas
{
    partial class frmCrudGuiaPrecios
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
            System.Windows.Forms.Label precioLabel;
            this.GuiaPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conceptoTextBox = new System.Windows.Forms.TextBox();
            this.correlativoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            conceptoLabel = new System.Windows.Forms.Label();
            correlativoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GuiaPreciosBindingSource)).BeginInit();
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
            conceptoLabel.Location = new System.Drawing.Point(168, 128);
            conceptoLabel.Name = "conceptoLabel";
            conceptoLabel.Size = new System.Drawing.Size(56, 13);
            conceptoLabel.TabIndex = 41;
            conceptoLabel.Text = "Concepto:";
            // 
            // correlativoLabel
            // 
            correlativoLabel.AutoSize = true;
            correlativoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            correlativoLabel.Location = new System.Drawing.Point(168, 154);
            correlativoLabel.Name = "correlativoLabel";
            correlativoLabel.Size = new System.Drawing.Size(60, 13);
            correlativoLabel.TabIndex = 43;
            correlativoLabel.Text = "Correlativo:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            precioLabel.Location = new System.Drawing.Point(168, 180);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 45;
            precioLabel.Text = "Precio:";
            // 
            // GuiaPreciosBindingSource
            // 
            this.GuiaPreciosBindingSource.DataSource = typeof(SGClubDeportivo.Data.GuiaPrecios);
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuiaPreciosBindingSource, "Concepto", true));
            this.conceptoTextBox.Location = new System.Drawing.Point(234, 125);
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(100, 20);
            this.conceptoTextBox.TabIndex = 42;
            // 
            // correlativoTextBox
            // 
            this.correlativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuiaPreciosBindingSource, "Correlativo", true));
            this.correlativoTextBox.Location = new System.Drawing.Point(234, 151);
            this.correlativoTextBox.Name = "correlativoTextBox";
            this.correlativoTextBox.Size = new System.Drawing.Size(100, 20);
            this.correlativoTextBox.TabIndex = 44;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GuiaPreciosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(234, 177);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 46;
            // 
            // frmCrudGuiaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 506);
            this.Controls.Add(conceptoLabel);
            this.Controls.Add(this.conceptoTextBox);
            this.Controls.Add(correlativoLabel);
            this.Controls.Add(this.correlativoTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Name = "frmCrudGuiaPrecios";
            this.Text = "frmCrudGuiaPrecios";
            this.Load += new System.EventHandler(this.frmCrudGuiaPrecios_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.precioTextBox, 0);
            this.Controls.SetChildIndex(precioLabel, 0);
            this.Controls.SetChildIndex(this.correlativoTextBox, 0);
            this.Controls.SetChildIndex(correlativoLabel, 0);
            this.Controls.SetChildIndex(this.conceptoTextBox, 0);
            this.Controls.SetChildIndex(conceptoLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GuiaPreciosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource GuiaPreciosBindingSource;
        private System.Windows.Forms.TextBox conceptoTextBox;
        private System.Windows.Forms.TextBox correlativoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
    }
}