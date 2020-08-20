using MyPOS.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyPOS.Screens
{ 
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       
        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using(SqlConnection con=new SqlConnection(ApplicationSettings.ConnectionString1()))
                {
                    using(SqlCommand cmd= new SqlCommand("usp_Login_verifyLoginDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName",UserNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password",PasswordTextBox.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        if(sdr.Read())
                        {
                            //MessageBox.Show("Wel Come");
                            this.Hide();
                            DashboardForm df = new DashboardForm();
                            df.Show();
                        }
                        else 
                        {
                            MessageBox.Show("User Name or Password is incorrect","login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            UserNameTextBox.Focus();
                        }
                    }
                }
                //string constring = ApplicationSettings.ConnectionString();
                //MessageBox.Show(constring);
            }

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private bool IsValid()
        {
            if(UserNameTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("User Name is required!","Form validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Focus();
                return false;
            }
            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required!", "Form validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Focus();
                return false;
            }
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
