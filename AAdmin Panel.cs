using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AAdmin_Panel : Form
    {
        public AAdmin_Panel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
        


        public static string SetValueForText1 = "";
        public static int SetValueForText2=0;
        public static string SetValueForText3 = "";
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            CCashInner CCI = new CCashInner();
            this.Hide();
            CCI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NNewUser NNU = new NNewUser();
            this.Hide();
            NNU.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NNewCoustomer NNC = new NNewCoustomer();
            this.Hide();
            NNC.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Iindex Ii = new Iindex();
            this.Hide();
            Ii.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RRecord RR = new RRecord();
            this.Hide();
            RR.Show();
        }

        private void AAdmin_Panel_Load(object sender, EventArgs e)
        {
            label3.Text = Iindex.SetValueForText1;
            txtid.Text = Convert.ToString(Iindex.SetValueForText2) ;
            txtname.Text = Iindex.SetValueForText1;
            txtpass.Text = Iindex.SetValueForText3;

            var st = (from s in db.Tables where s.Name == txtname.Text select s).First();
            {

                if (st != null)
                {

                    Name = st.Name;

                    pictureBox1.Image = ByteArrayToImage(st.UserPic.ToArray());
                }

            }

            //for image upload
            //var st = (from s in db.Tables where s.Name == txtname.Text select s).First();
            //{
            //    pictureBox1.Image = ByteArrayToImage(st.UserPic.ToArray());

            //}
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            
            }
        
        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CCashOuter CCO = new CCashOuter();
            this.Hide();
            CCO.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



            //for image upload
            //OpenFileDialog open = new OpenFileDialog();
            //PictureBox p = sender as PictureBox;
            //if (p != null)
            //{
            //    open.Filter = "(*.jpg;*.jpg;*.pmp) | *.jpg; *jpeg; *.bmp";
            //    if (open.ShowDialog() == DialogResult.OK)
            //    {
            //        p.Image = Image.FromFile(open.FileName);
            //        MessageBox.Show(open.FileName);

            //    }

            //    byte[] file_byte = ImageToByteArray(pictureBox1.Image);
            //    System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
            //    var stt = new Table
            //    {

            //        Name = this.Name,
            //        UserPic = file_binary,
            //    };
            //    db.Tables.InsertOnSubmit(stt);
            //    db.SubmitChanges();
            //    MessageBox.Show("Successfully Updated");

            //}


            //for image display
            var st = (from s in db.Tables where s.Name == txtname.Text select s).First();
            {
                
                if (st != null)
                {
                    
                    Name = st.Name;

                    pictureBox1.Image = ByteArrayToImage(st.UserPic.ToArray());
                }

            }

        }

        //private byte[] ImageToByteArray(Image imageIn)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
        //        return ms.ToArray();

        //    }
        //}
        //public Image ByteArrayToImage(byte[] byteArrayIn)
        //{

        //    using (MemoryStream ms = new MemoryStream(byteArrayIn))
        //    {
        //        Image returnImage = Image.FromStream(ms);
        //        return returnImage;



        //    }

        //}
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NNewLaybour NNL = new NNewLaybour();
            this.Hide();
            NNL.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CashIHand CIH = new CashIHand();
            this.Hide();
            CIH.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Contractor C = new Contractor();
            this.Hide();
            C.Show();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
           
            //SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * From TabMyUser Where UserId=@UserID", con);
            ////SqlCommand cmd = new SqlCommand("Select nameUser, PasswordUser From TabMyUser Where UserId=@UserID",con);
            //cmd.Parameters.AddWithValue("@UserID",int.Parse(txtid.Text));
            //SqlDataReader da = cmd.ExecuteReader();
            
            //while (da.Read())
            //{
            //    txtid.Text = da.GetValue(0).ToString();
            //    txtname.Text = da.GetValue(1).ToString();

            //}
            //con.Close();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
            //con.Open();
            ////SqlCommand cmd = new SqlCommand("Select * From TabMyUser Where UserId=@UserID", con);
            //SqlCommand cmd = new SqlCommand("Select nameUser, PasswordUser From TabMyUser Where UserId=@UserID",con);
            //cmd.Parameters.AddWithValue("@UserID", int.Parse(txtid.Text));
            //SqlDataReader da = cmd.ExecuteReader();

            //while (da.Read())
            //{
            //    txtid.Text = da.GetValue(0).ToString();
            //    txtname.Text = da.GetValue(1).ToString();
            //    txtpass.Text = da.GetValue(2).ToString();
            //}
            //con.Close();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
            con.Open();
            //SqlCommand cmd = new SqlCommand("Select * From TabMyUser Where UserId=@UserID", con);
            SqlCommand cmd = new SqlCommand("Select nameUser, PasswordUser From TabMyUser Where UserId=@UserID", con);
            cmd.Parameters.AddWithValue("@UserID", int.Parse(txtid.Text));
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                txtid.Text = da.GetValue(0).ToString();
                txtname.Text = da.GetValue(1).ToString();
                txtpass.Text = da.GetValue(2).ToString();
            }
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtpass.Text != "")
            {
                SetValueForText1 = txtname.Text;
                SetValueForText3= txtpass.Text;
                //SetValueForText2 = Convert.ToInt32(txtname.Text);



                var usertype = (from s in db.TabMyUsers where /* s.UserID == combo1.Text && */ s.NameUser == txtname.Text select s).First();
                if (usertype.PasswordUser == txtpass.Text)
                {
                    AAdmin_Profile AA_Pro = new AAdmin_Profile();
                    this.Hide();
                    AA_Pro.Show();
                }
                else { }
            }
              
                
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EEmployee_Management EE_M=new EEmployee_Management();
            this.Hide();
            EE_M.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NNewEmployee NNE=new NNewEmployee();
            this.Hide();
            NNE.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RReport R = new RReport();
            this.Hide();
            R.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            LLabour_Management LL_M = new LLabour_Management();
            this.Hide();
            LL_M.Show();
        }
    }
}
