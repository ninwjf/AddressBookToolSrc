using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AddressBookTool
{
    public partial class FormScreenSaver : AddressBookTool.FormBase
    {
        string m_InputJPGFilePath;
        public FormScreenSaver()
        {
            InitializeComponent();
            SetButtons();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgFile = new OpenFileDialog();
            dlgFile.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (dlgFile.ShowDialog() == DialogResult.OK)
            {
                m_InputJPGFilePath = dlgFile.FileName;
                pictureBox.ImageLocation = m_InputJPGFilePath;
            }

            SetButtons();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (m_InputJPGFilePath != null)
            {
                SaveFileDialog dlgFile = new SaveFileDialog();
                dlgFile.Filter = "PKG files (*.pkg)|*.pkg|All files (*.*)|*.*";
                dlgFile.FileName = "SCREENSAVER.PKG";
                if (dlgFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(m_InputJPGFilePath, Program.GetScreenSaverTempFolderPath() + @"\screensaver.jpg", true);
                        PkgTool.ToPkgFile(Program.GetScreenSaverTempFolderPath(), dlgFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            SetButtons();
        }

        private void SetButtons()
        {
            btnExport.Enabled = (m_InputJPGFilePath != null);
        }
    }
}
