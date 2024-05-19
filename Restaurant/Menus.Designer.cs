namespace Restaurant
{
    partial class Menus
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
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.dataMenus = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.labelBackToAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenus)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(45, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 58;
            this.label3.Text = "Food ID";
            // 
            // txtFoodId
            // 
            this.txtFoodId.Location = new System.Drawing.Point(51, 390);
            this.txtFoodId.Multiline = true;
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(172, 38);
            this.txtFoodId.TabIndex = 57;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteFood.Location = new System.Drawing.Point(277, 390);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(106, 38);
            this.btnDeleteFood.TabIndex = 56;
            this.btnDeleteFood.Text = "Delete";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // dataMenus
            // 
            this.dataMenus.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenus.Location = new System.Drawing.Point(26, 145);
            this.dataMenus.Name = "dataMenus";
            this.dataMenus.RowHeadersWidth = 51;
            this.dataMenus.RowTemplate.Height = 24;
            this.dataMenus.Size = new System.Drawing.Size(749, 196);
            this.dataMenus.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(340, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 46);
            this.label2.TabIndex = 54;
            this.label2.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(291, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 69);
            this.label1.TabIndex = 53;
            this.label1.Text = "ADMIN";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.Location = new System.Drawing.Point(611, 390);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(106, 38);
            this.btnAddItem.TabIndex = 59;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // labelBackToAdmin
            // 
            this.labelBackToAdmin.AutoSize = true;
            this.labelBackToAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackToAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBackToAdmin.Location = new System.Drawing.Point(22, 18);
            this.labelBackToAdmin.Name = "labelBackToAdmin";
            this.labelBackToAdmin.Size = new System.Drawing.Size(118, 20);
            this.labelBackToAdmin.TabIndex = 68;
            this.labelBackToAdmin.Text = "Back to Admin";
            this.labelBackToAdmin.Click += new System.EventHandler(this.labelBackToAdmin_Click);
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBackToAdmin);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoodId);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.dataMenus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menus";
            this.Text = "Menus";
            this.Load += new System.EventHandler(this.Menus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.DataGridView dataMenus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label labelBackToAdmin;
    }
}