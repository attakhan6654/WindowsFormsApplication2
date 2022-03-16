namespace WindowsFormsApplication2
{
    partial class Contractor
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
            this.button3 = new System.Windows.Forms.Button();
            this.Insertinsqltable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdealamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcontractorid = new System.Windows.Forms.TextBox();
            this.bttn4 = new System.Windows.Forms.Button();
            this.txtcontractorname = new System.Windows.Forms.TextBox();
            this.ProdGV = new System.Windows.Forms.DataGridView();
            this.ContractorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontractoraddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(41, 65);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 41);
            this.button3.TabIndex = 98;
            this.button3.Text = "Cash In";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Insertinsqltable
            // 
            this.Insertinsqltable.BackColor = System.Drawing.Color.MediumBlue;
            this.Insertinsqltable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Insertinsqltable.Location = new System.Drawing.Point(647, 470);
            this.Insertinsqltable.Name = "Insertinsqltable";
            this.Insertinsqltable.Size = new System.Drawing.Size(110, 45);
            this.Insertinsqltable.TabIndex = 150;
            this.Insertinsqltable.Text = "Insert in sql table";
            this.Insertinsqltable.UseVisualStyleBackColor = false;
            this.Insertinsqltable.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(774, 389);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(605, 202);
            this.dataGridView1.TabIndex = 149;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(375, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 135;
            this.label1.Text = "Contractor Id:";
            this.label1.Visible = false;
            // 
            // txtdealamount
            // 
            this.txtdealamount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdealamount.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdealamount.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtdealamount.Location = new System.Drawing.Point(585, 430);
            this.txtdealamount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdealamount.Name = "txtdealamount";
            this.txtdealamount.Size = new System.Drawing.Size(172, 32);
            this.txtdealamount.TabIndex = 144;
            this.txtdealamount.TextChanged += new System.EventHandler(this.validateTextInteger);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(379, 431);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 31);
            this.label5.TabIndex = 136;
            this.label5.Text = "Deal Amount:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(41, 116);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(296, 41);
            this.button5.TabIndex = 100;
            this.button5.Text = "Customer";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(1326, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 148;
            this.label2.Text = "Investers List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(375, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 31);
            this.label6.TabIndex = 137;
            this.label6.Text = "Cont  Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(379, 349);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 31);
            this.label8.TabIndex = 138;
            this.label8.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(440, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = " Manage Contractor";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(98, 626);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 54);
            this.button2.TabIndex = 102;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtcontractorid
            // 
            this.txtcontractorid.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcontractorid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontractorid.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcontractorid.Location = new System.Drawing.Point(585, 161);
            this.txtcontractorid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontractorid.Name = "txtcontractorid";
            this.txtcontractorid.Size = new System.Drawing.Size(172, 32);
            this.txtcontractorid.TabIndex = 139;
            this.txtcontractorid.Visible = false;
            this.txtcontractorid.TextChanged += new System.EventHandler(this.validateTextInteger);
            // 
            // bttn4
            // 
            this.bttn4.BackColor = System.Drawing.Color.MidnightBlue;
            this.bttn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn4.ForeColor = System.Drawing.Color.Coral;
            this.bttn4.Location = new System.Drawing.Point(619, 532);
            this.bttn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(138, 54);
            this.bttn4.TabIndex = 146;
            this.bttn4.Text = "DELETE";
            this.bttn4.UseVisualStyleBackColor = false;
            this.bttn4.Click += new System.EventHandler(this.bttn4_Click);
            // 
            // txtcontractorname
            // 
            this.txtcontractorname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcontractorname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontractorname.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcontractorname.Location = new System.Drawing.Point(585, 245);
            this.txtcontractorname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontractorname.Name = "txtcontractorname";
            this.txtcontractorname.Size = new System.Drawing.Size(172, 32);
            this.txtcontractorname.TabIndex = 142;
            this.txtcontractorname.TextChanged += new System.EventHandler(this.validateTextCharacter);
            // 
            // ProdGV
            // 
            this.ProdGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ProdGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractorID,
            this.ContName,
            this.ContAddress,
            this.ContPhone,
            this.MSG});
            this.ProdGV.Location = new System.Drawing.Point(774, 167);
            this.ProdGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdGV.Name = "ProdGV";
            this.ProdGV.RowHeadersWidth = 62;
            this.ProdGV.Size = new System.Drawing.Size(605, 202);
            this.ProdGV.TabIndex = 143;
            this.ProdGV.Visible = false;
            // 
            // ContractorID
            // 
            this.ContractorID.HeaderText = "ContractorID";
            this.ContractorID.MinimumWidth = 8;
            this.ContractorID.Name = "ContractorID";
            this.ContractorID.Width = 110;
            // 
            // ContName
            // 
            this.ContName.HeaderText = "ContName";
            this.ContName.MinimumWidth = 8;
            this.ContName.Name = "ContName";
            this.ContName.Width = 110;
            // 
            // ContAddress
            // 
            this.ContAddress.HeaderText = "ContAddress";
            this.ContAddress.MinimumWidth = 8;
            this.ContAddress.Name = "ContAddress";
            this.ContAddress.Width = 110;
            // 
            // ContPhone
            // 
            this.ContPhone.HeaderText = "ContPhone";
            this.ContPhone.MinimumWidth = 8;
            this.ContPhone.Name = "ContPhone";
            this.ContPhone.Width = 110;
            // 
            // MSG
            // 
            this.MSG.HeaderText = "MSG";
            this.MSG.MinimumWidth = 8;
            this.MSG.Name = "MSG";
            this.MSG.Width = 150;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lavender;
            this.button7.Location = new System.Drawing.Point(41, 167);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(296, 41);
            this.button7.TabIndex = 99;
            this.button7.Text = "Records";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bttn2
            // 
            this.bttn2.BackColor = System.Drawing.Color.MidnightBlue;
            this.bttn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn2.ForeColor = System.Drawing.Color.Coral;
            this.bttn2.Location = new System.Drawing.Point(421, 532);
            this.bttn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(138, 54);
            this.bttn2.TabIndex = 145;
            this.bttn2.Text = "ADD";
            this.bttn2.UseVisualStyleBackColor = false;
            this.bttn2.Click += new System.EventHandler(this.bttn2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(41, 218);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 41);
            this.button4.TabIndex = 101;
            this.button4.Text = "New User";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 96;
            // 
            // txtcontractoraddress
            // 
            this.txtcontractoraddress.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcontractoraddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontractoraddress.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcontractoraddress.Location = new System.Drawing.Point(585, 348);
            this.txtcontractoraddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontractoraddress.Name = "txtcontractoraddress";
            this.txtcontractoraddress.Size = new System.Drawing.Size(172, 32);
            this.txtcontractoraddress.TabIndex = 147;
            this.txtcontractoraddress.TextChanged += new System.EventHandler(this.validateTextCharacter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(371, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 117);
            this.panel1.TabIndex = 140;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Purple;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Lavender;
            this.button9.Location = new System.Drawing.Point(37, 14);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 54);
            this.button9.TabIndex = 11;
            this.button9.Text = "Back";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(41, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 41);
            this.button1.TabIndex = 97;
            this.button1.Text = "CashOut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.button14);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 1034);
            this.panel4.TabIndex = 141;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Green;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Lavender;
            this.button11.Location = new System.Drawing.Point(41, 575);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(296, 41);
            this.button11.TabIndex = 108;
            this.button11.Text = "Report";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Green;
            this.button12.FlatAppearance.BorderSize = 2;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Lavender;
            this.button12.Location = new System.Drawing.Point(41, 524);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(296, 41);
            this.button12.TabIndex = 107;
            this.button12.Text = "New Employee";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Green;
            this.button13.FlatAppearance.BorderSize = 2;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Lavender;
            this.button13.Location = new System.Drawing.Point(41, 473);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(296, 41);
            this.button13.TabIndex = 106;
            this.button13.Text = "Emp Management";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Lavender;
            this.button6.Location = new System.Drawing.Point(41, 320);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(296, 41);
            this.button6.TabIndex = 103;
            this.button6.Text = "New Laybour";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Green;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Lavender;
            this.button8.Location = new System.Drawing.Point(41, 269);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(296, 41);
            this.button8.TabIndex = 104;
            this.button8.Text = "Cash In Hand";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Lavender;
            this.button10.Location = new System.Drawing.Point(41, 422);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(296, 41);
            this.button10.TabIndex = 105;
            this.button10.Text = "New Contractor";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Green;
            this.button14.FlatAppearance.BorderSize = 2;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Lavender;
            this.button14.Location = new System.Drawing.Point(41, 371);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(296, 41);
            this.button14.TabIndex = 110;
            this.button14.Text = "Laybour Management";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Contractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 1034);
            this.Controls.Add(this.Insertinsqltable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdealamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcontractorid);
            this.Controls.Add(this.bttn4);
            this.Controls.Add(this.txtcontractorname);
            this.Controls.Add(this.ProdGV);
            this.Controls.Add(this.bttn2);
            this.Controls.Add(this.txtcontractoraddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.MaximumSize = new System.Drawing.Size(1930, 1090);
            this.MinimumSize = new System.Drawing.Size(1918, 1006);
            this.Name = "Contractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contractor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Contractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Insertinsqltable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdealamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcontractorid;
        private System.Windows.Forms.Button bttn4;
        private System.Windows.Forms.TextBox txtcontractorname;
        private System.Windows.Forms.DataGridView ProdGV;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontractoraddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSG;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
    }
}