using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Diagnostics;
using System.DirectoryServices;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using VirtualBox;

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
                dom.Load("myMachineXP.xml");

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

        private void cmdNodeSearch_Click_2(object sender, EventArgs e)
        {
            ClearBackColor();
            FindByText();
        }

        private void lstbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Load the specific snapshot from XML File of Virtual Machine
            if (lstbox.Text.Equals("Service Configuration"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"myMachineXP\" restore \"Snapshot 2\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"myMachineXP\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (lstbox.Text.Equals("CentOS Installation"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"myMachineXP\" restore \"Snapshot 1\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"myMachineXP\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (lstbox.Text.Equals("Network Configuration"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"myMachineXP\" restore \"Snapshot 3\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"myMachineXP\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (lstbox.Text.Equals("Ethernet Device"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"myMachineXP\" restore \"Snapshot 4\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"myMachineXP\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }
        }

        private void treeXML_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstbox.Items.Add(treeXML.SelectedNode.Text);
        }
    }
}
                            
        
    



























