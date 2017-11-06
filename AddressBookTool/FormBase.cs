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
    public partial class FormBase : Form
    {
        public bool AllowClose = false;
        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowClose)
                e.Cancel = true;
        }
    }
}
