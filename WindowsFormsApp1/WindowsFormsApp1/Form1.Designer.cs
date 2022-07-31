namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtboxbankDatainfo = new System.Windows.Forms.GroupBox();
            this.groupboxbuttons = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtAccno = new System.Windows.Forms.Label();
            this.txtfirstName = new System.Windows.Forms.Label();
            this.txtlastName = new System.Windows.Forms.Label();
            this.txtinitialBal = new System.Windows.Forms.Label();
            this.txtaccount = new System.Windows.Forms.Label();
            this.btncreateAcc = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridAccountno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridfirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridviewlastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridviewcurrentBal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtboxbankDatainfo.SuspendLayout();
            this.groupboxbuttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxbankDatainfo
            // 
            this.txtboxbankDatainfo.BackColor = System.Drawing.SystemColors.Info;
            this.txtboxbankDatainfo.Controls.Add(this.txtaccount);
            this.txtboxbankDatainfo.Controls.Add(this.txtinitialBal);
            this.txtboxbankDatainfo.Controls.Add(this.txtlastName);
            this.txtboxbankDatainfo.Controls.Add(this.txtfirstName);
            this.txtboxbankDatainfo.Controls.Add(this.txtAccno);
            this.txtboxbankDatainfo.Controls.Add(this.textBox5);
            this.txtboxbankDatainfo.Controls.Add(this.textBox4);
            this.txtboxbankDatainfo.Controls.Add(this.textBox3);
            this.txtboxbankDatainfo.Controls.Add(this.textBox2);
            this.txtboxbankDatainfo.Controls.Add(this.textBox1);
            this.txtboxbankDatainfo.Location = new System.Drawing.Point(12, 12);
            this.txtboxbankDatainfo.Name = "txtboxbankDatainfo";
            this.txtboxbankDatainfo.Size = new System.Drawing.Size(712, 215);
            this.txtboxbankDatainfo.TabIndex = 0;
            this.txtboxbankDatainfo.TabStop = false;
            this.txtboxbankDatainfo.Text = "Bank Data Information";
            // 
            // groupboxbuttons
            // 
            this.groupboxbuttons.BackColor = System.Drawing.SystemColors.Info;
            this.groupboxbuttons.Controls.Add(this.btnTransfer);
            this.groupboxbuttons.Controls.Add(this.btnWithdraw);
            this.groupboxbuttons.Controls.Add(this.btnDeposit);
            this.groupboxbuttons.Controls.Add(this.btncreateAcc);
            this.groupboxbuttons.Location = new System.Drawing.Point(12, 177);
            this.groupboxbuttons.Name = "groupboxbuttons";
            this.groupboxbuttons.Size = new System.Drawing.Size(712, 62);
            this.groupboxbuttons.TabIndex = 1;
            this.groupboxbuttons.TabStop = false;
            this.groupboxbuttons.Enter += new System.EventHandler(this.groupboxbuttons_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 22);
            this.textBox5.TabIndex = 4;
            // 
            // txtAccno
            // 
            this.txtAccno.AutoSize = true;
            this.txtAccno.Location = new System.Drawing.Point(6, 27);
            this.txtAccno.Name = "txtAccno";
            this.txtAccno.Size = new System.Drawing.Size(79, 16);
            this.txtAccno.TabIndex = 5;
            this.txtAccno.Text = "Account No.";
            this.txtAccno.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtfirstName
            // 
            this.txtfirstName.AutoSize = true;
            this.txtfirstName.Location = new System.Drawing.Point(7, 56);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(72, 16);
            this.txtfirstName.TabIndex = 6;
            this.txtfirstName.Text = "FIrst Name";
            // 
            // txtlastName
            // 
            this.txtlastName.AutoSize = true;
            this.txtlastName.Location = new System.Drawing.Point(6, 85);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(72, 16);
            this.txtlastName.TabIndex = 7;
            this.txtlastName.Text = "Last Name";
            // 
            // txtinitialBal
            // 
            this.txtinitialBal.AutoSize = true;
            this.txtinitialBal.Location = new System.Drawing.Point(6, 114);
            this.txtinitialBal.Name = "txtinitialBal";
            this.txtinitialBal.Size = new System.Drawing.Size(90, 16);
            this.txtinitialBal.TabIndex = 8;
            this.txtinitialBal.Text = "Initial Balance";
            // 
            // txtaccount
            // 
            this.txtaccount.AutoSize = true;
            this.txtaccount.BackColor = System.Drawing.SystemColors.Info;
            this.txtaccount.Location = new System.Drawing.Point(7, 143);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(55, 16);
            this.txtaccount.TabIndex = 9;
            this.txtaccount.Text = "Account";
            // 
            // btncreateAcc
            // 
            this.btncreateAcc.Location = new System.Drawing.Point(117, 11);
            this.btncreateAcc.Name = "btncreateAcc";
            this.btncreateAcc.Size = new System.Drawing.Size(136, 29);
            this.btncreateAcc.TabIndex = 0;
            this.btncreateAcc.Text = "Create Account";
            this.btncreateAcc.UseVisualStyleBackColor = true;
            this.btncreateAcc.Click += new System.EventHandler(this.btncreateAcc_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(259, 11);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(105, 29);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposits";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(370, 11);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(105, 29);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(481, 11);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(98, 29);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridAccountno,
            this.gridfirstName,
            this.gridviewlastName,
            this.gridviewcurrentBal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 260);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gridAccountno
            // 
            this.gridAccountno.HeaderText = "Account No.";
            this.gridAccountno.MinimumWidth = 6;
            this.gridAccountno.Name = "gridAccountno";
            this.gridAccountno.Width = 125;
            // 
            // gridfirstName
            // 
            this.gridfirstName.HeaderText = "First Name";
            this.gridfirstName.MinimumWidth = 6;
            this.gridfirstName.Name = "gridfirstName";
            this.gridfirstName.Width = 125;
            // 
            // gridviewlastName
            // 
            this.gridviewlastName.HeaderText = "Last Name";
            this.gridviewlastName.MinimumWidth = 6;
            this.gridviewlastName.Name = "gridviewlastName";
            this.gridviewlastName.Width = 125;
            // 
            // gridviewcurrentBal
            // 
            this.gridviewcurrentBal.HeaderText = "Current Blance";
            this.gridviewcurrentBal.MinimumWidth = 6;
            this.gridviewcurrentBal.Name = "gridviewcurrentBal";
            this.gridviewcurrentBal.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupboxbuttons);
            this.Controls.Add(this.txtboxbankDatainfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.txtboxbankDatainfo.ResumeLayout(false);
            this.txtboxbankDatainfo.PerformLayout();
            this.groupboxbuttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtboxbankDatainfo;
        private System.Windows.Forms.Label txtfirstName;
        private System.Windows.Forms.Label txtAccno;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupboxbuttons;
        private System.Windows.Forms.Label txtaccount;
        private System.Windows.Forms.Label txtinitialBal;
        private System.Windows.Forms.Label txtlastName;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btncreateAcc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAccountno;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridfirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridviewlastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridviewcurrentBal;
    }
}

