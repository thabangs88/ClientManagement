using ClientManagement.NavigationHelper;
using ClientManagement.Views.Client;
using ClientManagement.Views.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Views
{
    public partial class frmClientManager : Form
    {
        public frmClientManager()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bSearchClient_Click(object sender, EventArgs e)
        {
            FormManagement.SearchView.ShowDialog();
        }

        private void bCreateClient_Click(object sender, EventArgs e)
        {
            

            FormManagement.currentForm.Close();

            frmCreateUpdate form = new frmCreateUpdate();
            frmCreateUpdate.CreateNewClient = true;

            form.TopLevel = false;
            pDisplayView.Controls.Add(form);
            form.Show();

            FormManagement.currentForm = form;
        }

        private void bViewAllClients_Click(object sender, EventArgs e)
        {
            FormManagement.currentForm.Close();

            frmAvailableClients form = new frmAvailableClients();

            form.TopLevel = false;
            pDisplayView.Controls.Add(form);
            form.Show();

            FormManagement.currentForm = form;
        }

        private void bCreateUser_Click(object sender, EventArgs e)
        {
            FormManagement.currentForm.Close();

            frmCreateUser form = new frmCreateUser();

            form.TopLevel = false;
            pDisplayView.Controls.Add(form);
            form.Show();

            FormManagement.currentForm = form;
        }
    }
}
