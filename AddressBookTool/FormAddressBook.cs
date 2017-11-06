using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AddressBookTool
{
    public partial class FormAddressBook : AddressBookTool.FormBase
    {
        protected override void OnLoad(EventArgs e)
        {
            // add a button inside a textbox
            TextBox textBox = groupIpTextBox;
            var btn = new Button();
            btn.Size = new Size(25, textBox.ClientSize.Height + 2);
            btn.Location = new Point(textBox.ClientSize.Width - btn.Width, -1);
            btn.Cursor = Cursors.Default;
            btn.Text = "...";
            btn.Click += btnGroupIP_Click;
            textBox.Controls.Add(btn);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(textBox.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));

            base.OnLoad(e);
        }

        void btnGroupIP_Click(object sender, EventArgs e)
        {
            DialogMulticastGroupIP dlg = new DialogMulticastGroupIP();
            dlg.IP = this.groupIpTextBox.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.groupIpTextBox.Text = dlg.IP;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        void CreateDeviceTypeList()
        {
            byte i = 0;
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "管理中心"));		//Control Server
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "门口摄像头"));	//Door Camera
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "单元门口机"));	//Lobby Phone (Unit)
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "楼栋门口机"));	//Lobby Phone (Building)
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "小区门口机"));	//Lobby Phone (Area)
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "分机"));			//Indoor Phone
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "管理机"));		//Administrator Unit
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "分机带SD卡"));	//Indoor Phone (SD)
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "手机"));			//Mobile Phone
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "紧急对讲机"));	//Emergency Intercom Unit
            this.deviceTypesBindingSource.Add(new DeviceType(i++, "IP摄像头"));		//IP CAM
        }

        enum STATUS
        {
            READ_MODE,
            CREATE_MODE,
            UPDATE_MODE
        }

        STATUS m_Status;

        public FormAddressBook()
        {
            InitializeComponent();

            CreateDeviceTypeList();
        }

        private void FormAddressBook_Load(object sender, EventArgs e)
        {
            m_Status = STATUS.READ_MODE;
            // TODO a better device address UI control
            SetControls();
            SetButtons();

            //Debug.WriteLine("{0} navigatior: {1}", 
            //    System.Reflection.MethodBase.GetCurrentMethod().Name, 
            //    addrList_devDataTableBindingNavigator.);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            m_Status = STATUS.CREATE_MODE;
            SetControls();
            SetDefaultValue();
            SetButtons();
        }

        private void SetDefaultValue()
        {
            DataRowView row = bindingSource.AddNew() as DataRowView;
            AddrList.devRow device = row.Row as AddrList.devRow;

            // set dynamic default values here+
            ipTextBox.Text         = device.ip = addrList.dev.GetDefaultIP();
            subnetMaskTextBox.Text = device.sm = addrList.dev.GetDefaultSubnetMask();
            gatewayTextBox.Text    = device.gw = addrList.dev.GetDefaultGateway();
            // set dynamic default values here-
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            m_Status = STATUS.UPDATE_MODE;
            
            SetControls();
            SetButtons();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO 多國語系對話框
            DataGridView dataGridView = devDataTableDataGridView;
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
                SetTreeView();
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (this.ValidateCurrentRow())
            {
                addrList.AcceptChanges();
                m_Status = STATUS.READ_MODE;
                SetControls();
                SetTreeView();
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
                    //currentRow.
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

        protected void AfterDisplayErrors() 
        {
            this.devDataTableDataGridView.Refresh();
        }

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

            btnExport.Enabled       =
            btnExportPkg.Enabled    =
            btnDelete.Enabled       =
            btnEdit.Enabled         = (m_Status == STATUS.READ_MODE) && (bindingSource != null) && (bindingSource.List.Count > 0);
            lblCount.Enabled        =
            txtboxPosition.Enabled  = (m_Status == STATUS.READ_MODE) && (bindingSource != null) && (bindingSource.List.Count > 1);
            btnAddNew.Enabled       = (m_Status == STATUS.READ_MODE);// && allowAddNew;
            btnCancel.Enabled       = (m_Status != STATUS.READ_MODE);// && (primaryID != "") && allowDelete;
            btnSaveChange.Enabled   = (m_Status != STATUS.READ_MODE);
            btnImport.Enabled       = (m_Status == STATUS.READ_MODE);
        }

        private void SetTreeView()
        {
            Cursor.Current = Cursors.WaitCursor;

            string a = addrList.GetXml();
            var groupedData = from device in addrList.dev.AsEnumerable()
                              group device by device.ro.Substring(0, 2) into address
                              select new
                              {
                                  Key = address.Key,
                                  Count = address.Count()
                              };
            treeViewAddress.Nodes.Clear();
            foreach (var address in groupedData)
            {
                TreeNode node = new TreeNode(address.Key);
                node.Tag = node.ToolTipText = address.Key;
                treeViewAddress.Nodes.Add(node);
                node.Nodes.Add("");
            }
            treeViewAddress.BeforeExpand += treeViewAddress_BeforeExpand;
            Cursor.Current = Cursors.Default;
        }

        void treeViewAddress_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            TreeNode parentNode = (TreeNode)e.Node;
            string Path = parentNode.Tag + "-";

            var groupedData = from device in addrList.dev.AsEnumerable()
                              where device.ro.Substring(0, Path.Length) == Path
                              group device by device.ro.Substring((parentNode.Level + 1) * 3, 2) into address
                              select new
                              {
                                  Key = address.Key,
                                  Count = address.Count()
                              };
            parentNode.Nodes.Clear();
            foreach (var address in groupedData)
            {
                TreeNode node = new TreeNode(address.Key);
                node.Tag = node.ToolTipText = Path + address.Key;
                parentNode.Nodes.Add(node);
                if (node.Level < 5)
                    node.Nodes.Add("");
            }
            Cursor.Current = Cursors.Default;
        }

        private void SetControls()
        {
            tyComboBox.Enabled                  =
            roTextBox.Enabled                   =
            aliasTextBox.Enabled                =
            ipTextBox.Enabled                   =
            subnetMaskTextBox.Enabled           =
            gatewayTextBox.Enabled              = 
            groupIpTextBox.Enabled              = 
            idTextBox.Enabled                   = 
            pwTextBox.Enabled                   =
            mcTextBox.Enabled                  =
                (m_Status != STATUS.READ_MODE);
            if (m_Status != STATUS.READ_MODE)
            {
                idTextBox.Enabled =
                pwTextBox.Enabled = (tyComboBox.Text == "IP CAM");
            }
            devDataTableDataGridView.Enabled    = (m_Status == STATUS.READ_MODE);
        }

        //private bool ExportXml(string xmlFilePath)
        //{
        //    bool result = false;
        //    XmlWriterSettings settings = new XmlWriterSettings();
        //    settings.Indent = true;
        //    using (XmlWriter writer = XmlWriter.Create(xmlFilePath, settings))
        //    {
        //        try
        //        {
        //            addrList.dev.WriteXml(writer);
        //            result = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "操作錯誤",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        finally
        //        {
        //            writer.Close();
        //        }
        //    }
        //    return result;
        //}

        /// <summary>
        /// 輸出 XML file
        /// </summary>
        /// <param name="xmlFilePath">要輸出的 XML file 路徑</param>
        /// <returns>true if success, else return false</returns>
        private bool ExportXml(string xmlFilePath)
        {
            bool result = false;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (MemoryStream stream = new MemoryStream())
            {
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    try
                    {
                        addrList.dev.WriteXml(writer);
                        // Reset stream to origin
                        stream.Seek(0, SeekOrigin.Begin);
                        // Load stream as XDocument
                        XDocument xdoc = XDocument.Load(stream);
                        // TODO 版本號應該要可以修改
                        xdoc.Element("AddrList").SetAttributeValue("ver", TbVersion.Text);
                        // Save to file as XML
                        xdoc.Save(xmlFilePath);
                        result = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        writer.Close();
                    }
                }
            }
            return result;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (bindingSource != null)
            {
                SaveFileDialog dlgFile = new SaveFileDialog();
                dlgFile.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                dlgFile.FileName = "addressbook.xml"; 
                if (dlgFile.ShowDialog() == DialogResult.OK)
                {
                    string xmlFilePath = dlgFile.FileName;
                    ExportXml(xmlFilePath);             
                }
            }
            SetButtons();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // TODO check if there are unsaved chage data

            OpenFileDialog dlgFile = new OpenFileDialog();
            dlgFile.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            dlgFile.FileName = "addressbook.xml"; 
            if (dlgFile.ShowDialog() == DialogResult.OK)
            {
                //读取版本信息
                XmlDocument xml = new XmlDocument();
                xml.Load(dlgFile.FileName);
                TbVersion.Text = xml.DocumentElement.GetAttribute("ver");


                addrList.Clear();
                try
                {
                    addrList.dev.ReadXml(dlgFile.FileName);
                    SetTreeView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            SetButtons();
        }

        public void Dump(DataSet dataSet)
        {
            Debug.WriteLine(">>=================================");
            foreach (DataTable dataTable in dataSet.Tables)
            {
                Debug.WriteLine("Table[{0}] Columes:{1} Rows:{2}",
                    dataTable.TableName, dataTable.Columns.Count, dataTable.Rows.Count);

                Debug.Write("> ");
                foreach (DataColumn dc in dataTable.Columns)
                {
                    Debug.Write(String.Format("Colume[{0}] ", dc.ColumnName));
                }
                Debug.WriteLine("");
                foreach (DataRow dr in dataTable.Rows)
                {
                    Debug.Write("> ");
                    for (int i = 0; i < dataTable.Columns.Count; ++i)
                    {
                        Debug.Write(String.Format("{0} ", dr.ItemArray[i]));
                    }
                    Debug.WriteLine("");
                }
            }
            Debug.WriteLine("<<=================================");
        }

        private void tyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControls();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = textBox.Text.Trim();
        }

        private void aliasTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = textBox.Text.TrimStart();
        }

        private void btnExportPkg_Click(object sender, EventArgs e)
        {
            if (bindingSource != null)
            {
                SaveFileDialog dlgFile = new SaveFileDialog();
                dlgFile.Filter = "PKG files (*.pkg)|*.pkg|All files (*.*)|*.*";
                dlgFile.FileName = "ADDRESS.PKG";
                if (dlgFile.ShowDialog() == DialogResult.OK)
                {  
                    string xmlFilePath = Program.GetAddressBookTempFolderPath() + @"\addressbook.xml";
                    if (ExportXml(xmlFilePath))
                    {
                        try
                        {
                            PkgTool.ToPkgFile(System.IO.Path.GetDirectoryName(xmlFilePath), dlgFile.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "操作錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            SetButtons();
        }
    }
}
