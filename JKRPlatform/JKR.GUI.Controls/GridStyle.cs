using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using JKR.GUI.LogixConnector;
using System.IO;
using System.Xml;
using JKR.Util;
using System.Collections;

namespace JKR.GUI.Controls
{
    public class GridStyle
    {
        private RadGridView grd;
        private RadTreeView lst;
        private string m_xmlName;

        public GridStyle(object aGrd)
        {
            this.grd = null;
            this.lst = null;
            if (aGrd != null)
            {
                if (aGrd is RadGridView)
                {
                    this.grd = (RadGridView)aGrd;
                }
                if (aGrd is RadTreeView)
                {
                    this.lst = (RadTreeView)aGrd;
                }
            }

            this.m_xmlName = UIProxy.GetCurrentUserFolder() + @"\GridStyle.xml";
            if (File.Exists(this.m_xmlName))
            {
                try
                {
                    new XmlDocument().Load(this.m_xmlName);
                }
                catch (Exception exx)
                { }
            }
        }

        public object xGrid
        {
            set
            {
                if (value is RadGridView)
                {
                    this.grd = (RadGridView)value;
                }
                if (value is RadTreeView)
                {
                    this.lst = (RadTreeView)value;
                }
            }
        }

        //读取网格风格
        public void Load()
        {
            try
            {
                if (this.grd != null)
                {
                    this.LoadGrd();
                }
                if (this.lst != null)
                {
                    this.LoadList();
                }
            }
            catch (Exception ex)
            {          
                try
                {
                    if (File.Exists(this.m_xmlName))
                    {
                    }
                }
                catch (Exception exx)
                { }

            }
        }

        private void LoadGrd()
        {
            XMLHelper GridStyle = new XMLHelper(this.m_xmlName);

            try
            {
                if (!(this.grd.ViewDefinition is ColumnGroupsViewDefinition))
                {
                    foreach (GridViewColumn col in grd.Columns)
                    {
                        string colVisibleIndex = GridStyle.Read(grd.FindForm().Name + "_" + grd.Name, col.Name + "VisibleIndex");
                        if (string.IsNullOrEmpty(colVisibleIndex))
                        {
                            col.IsVisible= false;
                            col.HeaderText = colVisibleIndex;
                        }
                        else
                        {
                            col.HeaderText = "-1";
                        }

                        //设置列宽
                        string colWidth = GridStyle.Read(grd.FindForm().Name + "_" + grd.Name, col.Name + "Width");
                        try
                        {
                            if (string.IsNullOrEmpty(colWidth))
                            {
                                col.Width = Convert.ToInt32(colWidth);
                            }
                        }
                        catch (Exception ex)
                        { }
                      
                    }

                    //对列进行排序
                    SortedList colList = new SortedList();
                    foreach(GridViewColumn col in grd.Columns)
                    {
                        string gcolTag = col.HeaderText.ToString();
                        if (!gcolTag.Equals("-1"))
                        {
                            colList.Add(gcolTag, col);
                        }
                    }

                    //循环赋值
                    foreach (object objCol in colList.Keys)
                    {
                        GridViewColumn colCurr =(GridViewColumn)colList[objCol];
                        colCurr.HeaderText=colCurr.HeaderText.ToString();
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void LoadList()
        {
            XMLHelper GridStyle = new XMLHelper(this.m_xmlName);

            try
            {
                foreach(RadTreeNode col in lst.Nodes)
                {
                    string colVisibleIndex = GridStyle.Read(lst.FindForm().Name + "_" + lst.Name, col.Name + "VisibleIndex");
                    if (string.IsNullOrEmpty(colVisibleIndex))
                    {
                        col.Visible = false;
                        col.Tag = colVisibleIndex;
                    }
                    else
                    {
                        col.Tag = "-1";
                    }

                    //设置列宽
                    string colWidth = GridStyle.Read(lst.FindForm().Name + "_" + lst.Name, col.Name + "Width");
                    try
                    {
                        if (!string.IsNullOrEmpty(colWidth))
                        {
                            col.ItemHeight = Convert.ToInt32(colWidth);
                        }
                    }
                    catch (Exception ex) { }
                }

                SortedList colList2 = new SortedList();
                foreach (RadTreeNode col in lst.Nodes)
                {
                    string lcolTag = col.Tag.ToString();
                    if (!lcolTag.Equals("-1"))
                    {
                        colList2.Add(lcolTag, col);
                    }
                }

                //循环赋值
                foreach (object objCol in colList2.Keys)
                {
                    RadTreeNode colCurr=(RadTreeNode)colList2[objCol];
                    colCurr.Tag = colCurr.Tag.ToString();

                }
            }
            catch (Exception ex)
            { }

        }

        //保存网格风格
        public void save()
        {
            try
            {
                if (grd != null)
                {
                    SaveGrid();
                }
                if (this.lst != null)
                {
                    this.SaveList();
                }

            }
            catch (Exception ex)
            {
                File.Delete(m_xmlName);
            }
        }

        private void SaveGrid()
        {
            try
            {
                XMLHelper GridStyle = new XMLHelper(m_xmlName);

                GridStyle.Delete(grd.FindForm().Name + "_" + grd.Name, "");
                ArrayList iList = new ArrayList();
                bool iSaveFlag = true;

                foreach (GridViewColumn col in grd.Columns)
                {
                    foreach (int iIndex in iList)
                    {
                        if (iIndex == col.Index && iIndex > 0)
                        {
                            iSaveFlag = false;
                        }
                    }
                    if (iSaveFlag == true)
                    {
                        iList.Add(col.Index);
                        GridStyle.Write(grd.FindForm().Name + "_" + grd.Name, col.Name + "VisibleIndex", Convert.ToString(col.Index));
                        GridStyle.Write(grd.FindForm().Name + "_" + grd.Name, col.Name + "Width",Convert.ToString(col.Width));
                    }
                }
                if (iSaveFlag == true)
                {
                    GridStyle.Save();
                }
              
            }
            catch (Exception ex) { }
        }

        private void SaveList()
        {
            XMLHelper GridStyle = new XMLHelper(m_xmlName);

            GridStyle.Delete(lst.FindForm().Name + "_" + lst.Name,"");
            ArrayList iList = new ArrayList();
            bool iSaveFlag = true;

            foreach (RadTreeNode col in lst.Nodes)
            {
                foreach (int iIndex in iList)
                {
                    if (iIndex == col.Index && iIndex > 0)
                    {
                        iSaveFlag = false;
                        return;
                    }
                }

                iList.Add(col.Index);
                GridStyle.Write(lst.FindForm().Name + "_" + lst.Name, col.Name + "VisibleIndex",Convert.ToString(col.Index));
                GridStyle.Write(lst.FindForm().Name + "_" + lst.Name, col.Name + "Width", Convert.ToString(col.ItemHeight));

            }
            if (iSaveFlag == true)
            {
                 GridStyle.Save();
            }
        }

    }
}
