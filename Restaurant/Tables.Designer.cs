namespace Restaurant
{
    partial class Tables
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataTables = new System.Windows.Forms.DataGridView();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBackToAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 69);
            this.label1.TabIndex = 47;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(326, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 46);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tables";
            // 
            // dataTables
            // 
            this.dataTables.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTables.Location = new System.Drawing.Point(12, 136);
            this.dataTables.Name = "dataTables";
            this.dataTables.RowHeadersWidth = 51;
            this.dataTables.RowTemplate.Height = 24;
            this.dataTables.Size = new System.Drawing.Size(749, 196);
            this.dataTables.TabIndex = 49;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTable.Location = new System.Drawing.Point(470, 386);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(106, 38);
            this.btnDeleteTable.TabIndex = 50;
            this.btnDeleteTable.Text = "Delete";
            this.btnDeleteTable.UseVisualStyleBackColor = false;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // txtTableId
            // 
            this.txtTableId.Location = new System.Drawing.Point(229, 386);
            this.txtTableId.Multiline = true;
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(172, 38);
            this.txtTableId.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(223, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 52;
            this.label3.Text = "Table ID";
            // 
            // labelBackToAdmin
            // 
            this.labelBackToAdmin.AutoSize = true;
            this.labelBackToAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackToAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBackToAdmin.Location = new System.Drawing.Point(21, 20);
            this.labelBackToAdmin.Name = "labelBackToAdmin";
            this.labelBackToAdmin.Size = new System.Drawing.Size(118, 20);
            this.labelBackToAdmin.TabIndex = 68;
            this.labelBackToAdmin.Text = "Back to Admin";
            this.labelBackToAdmin.Click += new System.EventHandler(this.labelBackToAdmin_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBackToAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableId);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.dataTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.Tables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataTables;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.TextBox txtTableId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBackToAdmin;
    }
}