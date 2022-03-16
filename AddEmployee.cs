using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Emp_Management : Form
    {
        private DataGridViewTextBoxColumn BlodGroup;
        private Label label18;
        private TextBox textempid;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Label label12;
        private ComboBox comboBox1;
        private Label label13;
        private Label label14;
        private TextBox textBox1;
        private Label label15;
        private DataGridViewTextBoxColumn EmpGender;
        private DataGridViewTextBoxColumn EmerNo;
        private TextBox textBox2;
        private Label label16;
        private TextBox textBox3;
        private Label label17;
        private TextBox textBox4;
        private Label label7;
        private Label label5;
        private ComboBox combo1;
        private Label label10;
        private TextBox txtfname;
        private Label label8;
        private TextBox txtcnic;
        private Label label9;
        private TextBox txtlstname;
        private Label label11;
        private TextBox txtuname;
        private Label label6;
        private TextBox txtph;
        private DataGridViewTextBoxColumn EmpID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn EmpDOB;
        private DataGridViewTextBoxColumn MartialStatus;
        private TextBox txtadress;
        private DataGridViewTextBoxColumn EmpEducation;
        private Label label4;
        private Button button14;
        private Button button15;
        private Button button17;
        private Button button18;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Cnic;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn ELName;
        private DataGridViewTextBoxColumn EFName;
        private DataGridViewTextBoxColumn ID;
        private DataGridView dataGridView2;
        private Button Insertinsqltable;
        private Panel panel3;
        private Label label2;
        private Panel panel4;

        public Emp_Management()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Employee_Management EM = new Employee_Management();
            this.Hide();
            EM.Show();
        }

        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Insertinsqltable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MartialStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.textempid = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcnic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtlstname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtph = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(255, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(821, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = "CONSTRUCTION RESOURCE MANAGEMENT";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Green;
            this.button14.FlatAppearance.BorderSize = 2;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Lavender;
            this.button14.Location = new System.Drawing.Point(-1, 779);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(296, 41);
            this.button14.TabIndex = 48;
            this.button14.Text = "Finance Report";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Green;
            this.button15.FlatAppearance.BorderSize = 2;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Lavender;
            this.button15.Location = new System.Drawing.Point(-2, 686);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(296, 41);
            this.button15.TabIndex = 49;
            this.button15.Text = "Manage Vender";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Green;
            this.button17.FlatAppearance.BorderSize = 2;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Lavender;
            this.button17.Location = new System.Drawing.Point(-5, 739);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(296, 41);
            this.button17.TabIndex = 46;
            this.button17.Text = "Branch Management";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Green;
            this.button18.FlatAppearance.BorderSize = 2;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Lavender;
            this.button18.Location = new System.Drawing.Point(-4, 815);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(296, 41);
            this.button18.TabIndex = 47;
            this.button18.Text = "Expence Report";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Green;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Lavender;
            this.button9.Location = new System.Drawing.Point(1, 568);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(296, 41);
            this.button9.TabIndex = 42;
            this.button9.Text = "Manage Product";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Lavender;
            this.button10.Location = new System.Drawing.Point(0, 475);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(296, 41);
            this.button10.TabIndex = 43;
            this.button10.Text = "Add Product";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Green;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Lavender;
            this.button11.Location = new System.Drawing.Point(2, 644);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(296, 41);
            this.button11.TabIndex = 44;
            this.button11.Text = "Add Vender";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Green;
            this.button12.FlatAppearance.BorderSize = 2;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Lavender;
            this.button12.Location = new System.Drawing.Point(0, 376);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(296, 41);
            this.button12.TabIndex = 45;
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
            this.button13.Location = new System.Drawing.Point(0, 285);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(296, 41);
            this.button13.TabIndex = 40;
            this.button13.Text = "Emp Management";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(305, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.MaximumSize = new System.Drawing.Size(1924, 117);
            this.panel1.MinimumSize = new System.Drawing.Size(1924, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 117);
            this.panel1.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Admin Interface";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Pink;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Lavender;
            this.button8.Location = new System.Drawing.Point(3, 14);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(258, 41);
            this.button8.TabIndex = 9;
            this.button8.Text = "LOGOUT";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 872);
            this.panel2.TabIndex = 155;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.button14);
            this.panel5.Controls.Add(this.button15);
            this.panel5.Controls.Add(this.button17);
            this.panel5.Controls.Add(this.button18);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.button12);
            this.panel5.Controls.Add(this.button13);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 872);
            this.panel5.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(39, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lavender;
            this.button7.Location = new System.Drawing.Point(-3, 528);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(296, 41);
            this.button7.TabIndex = 9;
            this.button7.Text = "Records";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(-4, 435);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(296, 41);
            this.button5.TabIndex = 9;
            this.button5.Text = "Customer";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(-2, 604);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "New User";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(-4, 336);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cash Out";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(-4, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cash In";
            this.button1.UseVisualStyleBackColor = false;
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
            // Insertinsqltable
            // 
            this.Insertinsqltable.BackColor = System.Drawing.Color.MediumBlue;
            this.Insertinsqltable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Insertinsqltable.Location = new System.Drawing.Point(1274, 748);
            this.Insertinsqltable.Name = "Insertinsqltable";
            this.Insertinsqltable.Size = new System.Drawing.Size(10, 45);
            this.Insertinsqltable.TabIndex = 160;
            this.Insertinsqltable.Text = "Insert in sql table";
            this.Insertinsqltable.UseVisualStyleBackColor = false;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 872);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1896, 78);
            this.panel4.TabIndex = 157;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.download4;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.textempid);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.combo1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtfname);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtcnic);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtlstname);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtuname);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtph);
            this.panel3.Controls.Add(this.txtadress);
            this.panel3.Location = new System.Drawing.Point(303, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1434, 845);
            this.panel3.TabIndex = 156;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EFName,
            this.ELName,
            this.Phone,
            this.Cnic,
            this.Name,
            this.EmpEducation,
            this.EmpDOB,
            this.EmpGender,
            this.EmerNo,
            this.BlodGroup,
            this.MartialStatus,
            this.EmpID,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView2.Location = new System.Drawing.Point(436, 130);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(725, 202);
            this.dataGridView2.TabIndex = 169;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // EFName
            // 
            this.EFName.HeaderText = "EFName";
            this.EFName.MinimumWidth = 8;
            this.EFName.Name = "EFName";
            this.EFName.Width = 80;
            // 
            // ELName
            // 
            this.ELName.HeaderText = "ELName";
            this.ELName.MinimumWidth = 8;
            this.ELName.Name = "ELName";
            this.ELName.Width = 80;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 80;
            // 
            // Cnic
            // 
            this.Cnic.HeaderText = "Cnic";
            this.Cnic.MinimumWidth = 8;
            this.Cnic.Name = "Cnic";
            this.Cnic.Width = 80;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.Width = 80;
            // 
            // EmpEducation
            // 
            this.EmpEducation.HeaderText = "EmpEducation";
            this.EmpEducation.MinimumWidth = 8;
            this.EmpEducation.Name = "EmpEducation";
            this.EmpEducation.Width = 80;
            // 
            // EmpDOB
            // 
            this.EmpDOB.HeaderText = "EmpDOB";
            this.EmpDOB.MinimumWidth = 8;
            this.EmpDOB.Name = "EmpDOB";
            this.EmpDOB.Width = 150;
            // 
            // EmpGender
            // 
            this.EmpGender.HeaderText = "EmpGender";
            this.EmpGender.MinimumWidth = 8;
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Width = 150;
            // 
            // EmerNo
            // 
            this.EmerNo.HeaderText = "EmerNo";
            this.EmerNo.MinimumWidth = 8;
            this.EmerNo.Name = "EmerNo";
            this.EmerNo.Width = 150;
            // 
            // BlodGroup
            // 
            this.BlodGroup.HeaderText = "BlodGroup";
            this.BlodGroup.MinimumWidth = 8;
            this.BlodGroup.Name = "BlodGroup";
            this.BlodGroup.Width = 150;
            // 
            // MartialStatus
            // 
            this.MartialStatus.HeaderText = "MartialStatus";
            this.MartialStatus.MinimumWidth = 8;
            this.MartialStatus.Name = "MartialStatus";
            this.MartialStatus.Width = 150;
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.MinimumWidth = 8;
            this.EmpID.Name = "EmpID";
            this.EmpID.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "MSG";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Tomato;
            this.label18.Location = new System.Drawing.Point(10, 559);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 27);
            this.label18.TabIndex = 166;
            this.label18.Text = "Emp_ID";
            // 
            // textempid
            // 
            this.textempid.BackColor = System.Drawing.Color.Gainsboro;
            this.textempid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textempid.ForeColor = System.Drawing.Color.MediumBlue;
            this.textempid.Location = new System.Drawing.Point(146, 556);
            this.textempid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textempid.Name = "textempid";
            this.textempid.Size = new System.Drawing.Size(201, 32);
            this.textempid.TabIndex = 167;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox2.Location = new System.Drawing.Point(146, 392);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 28);
            this.comboBox2.TabIndex = 165;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 363);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(725, 202);
            this.dataGridView1.TabIndex = 152;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Tomato;
            this.label12.Location = new System.Drawing.Point(4, 470);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 25);
            this.label12.TabIndex = 161;
            this.label12.Text = "Blod Group";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.comboBox1.Location = new System.Drawing.Point(146, 509);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 35);
            this.comboBox1.TabIndex = 163;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Tomato;
            this.label13.Location = new System.Drawing.Point(6, 509);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 25);
            this.label13.TabIndex = 162;
            this.label13.Text = "Martial Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Tomato;
            this.label14.Location = new System.Drawing.Point(4, 425);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 27);
            this.label14.TabIndex = 158;
            this.label14.Text = "Emer No";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox1.Location = new System.Drawing.Point(146, 470);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 32);
            this.textBox1.TabIndex = 160;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Tomato;
            this.label15.Location = new System.Drawing.Point(4, 309);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 27);
            this.label15.TabIndex = 152;
            this.label15.Text = "Emp_Exp";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox2.Location = new System.Drawing.Point(146, 304);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 32);
            this.textBox2.TabIndex = 155;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Tomato;
            this.label16.Location = new System.Drawing.Point(4, 346);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 27);
            this.label16.TabIndex = 153;
            this.label16.Text = "Emp_DOB";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox3.Location = new System.Drawing.Point(146, 346);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 32);
            this.textBox3.TabIndex = 156;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Tomato;
            this.label17.Location = new System.Drawing.Point(10, 385);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 27);
            this.label17.TabIndex = 154;
            this.label17.Text = "E_Gender";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox4.Location = new System.Drawing.Point(146, 428);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 32);
            this.textBox4.TabIndex = 159;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 27);
            this.label7.TabIndex = 134;
            this.label7.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(6, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 149;
            this.label5.Text = "CNIC#:";
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
            this.combo1.Location = new System.Drawing.Point(142, 254);
            this.combo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(201, 35);
            this.combo1.TabIndex = 151;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(6, 254);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 150;
            this.label10.Text = "E_Education";
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtfname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtfname.Location = new System.Drawing.Point(142, 7);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(201, 32);
            this.txtfname.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(6, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 27);
            this.label8.TabIndex = 145;
            this.label8.Text = "Phone#:";
            // 
            // txtcnic
            // 
            this.txtcnic.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcnic.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnic.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcnic.Location = new System.Drawing.Point(142, 215);
            this.txtcnic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcnic.Name = "txtcnic";
            this.txtcnic.Size = new System.Drawing.Size(201, 32);
            this.txtcnic.TabIndex = 148;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(4, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 27);
            this.label9.TabIndex = 135;
            this.label9.Text = "Last Name:";
            // 
            // txtlstname
            // 
            this.txtlstname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtlstname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlstname.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtlstname.Location = new System.Drawing.Point(142, 49);
            this.txtlstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtlstname.Name = "txtlstname";
            this.txtlstname.Size = new System.Drawing.Size(201, 32);
            this.txtlstname.TabIndex = 140;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 27);
            this.label11.TabIndex = 136;
            this.label11.Text = "User Name:";
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtuname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtuname.Location = new System.Drawing.Point(142, 91);
            this.txtuname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(201, 32);
            this.txtuname.TabIndex = 142;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(10, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 137;
            this.label6.Text = "Address";
            // 
            // txtph
            // 
            this.txtph.BackColor = System.Drawing.Color.Gainsboro;
            this.txtph.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtph.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtph.Location = new System.Drawing.Point(142, 173);
            this.txtph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtph.Name = "txtph";
            this.txtph.Size = new System.Drawing.Size(201, 32);
            this.txtph.TabIndex = 146;
            // 
            // txtadress
            // 
            this.txtadress.BackColor = System.Drawing.Color.Gainsboro;
            this.txtadress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadress.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtadress.Location = new System.Drawing.Point(142, 130);
            this.txtadress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(201, 32);
            this.txtadress.TabIndex = 144;
            this.txtadress.UseSystemPasswordChar = true;
            // 
            // Emp_Management
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1896, 950);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Insertinsqltable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Emp_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Employee_Management EM = new Employee_Management();
            this.Hide();
            EM.Show();
        }
    }

    class AddEmployee
    {
        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
