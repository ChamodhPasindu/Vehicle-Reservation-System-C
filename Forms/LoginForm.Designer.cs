namespace ABCTradersApp
{
    partial class LoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(90, 116);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(90, 185);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(90, 142);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(90, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.cmbRole.Location = new System.Drawing.Point(90, 252);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(234, 24);
            this.cmbRole.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(90, 362);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(234, 39);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(430, 563);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

