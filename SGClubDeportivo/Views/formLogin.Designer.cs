
namespace SGClubDeportivo.Views
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PanelTitle = new Guna.UI.WinForms.GunaPanel();
            this.titleApp = new Guna.UI.WinForms.GunaLabel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Banner = new Guna.UI.WinForms.GunaPanel();
            this.LoginPanel = new Guna.UI.WinForms.GunaPanel();
            this.btnLogin = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUser = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.Teal;
            this.PanelTitle.Controls.Add(this.titleApp);
            this.PanelTitle.Controls.Add(this.gunaCircleButton1);
            this.PanelTitle.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.PanelTitle, "PanelTitle");
            this.PanelTitle.Name = "PanelTitle";
            // 
            // titleApp
            // 
            this.titleApp.AutoEllipsis = true;
            resources.ApplyResources(this.titleApp, "titleApp");
            this.titleApp.Name = "titleApp";
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.gunaCircleButton1, "gunaCircleButton1");
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.Banner, "Banner");
            this.Banner.Name = "Banner";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.gunaCirclePictureBox2);
            this.LoginPanel.Controls.Add(this.gunaCirclePictureBox1);
            this.LoginPanel.Controls.Add(this.txtPassword);
            this.LoginPanel.Controls.Add(this.txtUser);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.gunaSeparator1);
            resources.ApplyResources(this.LoginPanel, "LoginPanel");
            this.LoginPanel.Name = "LoginPanel";
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor1 = System.Drawing.Color.Teal;
            this.btnLogin.BaseColor2 = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor1 = System.Drawing.Color.DarkCyan;
            this.btnLogin.OnHoverBaseColor2 = System.Drawing.Color.MediumTurquoise;
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Radius = 12;
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.gunaCirclePictureBox2, "gunaCirclePictureBox2");
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.gunaCirclePictureBox1, "gunaCirclePictureBox1");
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.MediumAquamarine;
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 10;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BaseColor = System.Drawing.Color.White;
            this.txtUser.BorderColor = System.Drawing.Color.Silver;
            this.txtUser.BorderSize = 3;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUser.FocusedBorderColor = System.Drawing.Color.MediumAquamarine;
            this.txtUser.FocusedForeColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.Radius = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.gunaSeparator1, "gunaSeparator1");
            this.gunaSeparator1.Name = "gunaSeparator1";
            // 
            // formLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.PanelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaElipse gunaElipse1;
        public Guna.UI.WinForms.GunaPanel PanelTitle;
        public Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        public Guna.UI.WinForms.GunaGradientButton btnLogin;
        public Guna.UI.WinForms.GunaPanel LoginPanel;
        public Guna.UI.WinForms.GunaPanel Banner;
        public System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        public Guna.UI.WinForms.GunaTextBox txtPassword;
        public Guna.UI.WinForms.GunaTextBox txtUser;
        public System.Windows.Forms.PictureBox pictureBox3;
        public Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        public Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaLabel titleApp;
    }
}