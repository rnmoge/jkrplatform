using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace JKR.Util
{
    public class XMLHelper
    {
        private XmlDocument m_xmlDoc;
        private string m_xmlName;

        public string XmlFullName
        {
            get
            {
                return this.m_xmlName;
            }
        }

        public string xmlPath
        {
            get
            {
                return this.GetFilePath();
            }
        }

        public string xmlName
        {
            get
            {
                return xmlName;
            }
        }

        private string GetFilePath()
        {
            int idx = this.m_xmlName.LastIndexOf(@"\");
            string FilePath = "";
            if (idx != -1)
            {
                FilePath = this.m_xmlName.Substring(0, idx) + @"\";
            }
            return FilePath;
        }

        public XMLHelper(string xmlName)
        {
            this.m_xmlName = xmlName;
        }

        public void Load()
        {
            if (this.m_xmlDoc == null)
            {
                try
                {
                    if (!File.Exists(this.m_xmlName))
                    {
                        this.Create(this.m_xmlName);
                    }
                    this.m_xmlDoc = new XmlDocument();
                    this.m_xmlDoc.Load(this.m_xmlName);
                }
                catch (Exception e)
                {
                    this.m_xmlDoc = null;
                }
            }
        }

        private XmlNode GetNode(XmlNodeList parentNode, string NodeName)
        {

            foreach (XmlNode Node in parentNode)
            {
                if (Node.Name.ToUpper() == NodeName.ToUpper())
                {
                    return Node;
                }
                else
                {
                    if (Node.HasChildNodes)
                    {
                        XmlNode findNode = GetNode(Node.ChildNodes, NodeName);
                        if (findNode != null)
                        {
                            return findNode;
                        }
                    }
                }
            }
            return null;
        }

        //读指定节点的值
        public string Read(string parentNodeName, string childNodeName)
        {
            if (m_xmlDoc == null)
            {
                this.Load();
            }

            XmlNode ParentNode = GetNode(m_xmlDoc.ChildNodes, parentNodeName);
            XmlNodeList nodeList;

            if (ParentNode != null)
            {
                nodeList = ParentNode.ChildNodes;

                foreach (XmlNode node in nodeList)
                {
                    if (node.Name.ToUpper().Equals(childNodeName.ToUpper()))
                    {
                        return node.InnerText;
                    }
                }
            }
            return null;
        }

        //修改指定节点的值,如节点不存在,则新建节点
        public void Write(string parentNodeName, string ChildNodeName, string NodeValue)
        {
            if (this.m_xmlDoc == null)
            {
                this.Load();
            }

            XmlNode root = this.m_xmlDoc.DocumentElement;
            XmlNode ParentNode = this.GetNode(this.m_xmlDoc.ChildNodes, parentNodeName);
            if (ParentNode == null)
            {
                XmlElement parentElem = this.m_xmlDoc.CreateElement(parentNodeName);
                XmlElement childElem = this.m_xmlDoc.CreateElement(ChildNodeName);
                childElem.InnerText = NodeValue;
                root.AppendChild(parentElem);
                parentElem.AppendChild(childElem);
                return;
            }

            bool bExist = false;
            XmlNodeList nodeList = ParentNode.ChildNodes;
            if (nodeList != null)
            {
                foreach (XmlNode node in nodeList)
                {
                    if (node.Name.ToUpper().Equals(ChildNodeName.ToUpper()))
                    {
                        node.InnerText = NodeValue;
                        bExist = true;
                    }
                }
            }

            if (bExist)
            {
                XmlElement childElem = m_xmlDoc.CreateElement(ChildNodeName);
                childElem.InnerText = NodeValue;
                ParentNode.AppendChild(childElem);
            }
        }

        //删除指定节点,如果未指定子节点,则将指定父节点下的所有子节点清空
        public void Delete(string parentNodeName, string ChildNodeName)
        {
            try
            {
                if (m_xmlDoc == null)
                {
                    this.Load();
                }

                XmlNode ParentNode = GetNode(m_xmlDoc.ChildNodes, parentNodeName);
                XmlNodeList nodeList = ParentNode.ChildNodes;

                if (ParentNode != null)
                {
                    if (ChildNodeName.Trim() == "")
                    {
                        ParentNode.RemoveAll();
                    }
                    else
                    {
                        foreach (XmlNode node in nodeList)
                        {
                            if (node.Name.ToUpper().Equals(ChildNodeName.ToUpper()))
                            {
                                ParentNode.RemoveChild(node);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            { }
        }

        public bool Save()
        {
            try
            {
                m_xmlDoc.Save(m_xmlName);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool Create(string FileName)
        {
            try
            {
                string FilePath = this.GetFilePath();
                if ((FilePath != "") && !Directory.Exists(FilePath))
                {
                    Directory.CreateDirectory(FilePath);
                }
                StreamWriter sw = File.CreateText(FileName);
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                sw.WriteLine("<Root>");
                sw.WriteLine("</Root>");
                sw.Flush();
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
               return false;
            }

        }



    }
}
