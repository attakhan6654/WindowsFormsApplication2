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
    public partial class AAdmin_Profile : Form
    {
        public AAdmin_Profile()
        {
            InitializeComponent();
        }
        //connection linq class String creating an object of .dbml classes
        DataClasses1DataContext db = new DataClasses1DataContext();
        public static string SetValueForText1 = "";
        public static int SetValueForText2 = 0;
        public static string SetValueForText3 = "";
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

        private byte[] ImageToByteArray(Image imageIn)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CCashInner CCI = new CCashInner();
            this.Hide();
            CCI.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NNewCoustomer NNC = new NNewCoustomer();
            this.Hide();
            NNC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RRecord RR = new RRecord();
            this.Hide();
            RR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NNewUser NNU = new NNewUser();
            this.Hide();
            NNU.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Iindex Ii = new Iindex();
            this.Hide();
            Ii.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CCashOuter CCO = new CCashOuter();
            this.Hide();
            CCO.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpg;*.pmp) | *.jpg; *jpeg; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                    //MessageBox.Show(open.FileName);

                }

                byte[] file_byte = ImageToByteArray(pictureBox1.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                var stt = new Table
                {

                    Name = this.Name,
                    UserPic = file_binary,
                };
                db.Tables.InsertOnSubmit(stt);
                db.SubmitChanges();
                MessageBox.Show("Successfully Updated");

            }

            ////create an image object from File
            //Image image = Image.FromFile(@"D:\DCIM\Camera\2.jpeg");

            ////To create memory Stream
            //var ms = new MemoryStream();

            ////save byte to ms
            //image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            ////to get byte we type
            //var bytes = ms.ToArray();
            ////we need to create memory stream with byte array
            //var imageMemoryStream = new MemoryStream(bytes);
            ////now we create an image from stream
            //Image imageFromStream = Image.FromStream(imageMemoryStream);

            //pictureBox1.Image = imageFromStream;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtpass.Text != "")
            {

                var st = (from s in db.TabMyUsers where s.NameUser == txtname.Text select s).First();

                st.Name = txtname.Text;
                st.PasswordUser = txtpass.Text;
                
                db.SubmitChanges();
                MessageBox.Show("Successfully Updated");

                byte[] file_byte = ImageToByteArray(pictureBox1.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                var stt = new Table
                {

                    Name = this.Name,
                    UserPic = file_binary,
                };
                db.Tables.InsertOnSubmit(stt);
                db.SubmitChanges();

                MessageBox.Show("Successfully Updated");
                AAdmin_Panel AA_P = new AAdmin_Panel();
                this.Hide();
                AA_P.Show();
                
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NNewLaybour NNL = new NNewLaybour();
            this.Hide();
            NNL.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Contractor C = new Contractor();
            this.Hide();
            C.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EEmployee_Management EE_M = new EEmployee_Management();
            this.Hide();
            EE_M.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NNewEmployee NNE = new NNewEmployee();
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

        private void button15_Click(object sender, EventArgs e)
        {
            AAdmin_Panel AA_P = new AAdmin_Panel();
            this.Hide();
            AA_P.Show();
        }

        private void AAdmin_Profile_Load(object sender, EventArgs e)
        {
            label7.Text = AAdmin_Panel.SetValueForText1;
            combo1.Text = Convert.ToString(Iindex.SetValueForText2);
            txtname.Text = AAdmin_Panel.SetValueForText1;
            txtpass.Text = AAdmin_Panel.SetValueForText3;

            //for upload image
            //var st = (from s in db.Tables where s.Name == txtname.Text select s).First();
            //{

            //    if (st != null)
            //    {

            //        Name = st.Name;

            //        pictureBox1.Image = ByteArrayToImage(st.UserPic.ToArray());
            //    }

            //}


            //for display image
            var st = (from s in db.Tables where s.Name == txtname.Text select s).First();
            {

                if (st != null)
                {

                    Name = st.Name;

                    pictureBox1.Image = ByteArrayToImage(st.UserPic.ToArray());
                }

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
    }
}
