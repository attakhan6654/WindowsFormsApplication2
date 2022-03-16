using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class NNewEmployee : Form
    {
        public NNewEmployee()
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

        private void bttn2_Click(object sender, EventArgs e)
        {
            if (txtempfname.Text != "" && txtemplstname.Text != "" && txtuname.Text != "" && txtempadress.Text != "" && txtempph.Text != "" && EmpEduCb.Text != "" && txtvendob.Text != "" && EmpGenCb.Text != "" && textempemerno.Text != "" && textblodgroup.Text != "" && EmpMartialStatusCb.Text != "" && txtempsalary.Text != "")
            {

                var st = new EEmployee
                {
                    //EmpIds = Convert.ToInt32(textempid.Text),
                    EmpFNames = txtempfname.Text,
                    EmpLNames = txtemplstname.Text,
                    EmpUserNames = txtuname.Text,
                    EmpAdds = txtempadress.Text,
                    EmpPhones = txtempph.Text,
                    EmpCnics = txtempcnic.Text,
                    EmpEdus = EmpEduCb.Text,
                    EmpExps = textempexp.Text,
                    EmpDobs = txtvendob.Text,
                    EmpGens = EmpGenCb.Text,
                    EmpEmerNos = textempemerno.Text,
                    EmpBloodGroups = textblodgroup.Text,
                    EmpMartialStatuss = EmpMartialStatusCb.Text,
                    //EmpSalary = Convert.ToDouble(txtempsalary.Text),

                };
                db.EEmployees.InsertOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("Regestered Sussfully");
                loaddata();
            }
        }

        private void loaddata()
        {
            ProdGV.AutoGenerateColumns = false;
            loadData();
        }

        private void loadData()
        {
            var st = from s in db.EEmployees select s;
            dataGridView1.DataSource = st;
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            if (txtempfname.Text != "" && txtemplstname.Text != "" && txtuname.Text != "" && txtempadress.Text != "" && txtempph.Text != "" && txtempcnic.Text != "" && EmpEduCb.Text != "" && textempexp.Text != "" /* && txtvendob.Text != "" */ && EmpGenCb.Text != "" && textempemerno.Text != "" && textblodgroup.Text != "" && EmpMartialStatusCb.Text != "" && txtempsalary.Text != "")
            {
                var st = (from s in db.EEmployees where s.EmpUserNames == txtuname.Text && s.EmpFNames == txtempfname.Text && s.EmpLNames == txtemplstname.Text && s.EmpAdds == txtempadress.Text && s.EmpPhones == txtempph.Text && s.EmpCnics == txtempcnic.Text && s.EmpEdus == EmpEduCb.Text && s.EmpExps == textempexp.Text && /* s.EmpDobs == txtvendob.Text && */ s.EmpGens == EmpGenCb.Text && s.EmpEmerNos == textempemerno.Text && s.EmpBloodGroups == textblodgroup.Text && s.EmpMartialStatuss == EmpMartialStatusCb.Text && s.EmpMartialStatuss == txtempsalary.Text select s).First();
                db.EEmployees.DeleteOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("Deleted Sussfully");
                loaddata();
                
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            EEmployee_Management EE_M = new EEmployee_Management();
            this.Hide();
            EE_M.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NNewEmployee NNE = new NNewEmployee();
            this.Hide();
            NNE.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            CCashInner CCI = new CCashInner();
            this.Hide();
            CCI.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            CCashOuter CCO = new CCashOuter();
            this.Hide();
            CCO.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            NNewCoustomer NNC = new NNewCoustomer();
            this.Hide();
            NNC.Show();
        }

        private void button19_Click(object sender, EventArgs e)
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

        private void button18_Click(object sender, EventArgs e)
        {
            CashIHand CIH = new CashIHand();
            this.Hide();
            CIH.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            NNewLaybour NNL = new NNewLaybour();
            this.Hide();
            NNL.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Contractor C = new Contractor();
            this.Hide();
            C.Show();

        }

        private void NNewEmployee_Load(object sender, EventArgs e)
        {
            //using (NorthwindEntities db = new NorthwindEntities()) {
            //    EEmployeeBindingSource.DtaSource = db.EEmployees.ToList();

            
            //}
            //data lod in gridview1
            var st = from s in db.EEmployees select s;
            dataGridView1.DataSource = st;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtempid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtempfname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtemplstname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtuname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtempadress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtempph.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtempcnic.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            EmpEduCb.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textempexp.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            //txtvendob.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            EmpGenCb.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textempemerno.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            textblodgroup.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            EmpMartialStatusCb.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            txtempsalary.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RReport R = new RReport();
            this.Hide();
            R.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            LLabour_Management LL_M = new LLabour_Management();
            this.Hide();
            LL_M.Show();
        }

        private void Insertinsqltable_Click(object sender, EventArgs e)
        {

        }
    }

    //private void bttn4_Click(object sender, EventArgs e)
    //    {
            
    //    }

    //    private void Edit_Click(object sender, EventArgs e)
    //    {

    //    }

    //    private void Insertinsqltable_Click(object sender, EventArgs e)
    //    {

    //    }
    }
