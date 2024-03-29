﻿
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PannelMenu = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnCategorias = new FontAwesome.Sharp.IconButton();
            this.btnInscripciones = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnMensualidades = new FontAwesome.Sharp.IconButton();
            this.btnPagos = new FontAwesome.Sharp.IconButton();
            this.btnJugadores = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.btnCambioPassword = new FontAwesome.Sharp.IconButton();
            this.panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PannelMenu.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(333, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
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
            this.panelBarraSuperior.Size = new System.Drawing.Size(1076, 53);
            this.panelBarraSuperior.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(728, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
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
            this.iconButton1.Location = new System.Drawing.Point(1027, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 41);
            this.iconButton1.TabIndex = 40;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.PannelMenu.Size = new System.Drawing.Size(211, 652);
            this.PannelMenu.TabIndex = 37;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.btnCambioPassword);
            this.Sidebar.Controls.Add(this.btnUsuarios);
            this.Sidebar.Controls.Add(this.btnCategorias);
            this.Sidebar.Controls.Add(this.btnInscripciones);
            this.Sidebar.Controls.Add(this.btnSalir);
            this.Sidebar.Controls.Add(this.btnMensualidades);
            this.Sidebar.Controls.Add(this.btnPagos);
            this.Sidebar.Controls.Add(this.btnJugadores);
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
            this.Sidebar.Size = new System.Drawing.Size(206, 647);
            this.Sidebar.TabIndex = 2;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 30;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(7, 284);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(191, 38);
            this.btnUsuarios.TabIndex = 25;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnCategorias.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.btnCategorias.IconColor = System.Drawing.Color.Black;
            this.btnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategorias.IconSize = 30;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(7, 152);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(191, 38);
            this.btnCategorias.TabIndex = 24;
            this.btnCategorias.Text = "CATEGORIAS";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.BackColor = System.Drawing.Color.Transparent;
            this.btnInscripciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripciones.ForeColor = System.Drawing.Color.Black;
            this.btnInscripciones.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnInscripciones.IconColor = System.Drawing.Color.Black;
            this.btnInscripciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInscripciones.IconSize = 30;
            this.btnInscripciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripciones.Location = new System.Drawing.Point(0, 370);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(191, 38);
            this.btnInscripciones.TabIndex = 23;
            this.btnInscripciones.Text = "INSCRIPCIONES";
            this.btnInscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInscripciones.UseVisualStyleBackColor = false;
            this.btnInscripciones.Visible = false;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 597);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(191, 38);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "CERRAR SESION";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMensualidades
            // 
            this.btnMensualidades.BackColor = System.Drawing.Color.Transparent;
            this.btnMensualidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensualidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensualidades.ForeColor = System.Drawing.Color.Black;
            this.btnMensualidades.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnMensualidades.IconColor = System.Drawing.Color.Black;
            this.btnMensualidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMensualidades.IconSize = 30;
            this.btnMensualidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensualidades.Location = new System.Drawing.Point(7, 240);
            this.btnMensualidades.Name = "btnMensualidades";
            this.btnMensualidades.Size = new System.Drawing.Size(191, 38);
            this.btnMensualidades.TabIndex = 21;
            this.btnMensualidades.Text = "MENSUALIDADES";
            this.btnMensualidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensualidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMensualidades.UseVisualStyleBackColor = false;
            this.btnMensualidades.Click += new System.EventHandler(this.btnMensualidades_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.Transparent;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.Black;
            this.btnPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnPagos.IconColor = System.Drawing.Color.Black;
            this.btnPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagos.IconSize = 30;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(7, 196);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(191, 38);
            this.btnPagos.TabIndex = 18;
            this.btnPagos.Text = "GUIA DE PRECIOS";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click_1);
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackColor = System.Drawing.Color.Transparent;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.ForeColor = System.Drawing.Color.Black;
            this.btnJugadores.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.btnJugadores.IconColor = System.Drawing.Color.Black;
            this.btnJugadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJugadores.IconSize = 30;
            this.btnJugadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugadores.Location = new System.Drawing.Point(7, 108);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(191, 38);
            this.btnJugadores.TabIndex = 17;
            this.btnJugadores.Text = "JUGADORES";
            this.btnJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
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
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
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
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(211, 53);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(865, 652);
            this.PanelContenido.TabIndex = 38;
            // 
            // btnCambioPassword
            // 
            this.btnCambioPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnCambioPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioPassword.ForeColor = System.Drawing.Color.Black;
            this.btnCambioPassword.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.btnCambioPassword.IconColor = System.Drawing.Color.Black;
            this.btnCambioPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambioPassword.IconSize = 30;
            this.btnCambioPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambioPassword.Location = new System.Drawing.Point(0, 542);
            this.btnCambioPassword.Name = "btnCambioPassword";
            this.btnCambioPassword.Size = new System.Drawing.Size(191, 49);
            this.btnCambioPassword.TabIndex = 26;
            this.btnCambioPassword.Text = "CAMBIAR CONTRASEÑA";
            this.btnCambioPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambioPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambioPassword.UseVisualStyleBackColor = false;
            this.btnCambioPassword.Click += new System.EventHandler(this.btnCambioPassword_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1076, 705);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.PannelMenu);
            this.Controls.Add(this.panelBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.panelBarraSuperior.ResumeLayout(false);
            this.panelBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Panel PanelContenido;
        public FontAwesome.Sharp.IconButton btnMensualidades;
        public FontAwesome.Sharp.IconButton btnPagos;
        public FontAwesome.Sharp.IconButton btnJugadores;
        public FontAwesome.Sharp.IconButton btnInicio;
        public System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconButton btnSalir;
        public FontAwesome.Sharp.IconButton btnInscripciones;
        public FontAwesome.Sharp.IconButton btnCategorias;
        public FontAwesome.Sharp.IconButton btnUsuarios;
        public FontAwesome.Sharp.IconButton btnCambioPassword;
    }
}