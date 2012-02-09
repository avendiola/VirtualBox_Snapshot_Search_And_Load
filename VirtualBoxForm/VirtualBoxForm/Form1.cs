using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.DirectoryServices;
using System.Data;
using System.Reflection;
using System.Drawing;

namespace VirtualBoxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //SECTION 1. Create a DOM Document and load the XML data into it.
                XmlDocument dom = new XmlDocument();
                dom.Load("Virtual Machine.xml");

                //SECTION 2. Initialize the TreeView control.
                treeXML.Nodes.Clear();
                treeXML.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = treeXML.Nodes[0];

                //SECTION 3. Populate the TreeView with the DOM nodes.
                AddNode(dom.DocumentElement, tNode);
                treeXML.ExpandAll();

            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            ClearBackColor();
        }

        private void ClearBackColor()
        {
            TreeNodeCollection nodes = treeXML.Nodes;
            foreach (TreeNode n in nodes)
            {
                ClearRecursive(n);
            }
        }

        private void ClearRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.BackColor = Color.White;
                ClearRecursive(tn);
            }
        }

        private void cmdNodeSearch_Click(object sender, EventArgs e)
        {
            ClearBackColor();
            FindByText();
        }

        private void FindByText()
        {
            TreeNodeCollection nodes = treeXML.Nodes;
            foreach (TreeNode n in nodes)
            {
                FindRecursive(n);
            }
        }

        private void FindRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                //if the text properties match, color the item
                if (tn.Text == this.txtNodeSearch.Text)
                    tn.BackColor = Color.Yellow;
                FindRecursive(tn);
            }
        }

        private void checkForCheckedChildren(object sender, TreeViewCancelEventArgs e)
        {
            if (!HasCheckedChildrenNodes(e.Node)) e.Cancel = true;
        }

        private bool HasCheckedChildrenNodes(TreeNode node)
        {
            if (node.Nodes.Count == 0) return false;
            foreach (TreeNode childNode in node.Nodes)
            {
                if (childNode.Checked) return true;
                if (HasCheckedChildrenNodes(childNode)) return true;
            }
            return false;
        }

        private void doNodes(XmlNode xn, TreeNodeCollection tn)
        {
            foreach (XmlNode child in xn.ChildNodes)
            {
                TreeNode newTN = null;

                //add a TreeNode to newTN, text depends on whether or not the current
                //XmlNode has children
                if (!child.HasChildNodes && !(child.Value == null))
                {
                    newTN = tn.Add(child.Value);
                }

                else
                {
                    newTN = tn.Add(child.Name);

                    //call this function again to do the children of the
                    //current XmlNode
                    doNodes(child, newTN.Nodes);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstbox.Items.Add(treeXML.SelectedNode);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            txtNodeSearch.Focus();
            cmdNodeSearch.Enabled = false;
        }

        private void txtNodeSearch_TextChanged(object sender, EventArgs e)
        {
            cmdNodeSearch.Enabled = true;
        }

        private void lstbox_DoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode nName = e.Node;
            string fileLocation = "";

            fileLocation = (string)nName.Tag;
            if (fileLocation != "")
            {
                System.Diagnostics.Process vbproc = new System.Diagnostics.Process();
                vbproc.StartInfo.FileName = @"C:\Documents and Settings\szorilla\VirtualBox VMs\Virtual Machine\Virtual Machine.vbox";
                vbproc.StartInfo.Arguments = "VirtualBox.exe";
                vbproc.StartInfo.WorkingDirectory = @"C:\Program Files\Oracle\VirtualBox\VirtualBox.exe";
                vbproc.Start();
            }
        }

        //private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        //{
        //    TreeNode nNname = e.Node;
        //    string fileLocation = "";

        //    fileLocation = (string)nNname.Tag;

        //    if (fileLocation != "")
        //    {
        //        System.Diagnostics.Process vbproc = new System.Diagnostics.Process();
        //        vbproc.StartInfo.FileName = @"C:\Documents and Settings\szorilla\VirtualBox VMs\Virtual Machine\Virtual Machine.vbox";
        //        vbproc.Start(); 
        //    }
        //}

        private void cmdNodeSearch_Click_1(object sender, EventArgs e)
        {
            ClearBackColor();
            FindByText();
        }
    }
}