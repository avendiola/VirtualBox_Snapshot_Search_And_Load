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

namespace XML
{
    public partial class Form1 : Form
    {
        private XmlDocument docXML = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            docXML.Load("centos1.xml");  //load the xml file
            populateBaseNodes();   //Populate all of the base nodes

        }
        private void populateBaseNodes()
        {
            //treeViewMenu.Nodes.Clear();  //clear any existing items
            treeViewMenu.BeginUpdate();  //Begin updating the treeview
            TreeNode treenode;
            //treenode = treeViewMenu.Nodes.Add("VirtualBox");

            XmlNodeList baseNodeList = docXML.SelectNodes("VirtualBox/Machine");
            //get all first level <folder> nodes

            foreach (XmlNode xmlnode in baseNodeList)
            //loop through all base <folder> nodes
            {
                string title = xmlnode.Attributes["Virtual"].Value;

                treenode = treeViewMenu.Nodes.Add(title);   //add it to the tree

                populateChildNodes(xmlnode, treenode);  //get the children
            }

            treeViewMenu.EndUpdate();   //stop updating the tree
            treeViewMenu.Refresh();  //refresh the treeview display
        }

        private void populateChildNodes(XmlNode oldXmlnode, TreeNode oldTreenode)
        {
            TreeNode treenode = null;
            XmlNodeList childNodeList = oldXmlnode.ChildNodes;
            //get all children for the past node (parent)

            foreach (XmlNode xmlnode in childNodeList)
            //loop through all children
            {
                string title = xmlnode.Attributes[""].Value;
                //add it to the parent node tree
                treenode = oldTreenode.Nodes.Add(title);
                populateChildNodes(xmlnode, treenode);
            }
        }
    }
}

        

     