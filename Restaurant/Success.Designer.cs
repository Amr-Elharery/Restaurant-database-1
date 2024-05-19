namespace Restaurant
{
    partial class Success
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(150, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 55);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ordered Successfully";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToHome.ForeColor = System.Drawing.Color.DimGray;
            this.btnGoToHome.Location = new System.Drawing.Point(306, 307);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Size = new System.Drawing.Size(165, 39);
            this.btnGoToHome.TabIndex = 55;
            this.btnGoToHome.Text = "Home";
            this.btnGoToHome.UseVisualStyleBackColor = false;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToHome);
            this.Controls.Add(this.label3);
            this.Name = "Success";
            this.Text = "Success";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoToHome;
    }
}