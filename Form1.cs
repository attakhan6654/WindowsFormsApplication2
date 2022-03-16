using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KF1H18L;Initial Catalog=project;Integrated Security=True"); // making connection   
        private void btn_reset_Click(object sender, EventArgs e)
        {
            textuser.Clear();
            textpassword.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String a = textuser.Text;
            String b = textpassword.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KF1H18L;Initial Catalog=project;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin WHERE adminusername='" + a + "' AND adminpassword='" + b + "'", conn);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dtt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dtt);
            if (dtt.Rows[0][0].ToString() == "2")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new Main().Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
