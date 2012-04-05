using System;
using System.Collections.Generic;
using System.Text;

namespace JKR.Util
{
    public class EnvironmentSetting
    {
        private string m_xmlFileName;
        private XMLHelper m_XML;

        public EnvironmentSetting()
        {
            this.Load();
        }

        public EnvironmentSetting(string Filename)
        {
            this.m_xmlFileName = Filename;
            this.m_XML = new XMLHelper(this.m_xmlFileName);
        }

        public void Load()
        {
            this.m_XML.Load();
        }

        public string Read(string Node, string SubNode, string DefaultValue)
        {
            string s = "";
            s = this.m_XML.Read(Node, SubNode);
            if (s != "")
            {
                return s;
            }
            return DefaultValue;
        }

        public void Save()
        {
            this.m_XML.Save();
        }

        public string Write(string Node, string SubNode, string Value)
        {
            string Write=string.Empty;
            this.m_XML.Write(Node, SubNode, Value);
            return Write;
        }

    }
}
