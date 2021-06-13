
namespace SGClubDeportivo.Views
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.MainTitle = new Guna.UI.WinForms.GunaGradientTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.MediumSpringGreen;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.Teal;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(590, 37);
            this.gunaGradientPanel1.TabIndex = 0;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // MainTitle
            // 
            this.MainTitle.AnimationHoverSpeed = 0.07F;
            this.MainTitle.AnimationSpeed = 0.03F;
            this.MainTitle.BackColor = System.Drawing.Color.Transparent;
            this.MainTitle.BaseColor1 = System.Drawing.Color.CornflowerBlue;
            this.MainTitle.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.MainTitle.BorderColor = System.Drawing.Color.DimGray;
            this.MainTitle.BorderSize = 2;
            this.MainTitle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTitle.FocusedColor = System.Drawing.Color.Empty;
            this.MainTitle.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.MainTitle.Image = ((System.Drawing.Image)(resources.GetObject("MainTitle.Image")));
            this.MainTitle.ImageSize = new System.Drawing.Size(32, 32);
            this.MainTitle.Location = new System.Drawing.Point(0, 0);
            this.MainTitle.Margin = new System.Windows.Forms.Padding(2);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.MainTitle.OnHoverBaseColor2 = System.Drawing.Color.Teal;
            this.MainTitle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MainTitle.OnHoverForeColor = System.Drawing.Color.White;
            this.MainTitle.OnHoverImage = null;
            this.MainTitle.OnPressedColor = System.Drawing.Color.Black;
            this.MainTitle.Radius = 4;
            this.MainTitle.Size = new System.Drawing.Size(241, 56);
            this.MainTitle.TabIndex = 1;
            this.MainTitle.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 413);
            this.panel1.TabIndex = 2;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton1.BackgroundImage")));
            this.gunaCircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaCircleButton1.Location = new System.Drawing.Point(548, 5);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(39, 32);
            this.gunaCircleButton1.TabIndex = 5;
            this.gunaCircleButton1.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMain";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientTileButton MainTitle;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        public Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
    }
}