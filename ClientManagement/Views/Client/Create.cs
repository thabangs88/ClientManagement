
using ClientManagement.Helper;
using ClientManagement.Model.Request;
using ClientManagement.NavigationHelper;
using ClientManagement.Views.Shared;
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

namespace ClientManagement.Views.Client
{
    public partial class frmCreateUpdate : Form
    {
        public static bool CreateNewClient;
        public static int? ClientId = 0;

        readonly ClientController controller;

        public frmCreateUpdate()
        {
            InitializeComponent();
            cGender.SelectedIndex = 0;
            cTitle.SelectedIndex = 0;

            controller = new ClientController(ConfigurationManager.AppSettings["BaseURL"].ToString());
        }

        private void EditClient()
        {
            var getClient = controller.GetClientInfoById(ClientId).Result;

            if (getClient.request.Success)
            {
                var client = getClient.response;

                tFirstName.Text = client.FirstName;
                tLastName.Text = client.LastName;
                tEmail.Text = client.Email;
                cTitle.Text = client.Title;
                cGender.Text = client.Gender;
                tIDNumber.Text = client.IdNumber;

                foreach (var item in client.Addresses)
                    dgvAddress.Rows.Add(item.Address, item.Suburb, item.Province, item.Code,item.ID);

                foreach (var item in client.Contacts)
                    dgvContact.Rows.Add(item.Type, item.ContactNo, item.ID);

            }
            else
                MessageBox.Show(getClient.request.ErrorMessage);

        }

        private void bContact_Click(object sender, EventArgs e)
        {
            frmContact form = new frmContact();
            form.ShowDialog();
            dgvContact.Rows.Add(ContactCache.Type, ContactCache.Number);
        }

        private void bAddress_Click(object sender, EventArgs e)
        {
            frmAddress   form = new frmAddress();
            form.ShowDialog();
            dgvAddress.Rows.Add(AddressCache.Address, AddressCache.Suburb, AddressCache.Province, AddressCache.Code);

        }

        private void bSave_Click(object sender, EventArgs e)
        {

                List<ContactInfo> contacts = new List<ContactInfo>();

                foreach (DataGridViewRow row in dgvContact.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        contacts.Add(new ContactInfo()
                        {
                            ContactNo = row.Cells[1].Value.ToString(),
                            Type = row.Cells[0].Value.ToString(),
                        });
                    }
                }

                List<AddressInfo> adddresses = new List<AddressInfo>();

                foreach (DataGridViewRow row in dgvAddress.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        adddresses.Add(new AddressInfo()
                        {
                            Address = row.Cells[0].Value.ToString(),
                            Suburb = row.Cells[1].Value.ToString(),
                            Province = row.Cells[2].Value.ToString(),
                            Code = row.Cells[3].Value.ToString(),
                        });
                    }
                }

                ClientInfo client = new ClientInfo()
                {
                    FirstName = tFirstName.Text,
                    Gender = cGender.Text,
                    Email = tEmail.Text,
                    IdNumber = tIDNumber.Text,
                    Title = cTitle.Text,
                    LastName = tLastName.Text,
                    Contacts = contacts,
                    Addresses = adddresses
                };

            // MasterData
            if (CreateNewClient)
            {
                var create = controller.CreateClient(client).Result;

                if (create.request.Success)
                {
                    MessageBox.Show(create.response.Message);

                    FormManagement.currentForm.Close();

                    frmAvailableClients form = new frmAvailableClients();
                    form.TopLevel = false;

                    FormManagement.ClientManagerView.pDisplayView.Controls.Add(form);
                    form.Show();

                    FormManagement.currentForm = form;
                }
                else
                    MessageBox.Show(create.request.ErrorMessage);
            }
            else 
            {
                client.ClientId = ClientId;
                var update = controller.UpdateClient(client).Result;

                if (update.request.Success)
                {
                    MessageBox.Show(update.response.Message);
                    
                    FormManagement.currentForm.Close();

                    frmAvailableClients form = new frmAvailableClients();
                    form.TopLevel = false;

                    FormManagement.ClientManagerView.pDisplayView.Controls.Add(form);
                    form.Show();

                    FormManagement.currentForm = form;

                }
                else
                    MessageBox.Show(update.request.ErrorMessage);
            }

               
           
        }

        private void frmCreateUpdate_Load(object sender, EventArgs e)
        {
            if (!CreateNewClient)
            {
                EditClient();
            }
        }

        private void dgvContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int mSelectedRowIndex = dgvContact.SelectedCells[0].RowIndex;

            DataGridViewRow mSelectedRow = dgvContact.Rows[mSelectedRowIndex];

            var addressId = Convert.ToInt32(mSelectedRow.Cells["ContactId"].Value);

            if (addressId > 0)
            {
                string message = "Are you sure you want to remove the contact number?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    var removeAddress = controller.DeleteClientContact(ClientId, addressId).Result;

                    MessageBox.Show(removeAddress.response.Message);
                    dgvContact.Rows.RemoveAt(mSelectedRowIndex);

                }
            }
        }

        private void dgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int mSelectedRowIndex = dgvAddress.SelectedCells[0].RowIndex;

            DataGridViewRow mSelectedRow = dgvAddress.Rows[mSelectedRowIndex];

            var addressId = Convert.ToInt32(mSelectedRow.Cells["AddressID"].Value);

            if (addressId > 0)
            {
                string message = "Are you sure you want to remove the address?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    var removeAddress = controller.DeleteClientAddress(ClientId, addressId).Result;

                    MessageBox.Show(removeAddress.response.Message);
                    dgvAddress.Rows.RemoveAt(mSelectedRowIndex);

                }
            }
        }
    }
}
