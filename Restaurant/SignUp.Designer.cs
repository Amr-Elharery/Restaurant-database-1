namespace Restaurant
{
    partial class SignUp
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
            this.btnStaffSignUp = new System.Windows.Forms.Button();
            this.btnCustomerSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGoToLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStaffSignUp
            // 
            this.btnStaffSignUp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStaffSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSignUp.Location = new System.Drawing.Point(160, 143);
            this.btnStaffSignUp.Name = "btnStaffSignUp";
            this.btnStaffSignUp.Size = new System.Drawing.Size(232, 63);
            this.btnStaffSignUp.TabIndex = 0;
            this.btnStaffSignUp.Text = "Sign up as staff";
            this.btnStaffSignUp.UseVisualStyleBackColor = false;
            this.btnStaffSignUp.Click += new System.EventHandler(this.btnStaffSignUp_Click);
            // 
            // btnCustomerSignUp
            // 
            this.btnCustomerSignUp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCustomerSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSignUp.Location = new System.Drawing.Point(421, 143);
            this.btnCustomerSignUp.Name = "btnCustomerSignUp";
            this.btnCustomerSignUp.Size = new System.Drawing.Size(232, 63);
            this.btnCustomerSignUp.TabIndex = 1;
            this.btnCustomerSignUp.Text = "Sign up as customer";
            this.btnCustomerSignUp.UseVisualStyleBackColor = false;
            this.btnCustomerSignUp.Click += new System.EventHandler(this.btnCustomerSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select how would you sign up";
            // 
            // labelGoToLogin
            // 
            this.labelGoToLogin.AutoSize = true;
            this.labelGoToLogin.BackColor = System.Drawing.SystemColors.Control;
            this.labelGoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoToLogin.ForeColor = System.Drawing.Color.Gray;
            this.labelGoToLogin.Location = new System.Drawing.Point(309, 265);
            this.labelGoToLogin.Name = "labelGoToLogin";
            this.labelGoToLogin.Size = new System.Drawing.Size(197, 25);
            this.labelGoToLogin.TabIndex = 3;
            this.labelGoToLogin.Text = "Have acoount? Login";
            this.labelGoToLogin.Click += new System.EventHandler(this.labelGoToLogin_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 353);
            this.Controls.Add(this.labelGoToLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerSignUp);
            this.Controls.Add(this.btnStaffSignUp);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStaffSignUp;
        private System.Windows.Forms.Button btnCustomerSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGoToLogin;
    }
}