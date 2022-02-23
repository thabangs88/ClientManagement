using ClientManagement.Controller;
using ClientManagement.Helper;
using ClientManagement.Model.Request;
using ClientManagement.NavigationHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Views
{
    public partial class frmLogin : Form
    {
        readonly AuthenticationController controller;

        public frmLogin()
        {
            InitializeComponent();

            controller = new AuthenticationController(ConfigurationManager.AppSettings["BaseURL"].ToString());
        }

        private void bLogin_Click(object sender, EventArgs e)
        {

            try
            {

                    var result = controller.AuthorizeUser(new UserInfo()
                    {
                        Username = tUserName.Text,
                        Password = tPassword.Text
                    }).Result;

                    if (result.request.Success)
                    {
                    UserStatus.Token = result.response.access_token;

                        FormManagement.MainView.bLogin.Text = "Sign Out";
                        FormManagement.MainView.pWelcome.Hide();
                          UserStatus.isUSerOnline = true;

                        FormManagement.ClientManagerView.TopLevel = false;
                        FormManagement.MainView.pnlMain.Controls.Add(FormManagement.ClientManagerView);

                        FormManagement.ClientManagerView.Show();

                         FormManagement.currentForm.Close();

                    this.Close();
                    }
                    else
                        MessageBox.Show(result.request.ErrorMessage);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
