using MyStore.Business_Logic_Layer;
using MyStore.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore.Presentation_Layer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        LoginBLL l = new LoginBLL();
        LoginDAL dal = new LoginDAL();
        public static string loggedIn;
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //Checking the login credentials
            bool sucess = dal.loginCheck(l);
            if (sucess == true)
            {
                //Login Successfull
                MessageBox.Show("You are successfully opened your dashboard.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loggedIn = l.username;
                //Need to open Respective Forms based on User Type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //Display Admin Dashboard
                            FormAdminDashboard admin = new FormAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //Display User Dashboard
                            FormUserDashboard user = new FormUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //Display an error message
                            MessageBox.Show("Invalid User Type.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            else
            {
                //login Failed
                MessageBox.Show("Please Enter Sufficient Login Credentials ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                cmbUserType.Text = "";
            }
        }
    }
}
