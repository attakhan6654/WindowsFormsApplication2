namespace WindowsFormsApplication2
{
    partial class UUserTabForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcnic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UseFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseCnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsePassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insertinsqltable = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bttn2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdGV = new System.Windows.Forms.DataGridView();
            this.txtph = new System.Windows.Forms.TextBox();
            this.bttn4 = new System.Windows.Forms.Button();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlstname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGV)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(725, 202);
            this.dataGridView1.TabIndex = 128;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(108, 565);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 126;
            this.label10.Text = "User type:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(-2, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cash In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo1
            // 
            this.combo1.BackColor = System.Drawing.Color.Gainsboro;
            this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo1.ForeColor = System.Drawing.Color.MediumBlue;
            this.combo1.FormattingEnabled = true;
            this.combo1.Items.AddRange(new object[] {
            "ADMIN",
            "LAB_ATTENDENT/USER"});
            this.combo1.Location = new System.Drawing.Point(106, 594);
            this.combo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(235, 35);
            this.combo1.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(106, 493);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 125;
            this.label3.Text = "CNIC#:";
            // 
            // txtcnic
            // 
            this.txtcnic.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcnic.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnic.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcnic.Location = new System.Drawing.Point(106, 522);
            this.txtcnic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcnic.Name = "txtcnic";
            this.txtcnic.Size = new System.Drawing.Size(235, 32);
            this.txtcnic.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(106, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 27);
            this.label8.TabIndex = 121;
            this.label8.Text = "Phone#:";
            // 
            // UseFName
            // 
            this.UseFName.HeaderText = "FName";
            this.UseFName.Name = "UseFName";
            this.UseFName.Width = 90;
            // 
            // UseLName
            // 
            this.UseLName.HeaderText = "LName";
            this.UseLName.Name = "UseLName";
            // 
            // UseType
            // 
            this.UseType.HeaderText = "Type";
            this.UseType.Name = "UseType";
            this.UseType.Width = 90;
            // 
            // UseCnic
            // 
            this.UseCnic.HeaderText = "Cnic";
            this.UseCnic.Name = "UseCnic";
            this.UseCnic.Width = 90;
            // 
            // UsePhone
            // 
            this.UsePhone.HeaderText = "Phone";
            this.UsePhone.Name = "UsePhone";
            this.UsePhone.Width = 90;
            // 
            // UsePassword
            // 
            this.UsePassword.HeaderText = "Password";
            this.UsePassword.Name = "UsePassword";
            // 
            // UseName
            // 
            this.UseName.HeaderText = "Name";
            this.UseName.Name = "UseName";
            // 
            // Insertinsqltable
            // 
            this.Insertinsqltable.BackColor = System.Drawing.Color.MediumBlue;
            this.Insertinsqltable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Insertinsqltable.Location = new System.Drawing.Point(400, 8);
            this.Insertinsqltable.Name = "Insertinsqltable";
            this.Insertinsqltable.Size = new System.Drawing.Size(110, 45);
            this.Insertinsqltable.TabIndex = 129;
            this.Insertinsqltable.Text = "Insert in sql table";
            this.Insertinsqltable.UseVisualStyleBackColor = false;
            this.Insertinsqltable.Click += new System.EventHandler(this.Insertinsqltable_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.checkBox1.Location = new System.Drawing.Point(188, 379);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 29);
            this.checkBox1.TabIndex = 123;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bttn2
            // 
            this.bttn2.BackColor = System.Drawing.Color.Pink;
            this.bttn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn2.ForeColor = System.Drawing.Color.Coral;
            this.bttn2.Location = new System.Drawing.Point(32, 652);
            this.bttn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(110, 45);
            this.bttn2.TabIndex = 116;
            this.bttn2.Text = "ADD";
            this.bttn2.UseVisualStyleBackColor = false;
            this.bttn2.Click += new System.EventHandler(this.bttn2_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.download__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.Insertinsqltable);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.combo1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtcnic);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ProdGV);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.bttn2);
            this.panel3.Controls.Add(this.txtph);
            this.panel3.Controls.Add(this.bttn4);
            this.panel3.Controls.Add(this.txtuname);
            this.panel3.Controls.Add(this.txtpass);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtlstname);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtfname);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(303, 117);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 874);
            this.panel3.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(876, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 31);
            this.label7.TabIndex = 120;
            this.label7.Text = "Users List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(106, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 112;
            this.label6.Text = "Password:";
            // 
            // ProdGV
            // 
            this.ProdGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ProdGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UseFName,
            this.UseLName,
            this.UseName,
            this.UsePassword,
            this.UsePhone,
            this.UseCnic,
            this.UseType});
            this.ProdGV.Location = new System.Drawing.Point(400, 56);
            this.ProdGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdGV.Name = "ProdGV";
            this.ProdGV.RowHeadersWidth = 62;
            this.ProdGV.Size = new System.Drawing.Size(725, 202);
            this.ProdGV.TabIndex = 114;
            // 
            // txtph
            // 
            this.txtph.BackColor = System.Drawing.Color.Gainsboro;
            this.txtph.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtph.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtph.Location = new System.Drawing.Point(106, 450);
            this.txtph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtph.Name = "txtph";
            this.txtph.Size = new System.Drawing.Size(235, 32);
            this.txtph.TabIndex = 122;
            // 
            // bttn4
            // 
            this.bttn4.BackColor = System.Drawing.Color.Pink;
            this.bttn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn4.ForeColor = System.Drawing.Color.Coral;
            this.bttn4.Location = new System.Drawing.Point(326, 652);
            this.bttn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(110, 45);
            this.bttn4.TabIndex = 118;
            this.bttn4.Text = "DELETE";
            this.bttn4.UseVisualStyleBackColor = false;
            this.bttn4.Click += new System.EventHandler(this.bttn4_Click);
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtuname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtuname.Location = new System.Drawing.Point(106, 257);
            this.txtuname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(212, 32);
            this.txtuname.TabIndex = 117;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtpass.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtpass.Location = new System.Drawing.Point(106, 333);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(212, 32);
            this.txtpass.TabIndex = 119;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(106, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 27);
            this.label5.TabIndex = 109;
            this.label5.Text = "First Name:";
            // 
            // txtlstname
            // 
            this.txtlstname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtlstname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlstname.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtlstname.Location = new System.Drawing.Point(106, 182);
            this.txtlstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtlstname.Name = "txtlstname";
            this.txtlstname.Size = new System.Drawing.Size(212, 32);
            this.txtlstname.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(106, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 27);
            this.label9.TabIndex = 110;
            this.label9.Text = "Last Name:";
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtfname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtfname.Location = new System.Drawing.Point(106, 106);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(212, 32);
            this.txtfname.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(106, 223);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 27);
            this.label11.TabIndex = 111;
            this.label11.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "@ All Copy rights are Reserved";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 917);
            this.panel5.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(-2, 391);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(296, 54);
            this.button5.TabIndex = 11;
            this.button5.Text = "New User";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(-2, 306);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "Record";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Pink;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Lavender;
            this.button8.Location = new System.Drawing.Point(13, 475);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(258, 54);
            this.button8.TabIndex = 9;
            this.button8.Text = "LOGOUT";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lavender;
            this.button7.Location = new System.Drawing.Point(-2, 225);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(296, 54);
            this.button7.TabIndex = 9;
            this.button7.Text = "Customer";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(-2, 143);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cash Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(304, 963);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1604, 71);
            this.panel4.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(4, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 917);
            this.panel2.TabIndex = 24;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Lavender;
            this.button9.Location = new System.Drawing.Point(4, 5);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 54);
            this.button9.TabIndex = 10;
            this.button9.Text = "Back";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(260, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(733, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = "CONSTRUCTION MAIN MANAGEMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(962, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Interface";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1908, 117);
            this.panel1.TabIndex = 23;
            // 
            // UUserTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 1034);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1930, 1090);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1006);
            this.Name = "UUserTabForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UUserTabForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UUserTabForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGV)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcnic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseCnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseName;
        private System.Windows.Forms.Button Insertinsqltable;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ProdGV;
        private System.Windows.Forms.TextBox txtph;
        private System.Windows.Forms.Button bttn4;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlstname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}