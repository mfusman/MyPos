using MyPOS.Screens.CustomersFolder;
using MyPOS.Screens.ProductsFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPOS.Screens
{
    public partial class DashboardForm : MetroFramework.Forms.MetroForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ProductsRecordForm prd = new ProductsRecordForm();
            prd.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void DefineProductsButton_Click(object sender, EventArgs e)
        {
            DefineProductScreen dps = new DefineProductScreen();
            dps.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            NewCustomerForm ncf = new NewCustomerForm();
            ncf.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRecordButton_Click(object sender, EventArgs e)
        {
            CustomerRecordForm crf = new CustomerRecordForm();
            crf.Show();
        }
    }
}
