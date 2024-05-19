namespace Restaurant
{
    partial class Admin
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
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.btnGoToTable = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGoToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToMenu.ForeColor = System.Drawing.Color.Black;
            this.btnGoToMenu.Location = new System.Drawing.Point(302, 241);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(182, 53);
            this.btnGoToMenu.TabIndex = 42;
            this.btnGoToMenu.Text = "Menus";
            this.btnGoToMenu.UseVisualStyleBackColor = false;
            // 
            // btnGoToTable
            // 
            this.btnGoToTable.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGoToTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToTable.ForeColor = System.Drawing.Color.Black;
            this.btnGoToTable.Location = new System.Drawing.Point(302, 169);
            this.btnGoToTable.Name = "btnGoToTable";
            this.btnGoToTable.Size = new System.Drawing.Size(182, 53);
            this.btnGoToTable.TabIndex = 43;
            this.btnGoToTable.Text = "Tables";
            this.btnGoToTable.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Location = new System.Drawing.Point(302, 317);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(182, 53);
            this.btnCustomers.TabIndex = 44;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(211, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 93);
            this.label3.TabIndex = 45;
            this.label3.Text = "       How are you, admin\r\n\r\nwhat do you want to do today?";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnGoToTable);
            this.Controls.Add(this.btnGoToMenu);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToMenu;
        private System.Windows.Forms.Button btnGoToTable;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Label label3;
    }
}