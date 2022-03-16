using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Iindex : Form
    {
        public Iindex()
        {
            InitializeComponent();
        }
        public static string SetValueForText1 = "";
        public static int SetValueForText2=0;
        public static string SetValueForText3 = "";
        //connection linq class String creating an object of .dbml classes
        DataClasses1DataContext db = new DataClasses1DataContext();

        //integer validations
        private void validateTextInteger(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        //double validation
        private void validateTextDouble(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    double x = double.Parse(T.Text);

                    if (T.Text.Contains(','))
                        throw X;
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        //charactor validation
        private void validateTextCharacter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {
                //Not Allowing Numbers
                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }

        private bool textContainsUnallowedCharacter(string T, char[] UnallowedCharacters)
        {
            for (int i = 0; i < UnallowedCharacters.Length; i++)
                if (T.Contains(UnallowedCharacters[i]))
                    return true;

            return false;
        }

        //integer customization x<0
        private void validateTextIntegerCustomized(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                int x = int.Parse(T.Text);

                //Customizing Condition
                if (x <= 0)
                    throw X;
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }

            }
        }

        //double customization x<0
        private void validateTextDoubleCustomized(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                double x = double.Parse(T.Text);

                //Customizing Condition (Only numbers larger than or 
                //equal to zero are permitted)
                if (x < 0 || T.Text.Contains(','))
                    throw X;
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        //chractor customization
        private void validateTextCharacterCustomized(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;

            try
            {
                //Not Allowing Numbers, Underscore or Hash
                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9','_','#'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }



        //ImageToByteArra
        private byte[] ImageToByteArray(Image imageIn)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();

            }

        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtpass.Text != "")
            {

                var st = new TabMyUser
                {
                    /* UserID = combo1.Text, */
                    NameUser = txtname.Text,
                    PasswordUser = txtpass.Text,


                };
                //db.TabMyUsers.InsertOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("Data Inserted");

                byte[] file_byte = ImageToByteArray(pictureBox1.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                var stt = new Table
                {

                    Name = txtname.Text,
                    UserPic = file_binary,
                };
                //db.Tables.InsertOnSubmit(stt);
                db.SubmitChanges();
                MessageBox.Show("Successfully Inserted");
                txtname.Text = "";
                txtpass.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtpass.Text != "")
            {
                SetValueForText1 = txtname.Text;
                SetValueForText3 = txtpass.Text;
                //SetValueForText2 = Convert.ToInt32(combo1.Text);



                var usertype = (from s in db.TabMyUsers where /* s.UserID == combo1.Text && */ s.NameUser == txtname.Text select s).First();
                if (usertype.PasswordUser == txtpass.Text)
                {
                    AAdmin_Panel AAP = new AAdmin_Panel();
                    this.Hide();
                    AAP.Show();

                }

                else
                {
                    MessageBox.Show("User Name or Password Error");

                }

            }

            //var stt = (from s in db.Tables where s.Name == txtname.Text select s).First();
            //pictureBox1.Image = ByteArrayToImage(stt.UserPic.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RRecover rr = new RRecover();
            this.Hide();
            rr.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
                txtpass.UseSystemPasswordChar = true;
            else
                txtpass.UseSystemPasswordChar = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtpass.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpg;*.bmp;*.png) | *.jpg; *jpeg; *.bmp; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                    //MessageBox.Show(open.FileName);

                }
                //}
            }
        }

        private void Iindex_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();            
        }
    }
}
