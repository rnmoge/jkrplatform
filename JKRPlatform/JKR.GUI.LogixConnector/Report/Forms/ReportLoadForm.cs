using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JKR.GUI.LogixConnector.Report.Forms
{
    public partial class ReportLoadForm : Form
    {
        private static ReportLoadForm m_instance;
        private static bool m_isComplete;
        private static bool m_isLoad;
        private static bool m_isStop;

        public ReportLoadForm()
        {
            InitializeComponent();
        }

        public static ReportLoadForm GetInstance()
        {
            if (m_instance == null)
            {
                m_instance = new ReportLoadForm();
            }
            return m_instance;
        }

        public void LoadReport()
        {
            if (!m_isLoad)
            {
                //this.bgwLoadReport.RunWorkerAsync();
                m_isLoad = true;
                m_isComplete = false;
            }
        }

 


 

    }
}
