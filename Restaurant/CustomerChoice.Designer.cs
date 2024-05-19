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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 31);
            this.label3.TabIndex = 40;
            this.label3.Text = "How do you want to order?";
            // 
            // btnReservationChoice
            // 
            this.btnReservationChoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservationChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservationChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationChoice.ForeColor = System.Drawing.Color.DimGray;
            this.btnReservationChoice.Location = new System.Drawing.Point(447, 408);
            this.btnReservationChoice.Name = "btnReservationChoice";
            this.btnReservationChoice.Size = new System.Drawing.Size(152, 30);
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
            this.btnDeliveryChoice.Location = new System.Drawing.Point(204, 408);
            this.btnDeliveryChoice.Name = "btnDeliveryChoice";
            this.btnDeliveryChoice.Size = new System.Drawing.Size(152, 30);
            this.btnDeliveryChoice.TabIndex = 42;
            this.btnDeliveryChoice.Text = "Delivery";
            this.btnDeliveryChoice.UseVisualStyleBackColor = false;
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNumber.Location = new System.Drawing.Point(122, 322);
            this.txtUserNumber.Multiline = true;
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(255, 37);
            this.txtUserNumber.TabIndex = 43;
            // 
            // txtFood
            // 
            this.txtFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood.Location = new System.Drawing.Point(447, 322);
            this.txtFood.Multiline = true;
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(255, 37);
            this.txtFood.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(117, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(442, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "Food ";
            // 
            // CustomerChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.btnDeliveryChoice);
            this.Controls.Add(this.btnReservationChoice);
            this.Controls.Add(this.label3);
            this.Name = "CustomerChoice";
            this.Text = "CustomerChoice";
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
    }
}