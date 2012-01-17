using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
<<<<<<< HEAD
using System.IO;
using System.Reflection;
using System.Collections;
using System.Diagnostics;
=======
using System.DirectoryServices;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Collections;

>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e

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
<<<<<<< HEAD
=======
            //initialize the controls and the form
            //label1.Text = "Filepath";
            //textBox1.Text = Application.StartupPath + "sample1.xml";
            button1.Text = "Populate the treeview with XML";
            textBox1.Hide();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNodeSearch.Focus();
>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e
            try
            {
                //SECTION 1. Create a DOM Document and load the XML data into it.
                XmlDocument dom = new XmlDocument();
<<<<<<< HEAD
                dom.Load("Virtual Machine.xml");
=======
                dom.Load("New Machine.xml");
>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e

                //SECTION 2. Initialize the TreeView control.
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = treeView1.Nodes[0];

                //SECTION 3. Populate the TreeView with the DOM nodes.
                AddNode(dom.DocumentElement, tNode);
                treeView1.ExpandAll();
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
            TreeNodeCollection nodes = treeView1.Nodes;
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
            TreeNodeCollection nodes = treeView1.Nodes;
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

        private void showNodes_Click(object sender, EventArgs e)
        {
            //disable redrawing of treeView1 to prevent flickering while changes are made.
            treeView1.BeginUpdate();
            //collapse all nodes of treeView1.
            treeView1.CollapseAll();
            //add the checkForCheckedChildren event handler to the BeforeExpand event.
            treeView1.BeforeExpand += checkForCheckedChildren;
            //expand all nodes of treeView1. Nodes without checked children are prevented from expanding by the checkForCheckedChildren event handler.
            treeView1.ExpandAll();
            //remove the checkForCheckedChildren event handler from the BeforeExpand event so manual node expansion will work correctly.
            treeView1.BeforeExpand -= checkForCheckedChildren;
            //enable redrawing of treeView1.
            treeView1.EndUpdate();
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

<<<<<<< HEAD
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstbox.Items.Add(treeView1.SelectedNode);
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

        private void lstbox_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process vbproc = new System.Diagnostics.Process();
            vbproc.StartInfo.FileName = "cmd.exe";
            vbproc.StartInfo.Arguments = "{4fcb5de9-e5d6-43ed-a95d-4f1934be74be}.sav";
            vbproc.StartInfo.WorkingDirectory = @"C:\Program Files\Oracle\VirtualBox";
            vbproc.StartInfo.Arguments = "VBoxManage snapshot 'Virtual Machine' restore 'Snapshot 4'";
            vbproc.Start();
=======
        private void cmdVM_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "C:\\Program Files\\Oracle\\VirtualBox\\VirtualBox";
            proc.Start();
>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e
        }
    }
}