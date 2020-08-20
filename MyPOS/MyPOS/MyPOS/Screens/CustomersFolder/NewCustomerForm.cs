using MyPOS.General;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyPOS.Screens.CustomersFolder
{
    public partial class NewCustomerForm : MetroFramework.Forms.MetroForm
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }
        public bool IsUpdate { get; set; }
        public int customerID { get; set; }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.CustomerID = this.customerID;
            customerInfo.Name = CustomerNameTextBox.Text;
            customerInfo.Mobile = CustomerMobileTextBox.Text;
            customerInfo.Address = CustomerAddressTextBox.Text;

            if(IsValid())
            {
                if(this.IsUpdate)
                {
                    using (MyPOSContext db = new MyPOSContext())
                    {
                        db.Entry(customerInfo).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Customer detail is updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                    }
                }
                else 
                {
                    using (MyPOSContext db = new MyPOSContext())
                    {
                        db.CustomerInfoes.Add(customerInfo);
                        db.SaveChanges();
                        MessageBox.Show("Customer detail is saved succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                    }
                }
                
            }
        }


        private bool IsValid()
        {
            if (CustomerNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerNameTextBox.Focus();
                return false;
            }
           
            return true;
        }

        private void DefineNewButton_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            CustomerNameTextBox.Clear();
            CustomerMobileTextBox.Clear();
            CustomerAddressTextBox.Clear();
            CustomerNameTextBox.Focus();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            if(this.IsUpdate)
            {
                LoadDataAndMapIntoControls();
            }
        }

        private void LoadDataAndMapIntoControls()
        {
            DataTable dtrecords = GetCustomerData();
            DataRow row;
            row = dtrecords.Rows[0];

            CustomerNameTextBox.Text = row["Name"].ToString();
            CustomerAddressTextBox.Text = row["Address"].ToString();
            CustomerMobileTextBox.Text = row["Mobile"].ToString();

        }

        private DataTable GetCustomerData()
        {
            DataTable dtdata = new DataTable();
            using(SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString1()))
            {
                using(SqlCommand cmd=new SqlCommand("usp_CustomerGetCustomerDataByCustomerID",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", this.customerID);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtdata.Load(sdr);
                }
            }
            return dtdata;
        }
    }
}
