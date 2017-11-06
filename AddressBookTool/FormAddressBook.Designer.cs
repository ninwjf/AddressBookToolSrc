using System.Collections.Generic;
namespace AddressBookTool
{
    partial class FormAddressBook
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tyLabel;
            System.Windows.Forms.Label roLabel;
            System.Windows.Forms.Label aliasLabel;
            System.Windows.Forms.Label ipLabel;
            System.Windows.Forms.Label smLabel;
            System.Windows.Forms.Label gwLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label pwLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddressBook));
            this.mcLabel = new System.Windows.Forms.Label();
            this.treeViewAddress = new System.Windows.Forms.TreeView();
            this.addrList = new AddressBookTool.AddrList();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.lblCount = new System.Windows.Forms.ToolStripLabel();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.txtboxPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveChange = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnExportPkg = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TbVersion = new System.Windows.Forms.ToolStripTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tyComboBox = new System.Windows.Forms.ComboBox();
            this.deviceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.devDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.tyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipTextBox = new IPAddressControlLib.IPAddressControl();
            this.subnetMaskTextBox = new IPAddressControlLib.IPAddressControl();
            this.gatewayTextBox = new IPAddressControlLib.IPAddressControl();
            this.mcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.roTextBox = new System.Windows.Forms.MaskedTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupIpTextBox = new System.Windows.Forms.TextBox();
            tyLabel = new System.Windows.Forms.Label();
            roLabel = new System.Windows.Forms.Label();
            aliasLabel = new System.Windows.Forms.Label();
            ipLabel = new System.Windows.Forms.Label();
            smLabel = new System.Windows.Forms.Label();
            gwLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            pwLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addrList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDataTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tyLabel
            // 
            tyLabel.AutoSize = true;
            tyLabel.Location = new System.Drawing.Point(225, 51);
            tyLabel.Name = "tyLabel";
            tyLabel.Size = new System.Drawing.Size(65, 12);
            tyLabel.TabIndex = 21;
            tyLabel.Text = "设备类型：";
            // 
            // roLabel
            // 
            roLabel.AutoSize = true;
            roLabel.Location = new System.Drawing.Point(225, 78);
            roLabel.Name = "roLabel";
            roLabel.Size = new System.Drawing.Size(65, 12);
            roLabel.TabIndex = 23;
            roLabel.Text = "设备地址：";
            // 
            // aliasLabel
            // 
            aliasLabel.AutoSize = true;
            aliasLabel.Location = new System.Drawing.Point(503, 77);
            aliasLabel.Name = "aliasLabel";
            aliasLabel.Size = new System.Drawing.Size(65, 12);
            aliasLabel.TabIndex = 25;
            aliasLabel.Text = "设备别名：";
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Location = new System.Drawing.Point(237, 105);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new System.Drawing.Size(53, 12);
            ipLabel.TabIndex = 27;
            ipLabel.Text = "设备IP：";
            // 
            // smLabel
            // 
            smLabel.AutoSize = true;
            smLabel.Location = new System.Drawing.Point(503, 106);
            smLabel.Name = "smLabel";
            smLabel.Size = new System.Drawing.Size(65, 12);
            smLabel.TabIndex = 29;
            smLabel.Text = "子网掩码：";
            // 
            // gwLabel
            // 
            gwLabel.AutoSize = true;
            gwLabel.Location = new System.Drawing.Point(249, 132);
            gwLabel.Name = "gwLabel";
            gwLabel.Size = new System.Drawing.Size(41, 12);
            gwLabel.TabIndex = 31;
            gwLabel.Text = "网关：";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(515, 133);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(53, 12);
            groupLabel.TabIndex = 33;
            groupLabel.Text = "组播IP：";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(219, 159);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(71, 12);
            idLabel.TabIndex = 35;
            idLabel.Text = "IP Cam ID：";
            // 
            // pwLabel
            // 
            pwLabel.AutoSize = true;
            pwLabel.Location = new System.Drawing.Point(491, 161);
            pwLabel.Name = "pwLabel";
            pwLabel.Size = new System.Drawing.Size(77, 12);
            pwLabel.TabIndex = 37;
            pwLabel.Text = "IP Cam密码：";
            // 
            // mcLabel
            // 
            this.mcLabel.AutoSize = true;
            this.mcLabel.Location = new System.Drawing.Point(485, 51);
            this.mcLabel.Name = "mcLabel";
            this.mcLabel.Size = new System.Drawing.Size(83, 12);
            this.mcLabel.TabIndex = 38;
            this.mcLabel.Text = "设备MAC地址：";
            // 
            // treeViewAddress
            // 
            this.treeViewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewAddress.Location = new System.Drawing.Point(1, 1);
            this.treeViewAddress.Name = "treeViewAddress";
            this.treeViewAddress.PathSeparator = ".";
            this.treeViewAddress.ShowNodeToolTips = true;
            this.treeViewAddress.Size = new System.Drawing.Size(175, 569);
            this.treeViewAddress.TabIndex = 0;
            // 
            // addrList
            // 
            this.addrList.DataSetName = "AddrList";
            this.addrList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "dev";
            this.bindingSource.DataSource = this.addrList;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.bindingSource;
            this.bindingNavigator.CountItem = this.lblCount;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirst,
            this.btnPrev,
            this.bindingNavigatorSeparator,
            this.txtboxPosition,
            this.lblCount,
            this.bindingNavigatorSeparator1,
            this.btnNext,
            this.btnLast,
            this.bindingNavigatorSeparator2,
            this.btnAddNew,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnSaveChange,
            this.btnCancel,
            this.toolStripSeparator2,
            this.btnImport,
            this.btnExport,
            this.btnExportPkg,
            this.toolStripLabel1,
            this.TbVersion});
            this.bindingNavigator.Location = new System.Drawing.Point(179, 1);
            this.bindingNavigator.MoveFirstItem = this.btnFirst;
            this.bindingNavigator.MoveLastItem = this.btnLast;
            this.bindingNavigator.MoveNextItem = this.btnNext;
            this.bindingNavigator.MovePreviousItem = this.btnPrev;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.txtboxPosition;
            this.bindingNavigator.Size = new System.Drawing.Size(679, 40);
            this.bindingNavigator.TabIndex = 1;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(32, 37);
            this.lblCount.Text = "/ {0}";
            this.lblCount.ToolTipText = "項目總數";
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.RightToLeftAutoMirrorImage = true;
            this.btnFirst.Size = new System.Drawing.Size(23, 37);
            this.btnFirst.Text = "移到最前面";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.RightToLeftAutoMirrorImage = true;
            this.btnPrev.Size = new System.Drawing.Size(23, 37);
            this.btnPrev.Text = "移到上一個";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 40);
            // 
            // txtboxPosition
            // 
            this.txtboxPosition.AccessibleName = "位置";
            this.txtboxPosition.AutoSize = false;
            this.txtboxPosition.Name = "txtboxPosition";
            this.txtboxPosition.Size = new System.Drawing.Size(50, 23);
            this.txtboxPosition.Text = "0";
            this.txtboxPosition.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeftAutoMirrorImage = true;
            this.btnNext.Size = new System.Drawing.Size(23, 37);
            this.btnNext.Text = "移到下一個";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Name = "btnLast";
            this.btnLast.RightToLeftAutoMirrorImage = true;
            this.btnLast.Size = new System.Drawing.Size(23, 37);
            this.btnLast.Text = "移到最後面";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.RightToLeftAutoMirrorImage = true;
            this.btnAddNew.Size = new System.Drawing.Size(36, 37);
            this.btnAddNew.Text = "新增";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 37);
            this.btnEdit.Text = "修改";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 37);
            this.btnDelete.Text = "刪除";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChange.Image")));
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(36, 37);
            this.btnSaveChange.Text = "儲存";
            this.btnSaveChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeftAutoMirrorImage = true;
            this.btnCancel.Size = new System.Drawing.Size(36, 37);
            this.btnCancel.Text = "取消";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnImport
            // 
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageTransparentColor = System.Drawing.Color.White;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(62, 37);
            this.btnImport.Text = "輸入XML";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.White;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(62, 37);
            this.btnExport.Text = "輸出XML";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.ToolTipText = "輸出XML";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportPkg
            // 
            this.btnExportPkg.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPkg.Image")));
            this.btnExportPkg.ImageTransparentColor = System.Drawing.Color.White;
            this.btnExportPkg.Name = "btnExportPkg";
            this.btnExportPkg.Size = new System.Drawing.Size(60, 37);
            this.btnExportPkg.Text = "輸出PKG";
            this.btnExportPkg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportPkg.Click += new System.EventHandler(this.btnExportPkg_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 37);
            this.toolStripLabel1.Text = "版本:";
            // 
            // TbVersion
            // 
            this.TbVersion.Name = "TbVersion";
            this.TbVersion.Size = new System.Drawing.Size(60, 40);
            this.TbVersion.Text = "1.0";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataSource = this.bindingSource;
            // 
            // tyComboBox
            // 
            this.tyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "ty", true));
            this.tyComboBox.DataSource = this.deviceTypesBindingSource;
            this.tyComboBox.DisplayMember = "DisplayText";
            this.tyComboBox.Enabled = false;
            this.tyComboBox.FormattingEnabled = true;
            this.tyComboBox.Location = new System.Drawing.Point(294, 48);
            this.tyComboBox.Name = "tyComboBox";
            this.tyComboBox.Size = new System.Drawing.Size(121, 20);
            this.tyComboBox.TabIndex = 0;
            this.tyComboBox.ValueMember = "Value";
            this.tyComboBox.SelectedIndexChanged += new System.EventHandler(this.tyComboBox_SelectedIndexChanged);
            // 
            // deviceTypesBindingSource
            // 
            this.deviceTypesBindingSource.DataSource = typeof(AddressBookTool.DeviceType);
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "alias", true));
            this.aliasTextBox.Enabled = false;
            this.aliasTextBox.Location = new System.Drawing.Point(574, 74);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(121, 21);
            this.aliasTextBox.TabIndex = 3;
            this.aliasTextBox.TextChanged += new System.EventHandler(this.aliasTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(294, 158);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 21);
            this.idTextBox.TabIndex = 8;
            this.idTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // pwTextBox
            // 
            this.pwTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "pw", true));
            this.pwTextBox.Enabled = false;
            this.pwTextBox.Location = new System.Drawing.Point(574, 158);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(121, 21);
            this.pwTextBox.TabIndex = 9;
            this.pwTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // devDataTableDataGridView
            // 
            this.devDataTableDataGridView.AllowUserToAddRows = false;
            this.devDataTableDataGridView.AllowUserToDeleteRows = false;
            this.devDataTableDataGridView.AllowUserToResizeRows = false;
            this.devDataTableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devDataTableDataGridView.AutoGenerateColumns = false;
            this.devDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tyDataGridViewTextBoxColumn,
            this.roDataGridViewTextBoxColumn,
            this.aliasDataGridViewTextBoxColumn,
            this.ipDataGridViewTextBoxColumn,
            this.smDataGridViewTextBoxColumn,
            this.gwDataGridViewTextBoxColumn,
            this.mcDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.pwDataGridViewTextBoxColumn});
            this.devDataTableDataGridView.DataSource = this.bindingSource;
            this.devDataTableDataGridView.Location = new System.Drawing.Point(182, 186);
            this.devDataTableDataGridView.Name = "devDataTableDataGridView";
            this.devDataTableDataGridView.ReadOnly = true;
            this.devDataTableDataGridView.RowTemplate.Height = 24;
            this.devDataTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devDataTableDataGridView.Size = new System.Drawing.Size(673, 374);
            this.devDataTableDataGridView.TabIndex = 38;
            // 
            // tyDataGridViewTextBoxColumn
            // 
            this.tyDataGridViewTextBoxColumn.DataPropertyName = "ty";
            this.tyDataGridViewTextBoxColumn.HeaderText = "ty";
            this.tyDataGridViewTextBoxColumn.Name = "tyDataGridViewTextBoxColumn";
            this.tyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roDataGridViewTextBoxColumn
            // 
            this.roDataGridViewTextBoxColumn.DataPropertyName = "ro";
            this.roDataGridViewTextBoxColumn.HeaderText = "ro";
            this.roDataGridViewTextBoxColumn.Name = "roDataGridViewTextBoxColumn";
            this.roDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            this.aliasDataGridViewTextBoxColumn.DataPropertyName = "alias";
            this.aliasDataGridViewTextBoxColumn.HeaderText = "alias";
            this.aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            this.aliasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "ip";
            this.ipDataGridViewTextBoxColumn.HeaderText = "ip";
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            this.ipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smDataGridViewTextBoxColumn
            // 
            this.smDataGridViewTextBoxColumn.DataPropertyName = "sm";
            this.smDataGridViewTextBoxColumn.HeaderText = "sm";
            this.smDataGridViewTextBoxColumn.Name = "smDataGridViewTextBoxColumn";
            this.smDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gwDataGridViewTextBoxColumn
            // 
            this.gwDataGridViewTextBoxColumn.DataPropertyName = "gw";
            this.gwDataGridViewTextBoxColumn.HeaderText = "gw";
            this.gwDataGridViewTextBoxColumn.Name = "gwDataGridViewTextBoxColumn";
            this.gwDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mcDataGridViewTextBoxColumn
            // 
            this.mcDataGridViewTextBoxColumn.DataPropertyName = "mc";
            this.mcDataGridViewTextBoxColumn.HeaderText = "mc";
            this.mcDataGridViewTextBoxColumn.Name = "mcDataGridViewTextBoxColumn";
            this.mcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pwDataGridViewTextBoxColumn
            // 
            this.pwDataGridViewTextBoxColumn.DataPropertyName = "pw";
            this.pwDataGridViewTextBoxColumn.HeaderText = "pw";
            this.pwDataGridViewTextBoxColumn.Name = "pwDataGridViewTextBoxColumn";
            this.pwDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ipTextBox
            // 
            this.ipTextBox.AllowInternalTab = false;
            this.ipTextBox.AutoHeight = true;
            this.ipTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "ip", true));
            this.ipTextBox.Location = new System.Drawing.Point(294, 103);
            this.ipTextBox.MinimumSize = new System.Drawing.Size(93, 21);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.ReadOnly = false;
            this.ipTextBox.Size = new System.Drawing.Size(121, 21);
            this.ipTextBox.TabIndex = 4;
            this.ipTextBox.Text = "...";
            // 
            // subnetMaskTextBox
            // 
            this.subnetMaskTextBox.AllowInternalTab = false;
            this.subnetMaskTextBox.AutoHeight = true;
            this.subnetMaskTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.subnetMaskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subnetMaskTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subnetMaskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "sm", true));
            this.subnetMaskTextBox.Location = new System.Drawing.Point(574, 102);
            this.subnetMaskTextBox.MinimumSize = new System.Drawing.Size(93, 21);
            this.subnetMaskTextBox.Name = "subnetMaskTextBox";
            this.subnetMaskTextBox.ReadOnly = false;
            this.subnetMaskTextBox.Size = new System.Drawing.Size(121, 21);
            this.subnetMaskTextBox.TabIndex = 5;
            this.subnetMaskTextBox.Text = "...";
            // 
            // gatewayTextBox
            // 
            this.gatewayTextBox.AllowInternalTab = false;
            this.gatewayTextBox.AutoHeight = true;
            this.gatewayTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.gatewayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gatewayTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gatewayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "gw", true));
            this.gatewayTextBox.Location = new System.Drawing.Point(294, 130);
            this.gatewayTextBox.MinimumSize = new System.Drawing.Size(93, 21);
            this.gatewayTextBox.Name = "gatewayTextBox";
            this.gatewayTextBox.ReadOnly = false;
            this.gatewayTextBox.Size = new System.Drawing.Size(121, 21);
            this.gatewayTextBox.TabIndex = 6;
            this.gatewayTextBox.Text = "...";
            // 
            // mcTextBox
            // 
            this.mcTextBox.AsciiOnly = true;
            this.mcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "mc", true));
            this.mcTextBox.Location = new System.Drawing.Point(574, 46);
            this.mcTextBox.Mask = "CC:CC:CC:CC:CC:CC";
            this.mcTextBox.Name = "mcTextBox";
            this.mcTextBox.Size = new System.Drawing.Size(121, 21);
            this.mcTextBox.TabIndex = 1;
            this.mcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roTextBox
            // 
            this.roTextBox.AsciiOnly = true;
            this.roTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "ro", true));
            this.roTextBox.Location = new System.Drawing.Point(294, 74);
            this.roTextBox.Mask = "AA-AA-AA-AA-AA-AA";
            this.roTextBox.Name = "roTextBox";
            this.roTextBox.Size = new System.Drawing.Size(121, 21);
            this.roTextBox.TabIndex = 2;
            this.roTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupIpTextBox
            // 
            this.groupIpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "group", true));
            this.groupIpTextBox.Location = new System.Drawing.Point(574, 130);
            this.groupIpTextBox.Name = "groupIpTextBox";
            this.groupIpTextBox.ReadOnly = true;
            this.groupIpTextBox.Size = new System.Drawing.Size(121, 21);
            this.groupIpTextBox.TabIndex = 39;
            // 
            // FormAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 572);
            this.Controls.Add(tyLabel);
            this.Controls.Add(roLabel);
            this.Controls.Add(ipLabel);
            this.Controls.Add(gwLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.groupIpTextBox);
            this.Controls.Add(this.roTextBox);
            this.Controls.Add(this.mcTextBox);
            this.Controls.Add(this.gatewayTextBox);
            this.Controls.Add(this.subnetMaskTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.mcLabel);
            this.Controls.Add(this.devDataTableDataGridView);
            this.Controls.Add(this.tyComboBox);
            this.Controls.Add(aliasLabel);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(smLabel);
            this.Controls.Add(groupLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(pwLabel);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.treeViewAddress);
            this.Name = "FormAddressBook";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.FormAddressBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addrList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDataTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewAddress;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAddNew;
        private System.Windows.Forms.ToolStripLabel lblCount;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox txtboxPosition;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnSaveChange;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private AddrList addrList;
        private System.Windows.Forms.ComboBox tyComboBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.DataGridView devDataTableDataGridView;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripButton btnExport;
        private IPAddressControlLib.IPAddressControl ipTextBox;
        private IPAddressControlLib.IPAddressControl subnetMaskTextBox;
        private IPAddressControlLib.IPAddressControl gatewayTextBox;
        private System.Windows.Forms.MaskedTextBox mcTextBox;
        private System.Windows.Forms.BindingSource deviceTypesBindingSource;
        private System.Windows.Forms.MaskedTextBox roTextBox;
        private System.Windows.Forms.ToolStripButton btnExportPkg;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox groupIpTextBox;
        private System.Windows.Forms.Label mcLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TbVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwDataGridViewTextBoxColumn;
    }
}
