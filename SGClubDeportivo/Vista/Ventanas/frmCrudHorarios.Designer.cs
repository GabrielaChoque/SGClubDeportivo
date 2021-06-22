
namespace SGClubDeportivo.Vista.Ventanas
{
    partial class frmCrudHorarios
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
            System.Windows.Forms.Label ci_jugadorLabel;
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.linkLabelSalir = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.cmbCarnet = new System.Windows.Forms.ComboBox();
            this.PrimerDia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.diaUno = new System.Windows.Forms.Label();
            this.comboDia2 = new System.Windows.Forms.ComboBox();
            this.comboDia1 = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbHora2 = new System.Windows.Forms.ComboBox();
            this.diaDos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ci_jugadorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAceptar.IconColor = System.Drawing.Color.White;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 25;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(185, 360);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 32);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // linkLabelSalir
            // 
            this.linkLabelSalir.AutoSize = true;
            this.linkLabelSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSalir.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabelSalir.Location = new System.Drawing.Point(653, 9);
            this.linkLabelSalir.Name = "linkLabelSalir";
            this.linkLabelSalir.Size = new System.Drawing.Size(26, 25);
            this.linkLabelSalir.TabIndex = 32;
            this.linkLabelSalir.TabStop = true;
            this.linkLabelSalir.Text = "X";
            this.linkLabelSalir.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabelSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSalir_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 43);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.linkLabelSalir);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 43);
            this.panel2.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(452, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(26, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(109, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 31);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "HORARIO ACTUAL";
            // 
            // ci_jugadorLabel
            // 
            ci_jugadorLabel.AutoSize = true;
            ci_jugadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ci_jugadorLabel.Location = new System.Drawing.Point(304, 63);
            ci_jugadorLabel.Name = "ci_jugadorLabel";
            ci_jugadorLabel.Size = new System.Drawing.Size(114, 17);
            ci_jugadorLabel.TabIndex = 51;
            ci_jugadorLabel.Text = "NRO CARNET:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "NUM ENTRENAMIENTO";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "SUB 7",
            "SUB 9",
            "SUB 11",
            "SUB 13",
            "SUB 15",
            "SUB 17"});
            this.cmbCategoria.Location = new System.Drawing.Point(97, 92);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(119, 23);
            this.cmbCategoria.TabIndex = 50;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 360);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(130, 32);
            this.iconButton1.TabIndex = 55;
            this.iconButton1.Text = "HORARIOS";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(333, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 32);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cmbCarnet
            // 
            this.cmbCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarnet.FormattingEnabled = true;
            this.cmbCarnet.Items.AddRange(new object[] {
            "SUB 7",
            "SUB 9",
            "SUB 11",
            "SUB 13",
            "SUB 15",
            "SUB 17"});
            this.cmbCarnet.Location = new System.Drawing.Point(307, 92);
            this.cmbCarnet.Name = "cmbCarnet";
            this.cmbCarnet.Size = new System.Drawing.Size(119, 23);
            this.cmbCarnet.TabIndex = 56;
            // 
            // PrimerDia
            // 
            this.PrimerDia.AutoSize = true;
            this.PrimerDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimerDia.Location = new System.Drawing.Point(46, 153);
            this.PrimerDia.Name = "PrimerDia";
            this.PrimerDia.Size = new System.Drawing.Size(32, 17);
            this.PrimerDia.TabIndex = 57;
            this.PrimerDia.Text = "Dia";
            this.PrimerDia.Click += new System.EventHandler(this.PrimerDia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Dia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.diaDos);
            this.panel3.Controls.Add(this.diaUno);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 76);
            this.panel3.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(59, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "Dia 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(59, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "Dia 1:";
            // 
            // diaUno
            // 
            this.diaUno.AutoSize = true;
            this.diaUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.diaUno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diaUno.Location = new System.Drawing.Point(136, 9);
            this.diaUno.Name = "diaUno";
            this.diaUno.Size = new System.Drawing.Size(191, 24);
            this.diaUno.TabIndex = 61;
            this.diaUno.Text = "ENTRENAMIENTO 1";
            // 
            // comboDia2
            // 
            this.comboDia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDia2.FormattingEnabled = true;
            this.comboDia2.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES"});
            this.comboDia2.Location = new System.Drawing.Point(115, 186);
            this.comboDia2.Name = "comboDia2";
            this.comboDia2.Size = new System.Drawing.Size(119, 23);
            this.comboDia2.TabIndex = 60;
            // 
            // comboDia1
            // 
            this.comboDia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDia1.FormattingEnabled = true;
            this.comboDia1.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES"});
            this.comboDia1.Location = new System.Drawing.Point(115, 153);
            this.comboDia1.Name = "comboDia1";
            this.comboDia1.Size = new System.Drawing.Size(119, 23);
            this.comboDia1.TabIndex = 61;
            // 
            // cmbHora
            // 
            this.cmbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "9 ",
            "11",
            "14",
            "16"});
            this.cmbHora.Location = new System.Drawing.Point(333, 150);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(99, 23);
            this.cmbHora.TabIndex = 62;
            // 
            // cmbHora2
            // 
            this.cmbHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora2.FormattingEnabled = true;
            this.cmbHora2.Items.AddRange(new object[] {
            "9",
            "11",
            "14",
            "16"});
            this.cmbHora2.Location = new System.Drawing.Point(333, 186);
            this.cmbHora2.Name = "cmbHora2";
            this.cmbHora2.Size = new System.Drawing.Size(99, 23);
            this.cmbHora2.TabIndex = 63;
            // 
            // diaDos
            // 
            this.diaDos.AutoSize = true;
            this.diaDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.diaDos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diaDos.Location = new System.Drawing.Point(136, 41);
            this.diaDos.Name = "diaDos";
            this.diaDos.Size = new System.Drawing.Size(191, 24);
            this.diaDos.TabIndex = 62;
            this.diaDos.Text = "ENTRENAMIENTO 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Hora";
            // 
            // frmCrudHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(501, 404);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbHora2);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.comboDia1);
            this.Controls.Add(this.comboDia2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrimerDia);
            this.Controls.Add(this.cmbCarnet);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(ci_jugadorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrudHorarios";
            this.Text = "frmCrudHorarios";
            this.Load += new System.EventHandler(this.frmCrudHorarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.LinkLabel linkLabelSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.ComboBox cmbCarnet;
        private System.Windows.Forms.Label PrimerDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label diaUno;
        private System.Windows.Forms.Label diaDos;
        private System.Windows.Forms.ComboBox comboDia2;
        private System.Windows.Forms.ComboBox comboDia1;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbHora2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}