﻿using MyStore.Presentation_Layer;
using MyStore.User_Interface;
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
    public partial class FormAdminDashboard : Form
    {
        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        //click event
        //adding form name to open the form
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = new FormUsers();
            form2.Show();//Display the next form window
        }

        private void FormAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = FormLogin.loggedIn;
        }
    }
}
