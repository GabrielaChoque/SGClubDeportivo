namespace SGClubDeportivo.Vista
{
    partial class frmGestiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiones));
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.panelBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(657, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 32);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(298, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "INICIO DE SESION";
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelBarraSuperior.Controls.Add(this.iconButton2);
            this.panelBarraSuperior.Controls.Add(this.label2);
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(800, 51);
            this.panelBarraSuperior.TabIndex = 59;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton2.IconColor = System.Drawing.Color.PeachPuff;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(760, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(37, 41);
            this.iconButton2.TabIndex = 40;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(225, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "GESTION";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(148, 57);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(503, 33);
            this.txtBuscar.TabIndex = 41;
            this.txtBuscar.text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Orange;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.Location = new System.Drawing.Point(29, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 33);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // frmGestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panelBarraSuperior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestiones";
            this.Text = "frmGestiones";
            this.panelBarraSuperior.ResumeLayout(false);
            this.panelBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBarraSuperior;
        private FontAwesome.Sharp.IconButton iconButton2;
        public System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        public FontAwesome.Sharp.IconButton btnAgregar;
    }
}