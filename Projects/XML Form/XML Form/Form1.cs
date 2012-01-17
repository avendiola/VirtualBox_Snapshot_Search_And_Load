using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XML_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //start off by adding a base treeview node
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "mainNode";
            mainNode.Text = "main";
            this.treeView1.Nodes.Add(mainNode);
        }

        //display about the selected code
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                txtname.Text = "";
                txtParent.Text = "";
                txtText.Text = "";
                txtTag.Text = "";

                txtname.Text = treeView1.SelectedNode.Name.ToString();
                txtText.Text = treeView1.SelectedNode.Text.ToString();
                txtTag.Text = treeView1.SelectedNode.Tag.ToString();
                txtParent.Text = treeView1.SelectedNode.Parent.Text.ToString();
        }
            catch { }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            ClearBackColor();
        }

        private void btnNodeTagSearch_Click(object sender, EventArgs e)
        {
            ClearBackColor();
            FindByTag();
        }

        private void FindByTag()
        {
            TreeNodeCollection nodes = treeView1.Nodes;
            foreach (TreeNode n in nodes)
            {
                FindRecursiveTag(n);
            }
        }

        private void FindRecursiveTag(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                //if the text properties match, color the item
                if (tn.Tag.ToString() == this.txtTagSearch.Text)
                    tn.BackColor = Color.Yellow;

                FindRecursiveTag(tn);
            }
        }

        private void btnNodeTextSearch_Click(object sender, EventArgs e)
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
                //if the text properties match, color the item)
                if(tn.Text == this.txtNodeTextSearch.Text)
                    tn.BackColor = Color.Yellow;

                FindRecursive(tn);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //initialize the controls and the form.368;


        }
