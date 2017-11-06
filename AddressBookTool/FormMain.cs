using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookTool
{
    public partial class FormMain : Form
    {
        List<FormBase> m_Forms = new List<FormBase>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            m_Forms.Add(new FormScreenSaver());
            m_Forms.Add(new FormCardList());
            m_Forms.Add(new FormMulticastGroupIP());
            m_Forms.Add(new FormAddressBook());

            foreach (FormBase form in m_Forms)
            {
                // Set the Parent Form of the Child window.
                form.MdiParent = this;
                // Display the new form.
                form.Show();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (FormBase form in m_Forms)
            {
                form.AllowClose = true;
                form.Close();
            }

            Application.Exit();
        }
    }
}
