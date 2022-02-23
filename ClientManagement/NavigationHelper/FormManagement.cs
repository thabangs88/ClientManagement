using ClientManagement.Views;
using ClientManagement.Views.Client;
using ClientManagement.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.NavigationHelper
{
    public class FormManagement
    {
        public static Form currentForm = new Form();

        #region Login
        public static frmLogin LoginView = new frmLogin();
        #endregion

        #region Shared

        public static frmAddress AddressView = new frmAddress();
        public static frmContact ContactCiew = new frmContact();
        public static frmSearch SearchView = new frmSearch();
        #endregion


        #region Clients

        public static frmAvailableClients AvailableClientsView = new frmAvailableClients();
        public static frmCreateUpdate CreateUpdateView = new frmCreateUpdate();
        public static frmClientManager ClientManagerView = new frmClientManager();

        #endregion

        #region Main

        public static frmMain MainView = new frmMain();

        #endregion

        public Form GetForm(Form form)
        {
            form = new Form();
            form.TopLevel = false;

            return form;
        }

    }
}
