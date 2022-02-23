using ClientManagement.Controller;
using ClientManagement.Helper;
using ClientManagement.NavigationHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Views.Client
{
    public partial class frmAvailableClients : Form
    {
        public bool isSearch;
        public string SearchWord;

        readonly ClientController controller;
        readonly LookupController lookupController;

        public frmAvailableClients()
        {
            InitializeComponent();

            controller = new ClientController(ConfigurationManager.AppSettings["BaseURL"].ToString());
            lookupController = new LookupController(ConfigurationManager.AppSettings["BaseURL"].ToString());
            cExtractTypes.SelectedIndex = 0;
        }

        private void frmAvailableClients_Load(object sender, EventArgs e)
        {

        }

        private void ShowClients()
        {
            var getClientsdetails = controller.GetAllClientsWithAddress().Result;

            if (getClientsdetails.request.Success)
            {
          
                foreach (var client in getClientsdetails.response)
                {
                    StringBuilder sb = new StringBuilder();

                    var clientFullName = $"{client.Title} {client.FirstName} {client.LastName}";

                    foreach (var address in client.Addresses)
                        sb.AppendLine($" {address.Address}, {address.Suburb}, {address.Province}, {address.Code}");

                    dgvClientDetails.Rows.Add(client.ClientId, clientFullName, sb);
                }
            }
            else
            {
                MessageBox.Show(getClientsdetails.request.ErrorMessage);
            }
        }

        private void SearchClientBySearchTerm()
        {
            var getClientsdetails = controller.SmartSearch(SearchForClients.SearchWord).Result;

            if (getClientsdetails.request.Success)
            {

                foreach (var client in getClientsdetails.response)
                {
                    StringBuilder sb = new StringBuilder();

                    var clientFullName = $"{client.Title} {client.FirstName} {client.LastName}";

                    foreach (var address in client.Addresses)
                        sb.AppendLine($" {address.Address}, {address.Suburb}, {address.Province}, {address.Code}");

                    dgvClientDetails.Rows.Add(client.ClientId, clientFullName, sb);
                }
            }
            else
            {
                MessageBox.Show(getClientsdetails.request.ErrorMessage);
            }
        }

        private void frmAvailableClients_Load_1(object sender, EventArgs e)
        {
            if (!SearchForClients.isSearch)
                ShowClients();
            else
                SearchClientBySearchTerm();

            SearchForClients.isSearch = false;
        }

        private void dgvClientDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int mSelectedRowIndex = dgvClientDetails.SelectedCells[0].RowIndex;

                DataGridViewRow mSelectedRow = dgvClientDetails.Rows[mSelectedRowIndex];

                var clientId = Convert.ToInt32(mSelectedRow.Cells[0].Value);

                FormManagement.currentForm.Close();

                frmCreateUpdate form = new frmCreateUpdate();
                
                frmCreateUpdate.CreateNewClient = false;
                frmCreateUpdate.ClientId = clientId;

                form.TopLevel = false;
                FormManagement.ClientManagerView.pDisplayView.Controls.Add(form);
                form.Show();

                FormManagement.currentForm = form;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bDownload_Click(object sender, EventArgs e)
        {
            StringBuilder sb;

            switch (cExtractTypes.SelectedIndex)
            {
                case 0:

                    var getAllClients = controller.GetAllClientsWithAddress().Result;
                     sb = new StringBuilder();

                    foreach (var item in getAllClients.response)
                    {
                        var clientName = $"{item.Title} {item.FirstName} {item.LastName}";

                        foreach (var addres in item.Addresses)
                        {
                            sb.AppendLine($"{clientName} ,{addres.Address} {addres.Suburb} {addres.Province} {addres.Code}");
                        }
                    }

                    FileManager.WriteToCSVAndSave("ClientName, ClientAddress", sb.ToString());
                    break;

                case 1:

                    var getAddreses = lookupController.GetAddresses().Result;
                    if (getAddreses.request.Success)
                    {
                        sb = new StringBuilder();

                        foreach (var item in getAddreses.response)
                            sb.AppendLine(item);

                        FileManager.WriteToCSVAndSave("Address,Suburb,Province,Code", sb.ToString());
                    }

                    break;

                case 2:

                    var getContacts = lookupController.GetContactNumbers().Result;
                    if (getContacts.request.Success)
                    {
                        sb = new StringBuilder();

                        foreach (var item in getContacts.response)
                            sb.AppendLine(item);

                        FileManager.WriteToCSVAndSave("ContactNumber", sb.ToString());
                    }

                    break;

                case 3:

                    var getEmails = lookupController.GetClientEmailsAddresses().Result;
                    if (getEmails.request.Success)
                    {
                       sb = new StringBuilder();

                        foreach (var item in getEmails.response)
                            sb.AppendLine(item);

                        FileManager.WriteToCSVAndSave("Emails", sb.ToString());
                    }

                    break;

            }

        }
    }
}
