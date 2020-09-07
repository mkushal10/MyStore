using MyStore.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class FormUserDashboard : Form
    {
        public FormUserDashboard()
        {
            InitializeComponent();
        }

        private void FormUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void FormUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = FormLogin.loggedIn;
        }
    }
}
