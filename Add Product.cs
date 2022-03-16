using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }
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


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Employee_Management EM = new Employee_Management();
            this.Hide();
            EM.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NewEmployee AE = new NewEmployee();
            this.Hide();
            AE.Show();
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            var st = new Product
            {
                ProID = txtproid.Text,
                ProName = txtproname.Text,
                ProQuality = txtproquality.Text,
                ProManufecturarName = txtmanuname.Text,
                ProQuantity = txtproquantity.Text,



            };
            db.Products.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Product Added Sussfully");
            loaddata();
        }



        private void loaddata()
        {
            ProdGV.AutoGenerateColumns = false;
            loadData();
        }

        private void loadData()
        {
            var st = from s in db.Products select s;
            dataGridView1.DataSource = st;
        }

        private void Insertinsqltable_Click(object sender, EventArgs e)
        {
            var st = (from s in db.Products where s.ProID == txtproid.Text select s).First();


            st.ProName = txtproname.Text;
            st.ProQuality = txtproquality.Text;
            st.ProManufecturarName = txtmanuname.Text;
            st.ProQuantity = txtproquantity.Text;

            db.SubmitChanges();
            MessageBox.Show("Successfully Updated");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtproname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtproquality.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtmanuname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtproquantity.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Branch_Management B_M = new Branch_Management();
            this.Hide();
            B_M.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Expence_Report E_R = new Expence_Report();
            this.Hide();
            E_R.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashIneer CI = new CashIneer();
            this.Hide();
            CI.Show();
        }
    }
}
