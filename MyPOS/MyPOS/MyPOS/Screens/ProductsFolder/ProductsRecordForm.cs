using MyPOS.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPOS.Screens.ProductsFolder
{
    public partial class ProductsRecordForm : MetroFramework.Forms.MetroForm
    {
        public ProductsRecordForm()
        {
            InitializeComponent();
        }

       
        private void LoadAllProductIntoDataGridView()
        {
            if(ProductsDataGridView.Columns.Contains("Delete"))
            {
                ProductsDataGridView.Columns.Remove("Delete");
            }
            ProductsDataGridView.DataSource = GetData();
            ProductsDataGridView.Columns[0].Visible = false;
            
            DataGridViewButtonColumn dv = new DataGridViewButtonColumn();
            dv.HeaderText = "Delete";
            dv.Name = "Delete";
            ProductsDataGridView.Columns.Add(dv);
        }

        private object GetData()
        {
            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString1()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_Products_LoadAllProductsForDataGridView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                }
            }
            return dtrecord;
        }

        private void ProductsRecordForm_Load(object sender, EventArgs e)
        {
            LoadAllProductIntoDataGridView();
            ProductNameTextBox.Focus();
        }

       
        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(ProductNameTextBox.Text.Trim()==string.Empty)
            {
                LoadAllProductIntoDataGridView();
            }
            else
            {
                ProductsDataGridView.DataSource  = GetProductByProductId();
            }
        }

        private DataTable GetProductByProductId()
        {
            DataTable dtrecord = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString1()))
            {
                using (SqlCommand cmd = new SqlCommand("ups_Products_LoadAllProductsByProductName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", ProductNameTextBox.Text.Trim());
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecord.Load(sdr);
                }
            }
            return dtrecord;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SizeID = 0;
            if (ProductsDataGridView.CurrentCell.ColumnIndex==7)
            {
                int _id= Convert.ToInt32(ProductsDataGridView.SelectedRows[0].Cells[0].Value);
                string _Sizes = Convert.ToString(ProductsDataGridView.SelectedRows[0].Cells[6].Value);
               
                

                char size1stChar = Convert.ToChar(_Sizes.First());
                switch (size1stChar)
                    {
                        case '1':
                            SizeID = 1;
                            break;

                        case '2':
                            SizeID = 2;
                            break;

                        case '3':
                            SizeID = 3;
                            break;

                        case '4':
                            SizeID = 4;
                            break;

                        case '5':
                            SizeID = 5;
                            break;

                        case '6':
                            SizeID = 6;
                            break;
                        default:

                            break;
                    }


                if (_id>0)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString1()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_Products_DeleteProductAndSizes", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ProductID", _id);
                            cmd.Parameters.AddWithValue("@SizeID", SizeID);

                            

                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("product no. " + _id.ToString() +" and it's SizeID is "+SizeID+" is deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //remove from grid
                            LoadAllProductIntoDataGridView();
                        }
                    }


                }
            }
        }
    }
    }
