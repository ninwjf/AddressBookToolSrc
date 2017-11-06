using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookTool
{
    public partial class FormMulticastGroupIP : AddressBookTool.FormBaseEditor
    {
        public FormMulticastGroupIP()
        {
            InitializeComponent();
        }
        
        protected override void SetControls()
        {
            ipTextBox.Enabled =
                (m_Status != STATUS.READ_MODE);
            multicastGroupDataGridView.Enabled = (m_Status == STATUS.READ_MODE);
        }

        protected override void AfterDisplayErrors()
        {
            this.multicastGroupDataGridView.Refresh();
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO 多國語系對話框
            DataGridView dataGridView = multicastGroupDataGridView;
            if (MessageBox.Show(
                String.Format("您確定要刪除{0}筆資料？", dataGridView.SelectedRows.Count),
                "",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    DataRowView dataRow = (DataRowView)row.DataBoundItem;
                    dataRow.Delete();
                }
                addrList.dev.AcceptChanges();
                if (dataGridView.CurrentRow != null)
                    dataGridView.CurrentRow.Selected = true;
            }
        }
    }
}
