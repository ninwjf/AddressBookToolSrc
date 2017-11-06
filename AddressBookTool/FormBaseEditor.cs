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
    public partial class FormBaseEditor : AddressBookTool.FormBase
    {
        protected enum STATUS
        {
            READ_MODE,
            CREATE_MODE,
            UPDATE_MODE
        }

        protected STATUS m_Status;

        public FormBaseEditor()
        {
            InitializeComponent();
        }

        private void FormBaseEditor_Load(object sender, EventArgs e)
        {
            m_Status = STATUS.READ_MODE;
            SetControls();
            SetButtons();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            DataRowView row = bindingSource.AddNew() as DataRowView;
            m_Status = STATUS.CREATE_MODE;
            SetControls();
            SetDefaultValue(row);
            SetButtons();
        }

        protected virtual void SetDefaultValue(DataRowView row) {}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            m_Status = STATUS.UPDATE_MODE;
            
            SetControls();
            SetButtons();
        }

        protected virtual void btnDelete_Click(object sender, EventArgs e) { }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (this.ValidateCurrentRow())
            {
                addrList.AcceptChanges();
                m_Status = STATUS.READ_MODE;
                SetControls();
            }
            DisplayErrors();
            SetButtons();
        }

        private bool ValidateCurrentRow()
        {
            bool result = true;
            DataRowView currentView = (DataRowView)this.bindingSource.Current;

            if (currentView != null)
            {
                this.Validate();

                DataRow currentRow = currentView.Row;

                foreach (DataColumn column in currentRow.Table.Columns)
                {
                    if (!column.AllowDBNull && currentRow.IsNull(column))
                    {
                        //This column must contain a value and is currently null.
                        currentRow.SetColumnError(column, "資料不能為空");
                    }
                }

                try
                {
                    if (currentRow.GetColumnsInError().Length == 0)
                    {
                        currentRow.ClearErrors();
                    }
                    currentView.EndEdit();
                }
                catch (Exception e)
                {
                    currentRow.RowError = e.Message;
                    result = false;
                }
                if (currentRow.HasErrors)
                    result = false;
            }

            return result;
        }

        private void DisplayErrors()
        {
            this.errorProvider.UpdateBinding();
            AfterDisplayErrors();
            if (this.bindingSource.Position > -1)
            {
                DataRowView  currentRow = (DataRowView)this.bindingSource.Current;
                if (!String.IsNullOrEmpty(currentRow.Row.RowError))
                    MessageBox.Show(currentRow.Row.RowError);
            }
        }

        protected virtual void AfterDisplayErrors() {}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (m_Status == STATUS.CREATE_MODE)
                bindingSource.RemoveCurrent();
            bindingSource.CancelEdit();
            m_Status = STATUS.READ_MODE;
            SetControls();
            SetButtons();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void SetButtons()
        {
            btnFirst.Enabled        = 
            btnPrev.Enabled         = (m_Status == STATUS.READ_MODE) && (bindingSource != null) && (bindingSource.Position > 0);
            btnNext.Enabled         =
            btnLast.Enabled         = (m_Status == STATUS.READ_MODE) && (bindingSource != null) && (bindingSource.Position < (bindingSource.List.Count - 1));

            btnDelete.Enabled       =
            btnEdit.Enabled         = (m_Status == STATUS.READ_MODE) && (bindingSource != null) && (bindingSource.List.Count > 0);
            lblCount.Enabled        =
            txtboxPosition.Enabled  = (m_Status == STATUS.READ_MODE) && (bindingSource != null) && (bindingSource.List.Count > 1);
            btnAddNew.Enabled       = (m_Status == STATUS.READ_MODE);// && allowAddNew;
            btnCancel.Enabled       = (m_Status != STATUS.READ_MODE);// && (primaryID != "") && allowDelete;
            btnSaveChange.Enabled   = (m_Status != STATUS.READ_MODE);
        }

        protected virtual void SetControls() {}
    }
}
