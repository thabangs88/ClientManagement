using ClientManagement.Controller;
using ClientManagement.Model.Request;
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

namespace ClientManagement.Views.Users
{
    public partial class frmCreateUser : Form
    {

        readonly UserController controller;

        public frmCreateUser()
        {
            InitializeComponent();


            controller = new UserController(ConfigurationManager.AppSettings["BaseURL"].ToString());
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                Active = cStatus.SelectedIndex == 0 ? true : false,
                AppID = 1,
                CompanyID = 1,
                FirstName = tFirstName.Text,
                LastName = tLastName.Text,
                Password = tPassword.Text,
                Username = tUsername.Text,
            };

            if (user.Password != tConfirm.Text)
                MessageBox.Show("Password does not match");

            var createUser = controller.CreateUser(user).Result;

            if(createUser.request.Success)
                MessageBox.Show(createUser.response.Message);
            else
                MessageBox.Show(createUser.request.ErrorMessage);

            this.Close();

        }
    }
}
