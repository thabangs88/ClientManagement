using ClientManagement.Helper;
using ClientManagement.NavigationHelper;
using ClientManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        public static bool isOnline;

        private void bLogin_Click(object sender, EventArgs e)
        {

            if (!UserStatus.isUSerOnline)
            {
                FormManagement.LoginView.ShowDialog();
            }
            else
            {
                UserStatus.isUSerOnline = false;

                FormManagement.currentForm.Close();

                FormManagement.ClientManagerView.Hide();
                FormManagement.MainView.pWelcome.Show();
                FormManagement.MainView.bLogin.Text = "Sign In";
                FormManagement.MainView.pWelcome.Show();

            }


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FormManagement.MainView = this;
          //  this.TopLevel = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://unisource.co.za");
            Process.Start(sInfo);
        }
    }
}
