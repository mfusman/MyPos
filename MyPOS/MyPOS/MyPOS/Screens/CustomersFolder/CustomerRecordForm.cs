using MyPOS.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPOS.Screens.CustomersFolder
{
    public partial class CustomerRecordForm : MetroFramework.Forms.MetroForm
    {
        public CustomerRecordForm()
        {
            InitializeComponent();
        }

        private void CustomerRecordForm_Load(object sender, EventArgs e)
        {
            LoadCustomersData();
        }

        private void LoadCustomersData()
        {
            CustomerDataGridView.DataSource = GetData();
            CustomerDataGridView.Columns[0].Visible = false;
        }

        private DataTable GetData()
        {
            DataTable dtdata = new DataTable();
            using(SqlConnection con =new SqlConnection(ApplicationSettings.ConnectionString1()) )
            {
                using(SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerInfo",con))
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtdata.Load(sdr);
                }
            }
            return dtdata;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(CustomerNameTextBox.Text.Trim()==string.Empty)
            {
                LoadCustomersData();
            }
            else 
            {
                CustomerDataGridView.DataSource = SearchCustomerDetailsByCustomerName();
                CustomerDataGridView.Columns[0].Visible = false;
            }
        }

        private DataTable SearchCustomerDetailsByCustomerName()
        {
            DataTable dtdata = new DataTable();
            using(SqlConnection con= new SqlConnection(ApplicationSettings.ConnectionString1()))
            {
               using(SqlCommand cmd = new SqlCommand("SELECT CustomerID,Name,Mobile,Address FROM CustomerInfo WHERE Name LIKE + '%' + @Name + '%' ",con))
                {
                    cmd.Parameters.AddWithValue("@Name", CustomerNameTextBox.Text);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtdata.Load(sdr);
                }
            }
            return dtdata;
        }

        private void CustomerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                int row = CustomerDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int customerID = Convert.ToInt32(CustomerDataGridView.Rows[row].Cells[0].Value);

                if(customerID > 0)
                {
                    NewCustomerForm ncf = new NewCustomerForm();
                    ncf.IsUpdate = true;
                    ncf.customerID = customerID;
                    ncf.ShowDialog();
                    LoadCustomersData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
