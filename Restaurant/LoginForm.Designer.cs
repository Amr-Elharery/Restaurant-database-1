namespace Restaurant
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelUserID = new System.Windows.Forms.Label();
            this.txtUserIDSignUp = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.chBoxStaff = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(354, 171);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(351, 37);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(52, 16);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "User ID";
            // 
            // txtUserIDSignUp
            // 
            this.txtUserIDSignUp.Location = new System.Drawing.Point(354, 56);
            this.txtUserIDSignUp.Name = "txtUserIDSignUp";
            this.txtUserIDSignUp.Size = new System.Drawing.Size(255, 22);
            this.txtUserIDSignUp.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(351, 114);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(133, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password or Number";
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Location = new System.Drawing.Point(354, 133);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.Size = new System.Drawing.Size(255, 22);
            this.txtPasswordSignUp.TabIndex = 4;
            // 
            // chBoxStaff
            // 
            this.chBoxStaff.AutoSize = true;
            this.chBoxStaff.Location = new System.Drawing.Point(539, 182);
            this.chBoxStaff.Name = "chBoxStaff";
            this.chBoxStaff.Size = new System.Drawing.Size(55, 20);
            this.chBoxStaff.TabIndex = 5;
            this.chBoxStaff.Text = "Staff";
            this.chBoxStaff.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(887, 253);
            this.Controls.Add(this.chBoxStaff);
            this.Controls.Add(this.txtPasswordSignUp);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtUserIDSignUp);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.TextBox txtUserIDSignUp;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.CheckBox chBoxStaff;
    }
}

