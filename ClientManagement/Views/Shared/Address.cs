using ClientManagement.Helper;
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
    public partial class frmAddress : Form
    {
        public frmAddress()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tAddress.Text) ||
               string.IsNullOrEmpty(tSuburb.Text) ||
               string.IsNullOrEmpty(tProvince.Text) ||
               string.IsNullOrEmpty(tCode.Text))
            {
                MessageBox.Show("Please provide all address information");
            }
            else 
            {
                AddressCache.Address = tAddress.Text;
                AddressCache.Suburb = tSuburb.Text;
                AddressCache.Province = tProvince.Text;
                AddressCache.Code = tCode.Text;
                this.Close();
            }
        }
    }
}
