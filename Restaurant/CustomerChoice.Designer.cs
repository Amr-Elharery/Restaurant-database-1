namespace Restaurant
{
    partial class CustomerChoice
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
            this.btnReservationChoice = new System.Windows.Forms.Button();
            this.btnDeliveryChoice = new System.Windows.Forms.Button();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 38);
            this.label3.TabIndex = 40;
            this.label3.Text = "How do you want to order?";
            // 
            // btnReservationChoice
            // 
            this.btnReservationChoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservationChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservationChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationChoice.ForeColor = System.Drawing.Color.DimGray;
            this.btnReservationChoice.Location = new System.Drawing.Point(619, 504);
            this.btnReservationChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservationChoice.Name = "btnReservationChoice";
            this.btnReservationChoice.Size = new System.Drawing.Size(203, 37);
            this.btnReservationChoice.TabIndex = 41;
            this.btnReservationChoice.Text = "Table";
            this.btnReservationChoice.UseVisualStyleBackColor = false;
            // 
            // btnDeliveryChoice
            // 
            this.btnDeliveryChoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeliveryChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliveryChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryChoice.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeliveryChoice.Location = new System.Drawing.Point(296, 504);
            this.btnDeliveryChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeliveryChoice.Name = "btnDeliveryChoice";
            this.btnDeliveryChoice.Size = new System.Drawing.Size(203, 37);
            this.btnDeliveryChoice.TabIndex = 42;
            this.btnDeliveryChoice.Text = "Delivery";
            this.btnDeliveryChoice.UseVisualStyleBackColor = false;
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNumber.Location = new System.Drawing.Point(169, 412);
            this.txtUserNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserNumber.Multiline = true;
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(339, 45);
            this.txtUserNumber.TabIndex = 43;
            // 
            // txtFood
            // 
            this.txtFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood.Location = new System.Drawing.Point(602, 412);
            this.txtFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFood.Multiline = true;
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(339, 45);
            this.txtFood.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(162, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Customer Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(595, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Food ";
            // 
            // dataMenu
            // 
            this.dataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenu.Location = new System.Drawing.Point(140, 107);
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.RowHeadersWidth = 51;
            this.dataMenu.RowTemplate.Height = 24;
            this.dataMenu.Size = new System.Drawing.Size(758, 219);
            this.dataMenu.TabIndex = 47;
            // 
            // CustomerChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.btnDeliveryChoice);
            this.Controls.Add(this.btnReservationChoice);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerChoice";
            this.Text = "CustomerChoice";
            this.Load += new System.EventHandler(this.CustomerChoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReservationChoice;
        private System.Windows.Forms.Button btnDeliveryChoice;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataMenu;
    }
}