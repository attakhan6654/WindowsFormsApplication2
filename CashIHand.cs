﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CashIHand : Form
    {
        public CashIHand()
        {
            InitializeComponent();
        }
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


        private void bttn2_Click(object sender, EventArgs e)
        {
            if (txttotalamount.Text != "" && txtlayberpayment.Text != "" && txtperdayexpence.Text != "")
            {
                var stt = new CashInHand
                {
                    TotalsAmount = int.Parse(txttotalamount.Text),
                    LabourPayment = double.Parse(txtlayberpayment.Text),
                    PerdayExpence = double.Parse(txtperdayexpence.Text),

                };
                db.CashInHands.InsertOnSubmit(stt);
                db.SubmitChanges();
                MessageBox.Show("Data Inserted");
                loaddata();
            }
        }

        private void loaddata()
        {
            //ProdGV.AutoGenerateColumns = false;
            loadData();
        }

        private void loadData()
        {
            var st = from s in db.CashInHands select s;
            dataGridView1.DataSource = st;
        }

        private void bttn4_Click(object sender, EventArgs e)
        {if (txttotalamount.Text != "" && txtlayberpayment.Text != "" && txtperdayexpence.Text!="")
            {
                var st = (from s in db.CashInHands where s.TotalsAmount == int.Parse(txttotalamount.Text) &&   s.LabourPayment == int.Parse(txtlayberpayment.Text) && s.PerdayExpence == int.Parse(txtperdayexpence.Text) select s).First();
                db.CashInHands.DeleteOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("Successfully Deleted...");
                loaddata();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NNewLaybour NNL = new NNewLaybour();
            this.Hide();
            NNL.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Contractor C = new Contractor();
            this.Hide();
            C.Show();
        }

        private void CashIHand_Load(object sender, EventArgs e)
        {
            var st = from s in db.CashInHands select s;
            dataGridView1.DataSource = st;
        }

        private void ProdGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AAdmin_Panel AA_P = new AAdmin_Panel();
            this.Hide();
            AA_P.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Iindex Ii = new Iindex();
            this.Hide();
            Ii.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttotalamount.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtlayberpayment.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtperdayexpence.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

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

        private void button7_Click(object sender, EventArgs e)
        {
            NNewCoustomer NNC = new NNewCoustomer();
            this.Hide();
            NNC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NNewUser NNU = new NNewUser();
            this.Hide();
            NNU.Show();
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
