namespace Restaurant
{
    partial class Table
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateReservation = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(79, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Reservation Date\r\n";
            // 
            // dateReservation
            // 
            this.dateReservation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateReservation.Location = new System.Drawing.Point(84, 212);
            this.dateReservation.Name = "dateReservation";
            this.dateReservation.Size = new System.Drawing.Size(236, 27);
            this.dateReservation.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 31);
            this.label3.TabIndex = 50;
            this.label3.Text = "Please fill data below";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Gray;
            this.label.Location = new System.Drawing.Point(451, 171);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(185, 26);
            this.label.TabIndex = 51;
            this.label.Text = "Number of people";
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfPeople.Location = new System.Drawing.Point(456, 212);
            this.txtNumberOfPeople.Multiline = true;
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(255, 37);
            this.txtNumberOfPeople.TabIndex = 52;
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.DimGray;
            this.btnReserve.Location = new System.Drawing.Point(305, 374);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(152, 30);
            this.btnReserve.TabIndex = 53;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateReservation);
            this.Controls.Add(this.label2);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.Button btnReserve;
    }
}