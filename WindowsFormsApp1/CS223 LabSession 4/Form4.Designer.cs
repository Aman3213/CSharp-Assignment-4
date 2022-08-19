namespace CS223_LabSession_4
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_indicator = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carD21 = new CS223_LabSession_4.CARD2();
            this.card1 = new CS223_LabSession_4.Card();
            this.card2 = new CS223_LabSession_4.Card();
            this.card3 = new CS223_LabSession_4.Card();
            this.card4 = new CS223_LabSession_4.Card();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.Pnl_indicator);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 558);
            this.panel1.TabIndex = 0;
            // 
            // Pnl_indicator
            // 
            this.Pnl_indicator.BackColor = System.Drawing.Color.Thistle;
            this.Pnl_indicator.Location = new System.Drawing.Point(49, 76);
            this.Pnl_indicator.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_indicator.Name = "Pnl_indicator";
            this.Pnl_indicator.Size = new System.Drawing.Size(13, 36);
            this.Pnl_indicator.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign Out";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Users";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.card4);
            this.panel2.Controls.Add(this.card3);
            this.panel2.Controls.Add(this.card2);
            this.panel2.Controls.Add(this.card1);
            this.panel2.Controls.Add(this.carD21);
            this.panel2.Location = new System.Drawing.Point(332, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 554);
            this.panel2.TabIndex = 1;
            // 
            // carD21
            // 
            this.carD21.Font = new System.Drawing.Font("Webdings", 8.25F);
            this.carD21.ItemName = "Sunflower Oil";
            this.carD21.Location = new System.Drawing.Point(10, 4);
            this.carD21.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.carD21.Name = "carD21";
            this.carD21.Price = 1050.99D;
            this.carD21.Size = new System.Drawing.Size(291, 112);
            this.carD21.TabIndex = 0;
            this.carD21.Load += new System.EventHandler(this.carD21_Load);
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(10, 115);
            this.card1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.card1.Name = "card1";
            this.card1.ProductNames = null;
            this.card1.Size = new System.Drawing.Size(296, 185);
            this.card1.TabIndex = 1;
            this.card1.Load += new System.EventHandler(this.card1_Load);
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(10, 308);
            this.card2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.card2.Name = "card2";
            this.card2.ProductNames = null;
            this.card2.Size = new System.Drawing.Size(296, 185);
            this.card2.TabIndex = 2;
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(380, 115);
            this.card3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.card3.Name = "card3";
            this.card3.ProductNames = null;
            this.card3.Size = new System.Drawing.Size(296, 185);
            this.card3.TabIndex = 3;
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(380, 308);
            this.card4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.card4.Name = "card4";
            this.card4.ProductNames = null;
            this.card4.Size = new System.Drawing.Size(296, 185);
            this.card4.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Pnl_indicator;
        private CARD2 carD21;
        private Card card4;
        private Card card3;
        private Card card2;
        private Card card1;
    }
}