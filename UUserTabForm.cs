using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class UUserTabForm : Form
    {
        public UUserTabForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KF1H18L;Initial Catalog=administrator;Integrated Security=True");
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            CCashInner CCI = new CCashInner();
            this.Hide();
            CCI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CCashOuter CCO = new CCashOuter();
            this.Hide();
            CCO.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AAdmin_Panel AA_P = new AAdmin_Panel();
            this.Hide();
            AA_P.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NNewCoustomer NNC = new NNewCoustomer();
            this.Hide();
            NNC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UUserTabForm UUTF = new UUserTabForm();
            this.Hide();
            UUTF.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Iindex Ii = new Iindex();
            this.Hide();
            Ii.Show();
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into TabMyUse values('" + txtfname.Text + "', '" + txtlstname.Text + "', '" + txtuname.Text + "', '" + txtpass.Text + "', '" + txtph.Text + "', '" + txtcnic.Text + "', '" + combo1.Text + "')", con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data Inserted Successfully.");
            //con.Close();

            //for Insert// button code
            var st = new TabMyUse
            {
                FNameUse = txtfname.Text,
                LNameUse = txtlstname.Text,
                NameUse = txtuname.Text,
                PasswordUse = txtpass.Text,
                PhoneUse = Convert.ToDouble(txtph.Text),
                CnicUse = txtcnic.Text,
                TypeUse = combo1.Text,

            };
            db.TabMyUses.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Regestered Sussfully");
            loaddata();
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            var st = (from s in db.TabMyUses where s.FNameUse == txtfname.Text select s).First();
            db.TabMyUses.DeleteOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Successfully Deleted...");
            loaddata();
        }

        private void loaddata()
        {
            ProdGV.AutoGenerateColumns = false;
            loadData();
        }

        private void Insertinsqltable_Click(object sender, EventArgs e)
        {
            //ProdGV.AutoGenerateColumns = false;
            //loadData();
            string fnu = "", lnu = ""; string nu = "", passuse = ""; int pu = 0; string cu = "", tu = "";
            for (int i = 0; i < ProdGV.Rows.Count - 1; i++)
            {

                fnu = ProdGV.Rows[i].Cells[0].Value.ToString();
                lnu = ProdGV.Rows[i].Cells[1].Value.ToString();
                nu = ProdGV.Rows[i].Cells[2].Value.ToString();
                passuse = ProdGV.Rows[i].Cells[3].Value.ToString();
                pu = Convert.ToInt32(ProdGV.Rows[i].Cells[4].Value.ToString());
                cu = ProdGV.Rows[i].Cells[5].Value.ToString();
                tu = ProdGV.Rows[i].Cells[6].Value.ToString();


                var st = new TabMyUse
                {
                    FNameUse = fnu,
                    LNameUse = lnu,
                    NameUse = nu,
                    PasswordUse = passuse,
                    PhoneUse = pu,
                    CnicUse = cu,
                    TypeUse = tu,
                };
                db.TabMyUses.InsertOnSubmit(st);
                db.SubmitChanges();
                ProdGV.Rows[i].Cells[3].Value = "Success";
                loadData();
                ProdGV.ClearSelection();
            }
        }

        private void loadData()
        {
            var st = from s in db.TabMyUses select s;
            dataGridView1.DataSource = st;
        }

        private void UUserTabForm_Load(object sender, EventArgs e)
        {
            ProdGV.AutoGenerateColumns = false;
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RRecord RR = new RRecord();
            this.Hide();
            RR.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                txtpass.UseSystemPasswordChar = true;
            else
                txtpass.UseSystemPasswordChar = false;
        }
    }
}
