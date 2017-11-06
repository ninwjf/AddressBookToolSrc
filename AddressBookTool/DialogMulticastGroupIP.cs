using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddressBookTool
{
    public partial class DialogMulticastGroupIP : AddressBookTool.DialogBase
    {
        public string IP = null;
        const string NULL_IP = "(null)";

        public DialogMulticastGroupIP()
        {
            InitializeComponent();
        }

        private void DialogMulticastGroupIP_Load(object sender, EventArgs e)
        {
            string fieldName = "ip";
            // sort the IP column
            var queryResult = addrList.multicastGroup.AsEnumerable()
                .OrderBy(device => device.Field<string>(fieldName), new IPComparer())
                .Select(device => new { Text = device.Field<string>(fieldName) });
            // first, add a null row
            this.dataGridView.Rows.Add(new Object[] { NULL_IP });
            if (queryResult != null)
            {
                foreach (var ip in queryResult)
                {
                    int rowIndex = this.dataGridView.Rows.Add(new Object[] { ip.Text });
                    if (this.IP == ip.Text)
                    {
                        this.dataGridView.Rows[rowIndex].Cells[0].Selected = true;
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StoreSelectedIPAddressAndAllowFormToBeClosed();
        }

        private void StoreSelectedIPAddressAndAllowFormToBeClosed()
        {
            var cell = dataGridView.SelectedCells[0];
            IP = ((string)cell.Value != NULL_IP) ? (string)cell.Value : null;
            AllowClose = true;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
            StoreSelectedIPAddressAndAllowFormToBeClosed();
            this.Close();
        }
    }
}
