namespace SGClubDeportivo.Vista.Ventanas
{
    partial class frmCrudUsuarios
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
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label usernameLabel;
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.telefonoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            apellidosLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoNumericUpDown)).BeginInit();
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
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            apellidosLabel.Location = new System.Drawing.Point(170, 111);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 41;
            apellidosLabel.Text = "Apellidos:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nombresLabel.Location = new System.Drawing.Point(170, 137);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 43;
            nombresLabel.Text = "Nombres:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            passwordLabel.Location = new System.Drawing.Point(170, 163);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 45;
            passwordLabel.Text = "Password:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            rolLabel.Location = new System.Drawing.Point(170, 189);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(26, 13);
            rolLabel.TabIndex = 47;
            rolLabel.Text = "Rol:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            telefonoLabel.Location = new System.Drawing.Point(170, 213);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 49;
            telefonoLabel.Text = "Telefono:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            usernameLabel.Location = new System.Drawing.Point(170, 242);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 51;
            usernameLabel.Text = "Username:";
            // 
            // UsuariosBindingSource
            // 
            this.UsuariosBindingSource.DataSource = typeof(SGClubDeportivo.Data.Usuarios);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsuariosBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(234, 108);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(121, 20);
            this.apellidosTextBox.TabIndex = 42;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsuariosBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(234, 134);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombresTextBox.TabIndex = 44;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsuariosBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(234, 160);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 46;
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsuariosBindingSource, "Rol", true));
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Items.AddRange(new object[] {
            "ADMINISTRATIVO",
            "SECRETARIO"});
            this.rolComboBox.Location = new System.Drawing.Point(234, 186);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(121, 21);
            this.rolComboBox.TabIndex = 48;
            // 
            // telefonoNumericUpDown
            // 
            this.telefonoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.UsuariosBindingSource, "Telefono", true));
            this.telefonoNumericUpDown.Location = new System.Drawing.Point(234, 213);
            this.telefonoNumericUpDown.Name = "telefonoNumericUpDown";
            this.telefonoNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.telefonoNumericUpDown.TabIndex = 50;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsuariosBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(234, 239);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(121, 20);
            this.usernameTextBox.TabIndex = 52;
            // 
            // frmCrudUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 506);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(rolLabel);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoNumericUpDown);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "frmCrudUsuarios";
            this.Text = "frmCrudUsuarios";
            this.Load += new System.EventHandler(this.frmCrudUsuarios_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.usernameTextBox, 0);
            this.Controls.SetChildIndex(usernameLabel, 0);
            this.Controls.SetChildIndex(this.telefonoNumericUpDown, 0);
            this.Controls.SetChildIndex(telefonoLabel, 0);
            this.Controls.SetChildIndex(this.rolComboBox, 0);
            this.Controls.SetChildIndex(rolLabel, 0);
            this.Controls.SetChildIndex(this.passwordTextBox, 0);
            this.Controls.SetChildIndex(passwordLabel, 0);
            this.Controls.SetChildIndex(this.nombresTextBox, 0);
            this.Controls.SetChildIndex(nombresLabel, 0);
            this.Controls.SetChildIndex(this.apellidosTextBox, 0);
            this.Controls.SetChildIndex(apellidosLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.NumericUpDown telefonoNumericUpDown;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}