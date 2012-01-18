using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace ListView
{
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Collections.Specialized.StringCollection folderCol;

        private System.Windows.Forms.ImageList ilLarge;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.ListView lwFilesAndFolders;
        private System.Windows.Forms.Label lblCurrentPath;

        public Form1()
        {
            InitializeComponent();

            // Init ListView and folder collection
            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHeadersAndFillListView();
            PaintListView(@"C:\");
            folderCol.Add(@"C:\");

            this.lwFilesAndFolders.ItemActivate += new System.EventHandler(this.lwFilesAndFolders_ItemActivate);
        }
        private void InitializeComponent()
        {
            //      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.ilLarge = new System.Windows.Forms.ImageList();
            this.ilSmall = new System.Windows.Forms.ImageList();
            this.lwFilesAndFolders = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            this.lblCurrentPath.Location = new System.Drawing.Point(16, 8);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(528, 16);
            this.lblCurrentPath.TabIndex = 3;
            // 
            // ilLarge
            // 
            this.ilLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilLarge.ImageSize = new System.Drawing.Size(32, 32);
            //      this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilSmall
            // 
            this.ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilSmall.ImageSize = new System.Drawing.Size(16, 16);
            //      this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lwFilesAndFolders
            // 
            this.lwFilesAndFolders.LargeImageList = this.ilLarge;
            this.lwFilesAndFolders.Location = new System.Drawing.Point(16, 32);
            this.lwFilesAndFolders.MultiSelect = false;
            this.lwFilesAndFolders.Name = "lwFilesAndFolders";
            this.lwFilesAndFolders.Size = new System.Drawing.Size(400, 216);
            this.lwFilesAndFolders.SmallImageList = this.ilSmall;
            this.lwFilesAndFolders.TabIndex = 0;
            this.lwFilesAndFolders.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(552, 293);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblCurrentPath, this.lwFilesAndFolders });
            this.Name = "Form1";
            this.Text = "ListView";
            this.ResumeLayout(false);

        }
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            this.lwFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Size";
            this.lwFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
            this.lwFilesAndFolders.Columns.Add(colHead);
        }

        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                this.lblCurrentPath.Text = root + "    (Double click to display the path name)";

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(root);

                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                this.lwFilesAndFolders.Items.Clear();

                this.lwFilesAndFolders.BeginUpdate();

                foreach (System.IO.FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    this.lwFilesAndFolders.Items.Add(lvi);
                }
                this.lwFilesAndFolders.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            this.lwFilesAndFolders.View = View.Details;
        }

        private void lwFilesAndFolders_ItemActivate(object sender, System.EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();

            try
            {
                System.Diagnostics.Process.Start(filename);
            }
            catch
            {
                return;
            }
        }
    }
}