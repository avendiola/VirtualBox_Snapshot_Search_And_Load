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
using System.IO;

namespace Snapshots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void populateTreeControl(System.Xml.XmlNode doc, System.Windows.Forms.TreeNodeCollection nodes)
        {
            foreach (System.Xml.XmlNode node in doc.ChildNodes)
            {
                //if the element has a value
                //otherwise display the first attribute
                //(if there is one) or the element
                //(if there isn't)

                string text = (node.Value != null ? node.Value :
                (node.Attributes != null &&
                node.Attributes.Count > 0) ?
                node.Attributes[0].Value : node.Name);
                TreeNode new_child = new TreeNode(text);
                nodes.Add(new_child);
                populateTreeControl(node, new_child.Nodes);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Xml.XmlDocument document = new System.Xml.XmlDocument();
            document.Load(@"C:\Documents and Settings\szorilla\VirtualBox VMs\XP Machine\XP Machine.vbox");
            populateTreeControl(document.DocumentElement, treeView1.Nodes);

            XmlNodeList nodes = document.DocumentElement.SelectNodes("/Machine/MediaRegistry/Snapshots");

            foreach (XmlNode node in nodes)
            {
                txtSearch.Text += node.InnerText + "\r\n";
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            XPathDocument doc = new XPathDocument(Application.StartupPath + @"C:\Documents and Settings\szorilla\VirtualBox VMs\XP Machine\XP Machine.vbox");
            XPathNavigator navigator = doc.CreateNavigator();
            navigator.MoveToRoot();
            navigator.MoveToFirstChild();

            TreeNode root = treeView1.Nodes.Add("Machine");

            while (navigator.MoveToNext())
            {
                if (navigator.HasChildren)
                {
                    navigator.MoveToFirstChild();
                    do
                    {
                        string id = navigator.GetAttribute("Snapshots", "");
                        TreeNode empnode = new TreeNode("MachineRegistry :" + id);
                        root.Nodes.Add(empnode);
                        navigator.MoveToFirstChild();
                        do
                        {
                            string name = navigator.Name;
                            TreeNode node = new TreeNode(name + " : " + navigator.Value);
                            empnode.Nodes.Add(node);
                        }

                        while (navigator.MoveToNext());
                        navigator.MoveToParent();
                    }
                    while (navigator.MoveToNext());
                    {
                        ClearBackColor();
                        FindByText();
                    }
                }
            }
        }

        private void FindRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                //if the text properties match, color the item
                if (tn.Text == this.txtSearch.Text)
                    tn.BackColor = Color.Yellow;
                FindRecursive(tn);
            }
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

        private void FindByText()
        {
            TreeNodeCollection nodes = treeView1.Nodes;
            foreach (TreeNode n in nodes)
            {
                FindRecursive(n);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBox1.Items.Add(treeView1.SelectedNode);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //Load the specific snapshot from XML File of Virtual Machine
            if (listBox1.Text.Equals("Security Level Configuration"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 1\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Service Configuration"))
            {

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 2\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Root Directory"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 3\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Network"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 4\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Network Configuration"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 5\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Disk Usage Analyzer"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 6\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("VBOXADDITIONS"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 7\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Software Updater"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 8\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Software Updater"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 8\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Project Management"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 9\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }

            else if (listBox1.Text.Equals("Connect to Server"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                process.StartInfo.Arguments = "snapshot \"XP Machine\" restore \"Snapshot 10\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process vbprocess = new System.Diagnostics.Process();
                vbprocess.StartInfo.FileName = @"C:\Program Files\Oracle\VirtualBox\VBoxManage.exe";
                vbprocess.StartInfo.Arguments = "startvm \"XP Machine\"";
                vbprocess.StartInfo.UseShellExecute = false;
                vbprocess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                vbprocess.Start();
            }
        }
    }
}
