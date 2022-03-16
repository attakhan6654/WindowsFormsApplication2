using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class RRecord : Form
    {
        public RRecord()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
       
        private void button9_Click(object sender, EventArgs e)
        {
            loaddatanu();
        }

        private void loaddatanu()
        {
            var st = from s in db.TabMyUses select s;
            dataGridView2.DataSource = st;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loaddatanc();
        }

        private void loaddatanc()
        {
            var st = from s in db.TabMyCus select s;
            dataGridView4.DataSource = st;
        }

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    loaddataci();
        //}

        //private void loaddataci()
        //{
        //    var st = from s in db.InnCashes select s;
        //    dataGridView1.DataSource = st;
        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    loaddataco();
        //}

        //private void loaddataco()
        //{
        //    var st = from s in db.OutCashes select s;
        //    dataGridView3.DataSource = st;
        //}

        //private void button12_Click(object sender, EventArgs e)
        //{
        //    loaddatar();
        //}

        //private void loaddatar()
        //{
        //    var st = from s in db.InnCashes select s;
        //    dataGridView5.DataSource = st;
        //    var stt = from s in db.OutCashes select s;
        //    dataGridView5.DataSource = stt;
        //}

        private void button13_Click(object sender, EventArgs e)
        {
            AAdmin_Panel AA_P = new AAdmin_Panel();
            this.Hide();
            AA_P.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loaddatane();
        }

        private void loaddatane()
        {
            var st = from s in db.EEmployees select s;
            dataGridView3.DataSource = st;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loaddatanl();
        }

        private void loaddatanl()
        {
            var st = from s in db.Labours select s;
            dataGridView1.DataSource = st;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "User Detail Report";
                print.SubTitle = "Print Date: " + DateTime.Now.ToShortDateString();
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "Resource Man Power ";
                print.FooterSpacing = 15;
                print.PrintDataGridView(dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RRecord_Load(object sender, EventArgs e)
        {
            loaddatane();
            loaddatanl();
            loaddatanc();
            loaddatanu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
            string query = "select * from TabMyUse where nameuse like @nameuse + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.Parameters.AddWithValue("@nameuse", textBox1.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView2.DataSource = data;
            if (data.Rows.Count > 0)
            {
                dataGridView2.DataSource = data;
            }
            else 
            {
                MessageBox.Show("No Rows Found");
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "Customer Detail Report";
                print.SubTitle = "Print Date: " + DateTime.Now.ToShortDateString();
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "Resource Man Power ";
                print.FooterSpacing = 15;
                print.PrintDataGridView(dataGridView4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "Laybour Detail Report";
                print.SubTitle = "Print Date: " + DateTime.Now.ToShortDateString();
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "Resource Man Power ";
                print.FooterSpacing = 15;
                print.PrintDataGridView(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "Employee Detail Report";
                print.SubTitle = "Print Date: " + DateTime.Now.ToShortDateString();
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "Resource Man Power ";
                print.FooterSpacing = 15;
                print.PrintDataGridView(dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
            string query = "select * from TabMyCus where namecus like @namecus + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@namecus", textBox2.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView4.DataSource = data;
            if (data.Rows.Count > 0)
            {
                dataGridView4.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Rows Found");

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
            string query = "select * from Labour where labourname like @labourname + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@labourname", textBox3.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Rows Found");

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
            string query = "select * from EEmployee where empusernames like @empusernames + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@empusernames", textBox4.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView3.DataSource = data;
            if (data.Rows.Count > 0)
            {
                dataGridView3.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Rows Found");

            }
        }
    }
}
