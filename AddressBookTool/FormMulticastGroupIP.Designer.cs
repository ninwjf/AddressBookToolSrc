namespace AddressBookTool
{
    partial class FormMulticastGroupIP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label ipLabel;
            this.multicastGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.ipTextBox = new IPAddressControlLib.IPAddressControl();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addrList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multicastGroupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "multicastGroup";
            this.bindingSource.Position = -1;
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Location = new System.Drawing.Point(13, 45);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new System.Drawing.Size(18, 12);
            ipLabel.TabIndex = 2;
            ipLabel.Text = "IP:";
            // 
            // multicastGroupDataGridView
            // 
            this.multicastGroupDataGridView.AllowUserToAddRows = false;
            this.multicastGroupDataGridView.AllowUserToDeleteRows = false;
            this.multicastGroupDataGridView.AllowUserToResizeColumns = false;
            this.multicastGroupDataGridView.AllowUserToResizeRows = false;
            this.multicastGroupDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multicastGroupDataGridView.AutoGenerateColumns = false;
            this.multicastGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.multicastGroupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.multicastGroupDataGridView.DataSource = this.bindingSource;
            this.multicastGroupDataGridView.Location = new System.Drawing.Point(12, 70);
            this.multicastGroupDataGridView.Name = "multicastGroupDataGridView";
            this.multicastGroupDataGridView.ReadOnly = true;
            this.multicastGroupDataGridView.RowTemplate.Height = 24;
            this.multicastGroupDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.multicastGroupDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.multicastGroupDataGridView.Size = new System.Drawing.Size(370, 480);
            this.multicastGroupDataGridView.TabIndex = 1;
            // 
            // ipTextBox
            // 
            this.ipTextBox.AllowInternalTab = false;
            this.ipTextBox.AutoHeight = true;
            this.ipTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "ip", true));
            this.ipTextBox.Location = new System.Drawing.Point(37, 42);
            this.ipTextBox.MinimumSize = new System.Drawing.Size(84, 22);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.ReadOnly = false;
            this.ipTextBox.Size = new System.Drawing.Size(121, 22);
            this.ipTextBox.TabIndex = 3;
            this.ipTextBox.Text = "...";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ip";
            this.dataGridViewTextBoxColumn1.HeaderText = "IP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FormMulticastGroupIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 562);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(ipLabel);
            this.Controls.Add(this.multicastGroupDataGridView);
            this.Name = "FormMulticastGroupIP";
            this.Text = "Multicast Group IP";
            this.Controls.SetChildIndex(this.multicastGroupDataGridView, 0);
            this.Controls.SetChildIndex(ipLabel, 0);
            this.Controls.SetChildIndex(this.ipTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.addrList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multicastGroupDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView multicastGroupDataGridView;
        private IPAddressControlLib.IPAddressControl ipTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}