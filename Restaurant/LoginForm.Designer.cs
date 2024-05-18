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
            this.label1 = new System.Windows.Forms.Label();
            this.labelGoToSignUp = new System.Windows.Forms.Label();
            this.chBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.Location = new System.Drawing.Point(526, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.Gray;
            this.labelUserID.Location = new System.Drawing.Point(523, 23);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(107, 32);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "User ID";
            // 
            // txtUserIDSignUp
            // 
            this.txtUserIDSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserIDSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserIDSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIDSignUp.Location = new System.Drawing.Point(526, 60);
            this.txtUserIDSignUp.Multiline = true;
            this.txtUserIDSignUp.Name = "txtUserIDSignUp";
            this.txtUserIDSignUp.Size = new System.Drawing.Size(255, 37);
            this.txtUserIDSignUp.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Gray;
            this.labelPassword.Location = new System.Drawing.Point(520, 109);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(138, 32);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.Location = new System.Drawing.Point(526, 144);
            this.txtPasswordSignUp.Multiline = true;
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.PasswordChar = '*';
            this.txtPasswordSignUp.Size = new System.Drawing.Size(255, 36);
            this.txtPasswordSignUp.TabIndex = 4;
            // 
            // chBoxStaff
            // 
            this.chBoxStaff.AutoSize = true;
            this.chBoxStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxStaff.ForeColor = System.Drawing.Color.Gray;
            this.chBoxStaff.Location = new System.Drawing.Point(686, 195);
            this.chBoxStaff.Name = "chBoxStaff";
            this.chBoxStaff.Size = new System.Drawing.Size(95, 36);
            this.chBoxStaff.TabIndex = 5;
            this.chBoxStaff.Text = "Staff";
            this.chBoxStaff.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 108);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welecome to our reastaurant\r\n\r\nplease login here";
            // 
            // labelGoToSignUp
            // 
            this.labelGoToSignUp.AutoSize = true;
            this.labelGoToSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoToSignUp.ForeColor = System.Drawing.Color.Gray;
            this.labelGoToSignUp.Location = new System.Drawing.Point(36, 195);
            this.labelGoToSignUp.Name = "labelGoToSignUp";
            this.labelGoToSignUp.Size = new System.Drawing.Size(253, 25);
            this.labelGoToSignUp.TabIndex = 7;
            this.labelGoToSignUp.Text = "Dont have account? Signup";
            this.labelGoToSignUp.Click += new System.EventHandler(this.labelGoToSignUp_Click);
            // 
            // chBoxShowPassword
            // 
            this.chBoxShowPassword.AutoSize = true;
            this.chBoxShowPassword.Location = new System.Drawing.Point(750, 155);
            this.chBoxShowPassword.Name = "chBoxShowPassword";
            this.chBoxShowPassword.Size = new System.Drawing.Size(18, 17);
            this.chBoxShowPassword.TabIndex = 8;
            this.chBoxShowPassword.UseVisualStyleBackColor = true;
            this.chBoxShowPassword.CheckedChanged += new System.EventHandler(this.chBoxShowPassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(887, 253);
            this.Controls.Add(this.chBoxShowPassword);
            this.Controls.Add(this.labelGoToSignUp);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGoToSignUp;
        private System.Windows.Forms.CheckBox chBoxShowPassword;
    }
}

