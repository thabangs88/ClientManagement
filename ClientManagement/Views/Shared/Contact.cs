using ClientManagement.Helper;
using ClientManagement.Views.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Views.Shared
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
            cContactType.SelectedIndex = 0;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tContact.Text))
            {
                MessageBox.Show("Please provide contact number");
            }
            else 
            {
                ContactCache.Type = cContactType.Text;
                ContactCache.Number = tContact.Text;
                this.Close();
            }
        }

        private void tContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
