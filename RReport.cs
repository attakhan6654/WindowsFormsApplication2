using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication2
{
    public partial class RReport : Form
    {
        public RReport()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ManagementEEmployee ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void RReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ManagementEEmployee ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from ManagementLLabour ", con);
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                daa.Fill(dtt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dtt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report2.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from TabMyCus ", con);
                SqlDataAdapter daaa = new SqlDataAdapter(cmd);
                DataTable dttt = new DataTable();
                daaa.Fill(dttt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dttt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report3.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            CashIHand CIH = new CashIHand();
            this.Hide();
            CIH.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NNewLaybour NNL = new NNewLaybour();
            this.Hide();
            NNL.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            LLabour_Management LL_M = new LLabour_Management();
            this.Hide();
            LL_M.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Contractor C = new Contractor();
            this.Hide();
            C.Show();
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

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from ManagementLLabour where LabourAddress = '"+comboBox1.Text+"'", con);
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                daa.Fill(dtt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dtt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report2.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ManagementEEmployee where EmpWorkingPlace = '"+comboBox2.Text+"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from TabMyCus where AddressCus = '"+comboBox3.Text+"'", con);
                SqlDataAdapter daaa = new SqlDataAdapter(cmd);
                DataTable dttt = new DataTable();
                daaa.Fill(dttt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dttt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report3.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from OutCashe ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report4.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AttaKhan009;Initial Catalog=administrator;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from OutCash where CashTotals = '" + comboBox4.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"C:\Users\attak\Documents\Visual Studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Report4.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
