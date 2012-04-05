using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JKR.GUI.LogixConnector.CommonForm
{
    public partial class MultiNumberForm : Form
    {
        private string m_MultiNumberString;

        public string MultiNumberString
        {
            get { return m_MultiNumberString; }
        }

        public MultiNumberForm()
        {
            InitializeComponent();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.CheckFileExists = true;
            myOpenFileDialog.DefaultExt = "txt";
            myOpenFileDialog.Filter = "Text File|*.txt";
            myOpenFileDialog.Multiselect = false;
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader myStreamReader=null;
                try
                {
                    myStreamReader = File.OpenText(myOpenFileDialog.FileName);
                    this.edtMultiNumber.Text = myStreamReader.ReadToEnd();
                }
                catch (Exception exc)
                {
                
                   MessageBox.Show("File could not be opened or read.\r\nPlease verify that the filename is correct, and that you have read permissions for the desired directory.\r\n\r\nException: " + exc.Message);
               
                }
                finally
                {
                    if (myStreamReader != null)
                    {
                        myStreamReader.Close();
                    }
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string s = "";
            string sTemp = "";
            this.m_MultiNumberString = "";
            s = this.edtMultiNumber.Text.Trim();
            if (s != "")
            {
                s = s + "\r\n";
                try
                {
                    while (s.ToUpper().Length > 0)
                    {
                        sTemp = s.Substring(0, s.IndexOf("\r\n"));
                        if (this.m_MultiNumberString == "")
                        {
                            this.m_MultiNumberString = "'" + sTemp + "'";
                        }
                        else
                        {
                            this.m_MultiNumberString = this.m_MultiNumberString + ",'" + sTemp + "'";
                        }
                        s = s.Substring(s.IndexOf("\r\n") + 2, (s.Length - s.IndexOf("\r\n")) - 2);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {                
                  this.m_MultiNumberString = "";
                }
            }

        }

    }
}
