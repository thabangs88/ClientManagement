using ClientManagement.Helper;
using ClientManagement.NavigationHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Views.Client
{
    public partial class frmSearch : Form
    {
        FormManagement formManagement = new FormManagement();
        public frmSearch()
        {
            InitializeComponent();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tSearch.Text))
            {
                MessageBox.Show("Please provide search key");

            }
            else 
            {           

                FormManagement.currentForm.Close();

                SearchForClients.isSearch = true;
                SearchForClients.SearchWord = tSearch.Text;

                frmAvailableClients form = new frmAvailableClients();

                form.TopLevel = false;
                FormManagement.ClientManagerView.pDisplayView.Controls.Add(form);
                form.Show();

                FormManagement.currentForm = form;

                tSearch.Clear();

                this.Close();
            }


        }
    }
}
