using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AddressBookTool
{
    public partial class FormCardList : AddressBookTool.FormBase
    {
        XmlNodeList m_Cards;
        string m_InputXmlFilePath;
        public FormCardList()
        {
            InitializeComponent();
            SetButtons();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgFile = new OpenFileDialog();
            dlgFile.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            dlgFile.FileName = "cardlist.xml";
            if (dlgFile.ShowDialog() == DialogResult.OK)
            {
                listViewCardList.Items.Clear();
                try
                {
                    m_InputXmlFilePath = dlgFile.FileName;
                    XmlDocument doc = new XmlDocument();
                    doc.Load(m_InputXmlFilePath);
                    m_Cards = doc.GetElementsByTagName("card");
                    foreach (XmlNode card in m_Cards)
                    {
                        listViewCardList.Items.Add(new ListViewItem(card.InnerText));
                    }
                }
                catch (Exception ex)
                {
                    m_Cards = null;
                    MessageBox.Show(ex.Message, "操作錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            SetButtons();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (m_InputXmlFilePath != null)
            {
                SaveFileDialog dlgFile = new SaveFileDialog();
                dlgFile.Filter = "PKG files (*.pkg)|*.pkg|All files (*.*)|*.*";
                dlgFile.FileName = "CARD.PKG";
                if (dlgFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(m_InputXmlFilePath, Program.GetCardListTempFolderPath() + @"\cardlist.xml", true);
                        PkgTool.ToPkgFile(Program.GetCardListTempFolderPath(), dlgFile.FileName);
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
            btnExport.Enabled = (m_Cards != null && m_Cards.Count > 0);
        }
    }
}
