namespace Restaurant
{
    partial class Delivery
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
            this.dateReservation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateReservation
            // 
            this.dateReservation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateReservation.Location = new System.Drawing.Point(168, 110);
            this.dateReservation.Name = "dateReservation";
            this.dateReservation.Size = new System.Drawing.Size(236, 27);
            this.dateReservation.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(163, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "Delivery Date\r\n";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.DimGray;
            this.btnOrder.Location = new System.Drawing.Point(207, 169);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(152, 30);
            this.btnOrder.TabIndex = 54;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 287);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dateReservation);
            this.Controls.Add(this.label2);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrder;
    }
}