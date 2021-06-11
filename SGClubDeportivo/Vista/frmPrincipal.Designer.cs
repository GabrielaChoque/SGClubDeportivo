
namespace SGClubDeportivo.Vista
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PannelMenu = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMisEstudiantes = new FontAwesome.Sharp.IconButton();
            this.btnEstudiantes = new FontAwesome.Sharp.IconButton();
            this.btnPlantelDocente = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PannelMenu.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Regatto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(216, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLUB DEPORTIVO \"ORURO ROYAL\"";
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelBarraSuperior.Controls.Add(this.pictureBox2);
            this.panelBarraSuperior.Controls.Add(this.pictureBox1);
            this.panelBarraSuperior.Controls.Add(this.iconButton1);
            this.panelBarraSuperior.Controls.Add(this.label1);
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(838, 53);
            this.panelBarraSuperior.TabIndex = 36;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton1.IconColor = System.Drawing.Color.LightCoral;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(789, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 41);
            this.iconButton1.TabIndex = 40;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(611, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.panelBarraSuperior;
            this.MoverDashboard.Vertical = true;
            // 
            // PannelMenu
            // 
            this.PannelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.PannelMenu.Controls.Add(this.Sidebar);
            this.PannelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PannelMenu.Location = new System.Drawing.Point(0, 53);
            this.PannelMenu.Name = "PannelMenu";
            this.PannelMenu.Size = new System.Drawing.Size(233, 444);
            this.PannelMenu.TabIndex = 37;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.iconButton2);
            this.Sidebar.Controls.Add(this.btnMisEstudiantes);
            this.Sidebar.Controls.Add(this.btnEstudiantes);
            this.Sidebar.Controls.Add(this.btnPlantelDocente);
            this.Sidebar.Controls.Add(this.btnInicio);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.LightCyan;
            this.Sidebar.GradientTopRight = System.Drawing.Color.Black;
            this.Sidebar.Location = new System.Drawing.Point(5, 5);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(218, 426);
            this.Sidebar.TabIndex = 2;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // btnMisEstudiantes
            // 
            this.btnMisEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnMisEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.btnMisEstudiantes.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnMisEstudiantes.IconColor = System.Drawing.Color.Black;
            this.btnMisEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMisEstudiantes.IconSize = 30;
            this.btnMisEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisEstudiantes.Location = new System.Drawing.Point(7, 152);
            this.btnMisEstudiantes.Name = "btnMisEstudiantes";
            this.btnMisEstudiantes.Size = new System.Drawing.Size(191, 38);
            this.btnMisEstudiantes.TabIndex = 21;
            this.btnMisEstudiantes.Text = "MESUALIDADES";
            this.btnMisEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMisEstudiantes.UseVisualStyleBackColor = false;
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.btnEstudiantes.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnEstudiantes.IconColor = System.Drawing.Color.Black;
            this.btnEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstudiantes.IconSize = 30;
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Location = new System.Drawing.Point(7, 196);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(191, 38);
            this.btnEstudiantes.TabIndex = 18;
            this.btnEstudiantes.Text = "PAGOS";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnPlantelDocente
            // 
            this.btnPlantelDocente.BackColor = System.Drawing.Color.Transparent;
            this.btnPlantelDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantelDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantelDocente.ForeColor = System.Drawing.Color.Black;
            this.btnPlantelDocente.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.btnPlantelDocente.IconColor = System.Drawing.Color.Black;
            this.btnPlantelDocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlantelDocente.IconSize = 30;
            this.btnPlantelDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlantelDocente.Location = new System.Drawing.Point(7, 108);
            this.btnPlantelDocente.Name = "btnPlantelDocente";
            this.btnPlantelDocente.Size = new System.Drawing.Size(191, 38);
            this.btnPlantelDocente.TabIndex = 17;
            this.btnPlantelDocente.Text = "JUGADORES";
            this.btnPlantelDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlantelDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlantelDocente.UseVisualStyleBackColor = false;
            this.btnPlantelDocente.Click += new System.EventHandler(this.btnPlantelDocente_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Black;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.Black;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 30;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(7, 64);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(191, 38);
            this.btnInicio.TabIndex = 15;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 46);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(198, 12);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENU";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(7, 240);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(191, 38);
            this.iconButton2.TabIndex = 22;
            this.iconButton2.Text = "CERRAR SESION";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(233, 53);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(605, 444);
            this.PanelContenido.TabIndex = 38;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(838, 497);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.PannelMenu);
            this.Controls.Add(this.panelBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.panelBarraSuperior.ResumeLayout(false);
            this.panelBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PannelMenu.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBarraSuperior;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Panel PannelMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private FontAwesome.Sharp.IconButton btnMisEstudiantes;
        private FontAwesome.Sharp.IconButton btnEstudiantes;
        private FontAwesome.Sharp.IconButton btnPlantelDocente;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel PanelContenido;
    }
}