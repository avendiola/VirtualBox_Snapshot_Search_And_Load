namespace VirtualBoxForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeXML = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.cmdNodeSearch = new System.Windows.Forms.Button();
            this.txtNodeSearch = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeXML
            // 
            this.treeXML.HideSelection = false;
            this.treeXML.Location = new System.Drawing.Point(6, 6);
            this.treeXML.Name = "treeXML";
            this.treeXML.Size = new System.Drawing.Size(373, 389);
            this.treeXML.TabIndex = 0;
            this.treeXML.Tag = "C:\\Program Files\\Oracle\\VirtualBox> VBoxManage ";
            this.treeXML.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeXML_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 430);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeXML);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contents";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.Location = new System.Drawing.Point(408, 34);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(364, 407);
            this.lstbox.TabIndex = 9;
            this.lstbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbox_MouseDoubleClick);
            // 
            // cmdNodeSearch
            // 
            this.cmdNodeSearch.Location = new System.Drawing.Point(696, 5);
            this.cmdNodeSearch.Name = "cmdNodeSearch";
            this.cmdNodeSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdNodeSearch.TabIndex = 1;
            this.cmdNodeSearch.Text = "Search";
            this.cmdNodeSearch.UseVisualStyleBackColor = true;
            this.cmdNodeSearch.Click += new System.EventHandler(this.cmdNodeSearch_Click_2);
            // 
            // txtNodeSearch
            // 
            this.txtNodeSearch.Location = new System.Drawing.Point(501, 8);
            this.txtNodeSearch.Name = "txtNodeSearch";
            this.txtNodeSearch.Size = new System.Drawing.Size(189, 20);
            this.txtNodeSearch.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 460);
            this.Controls.Add(this.txtNodeSearch);
            this.Controls.Add(this.cmdNodeSearch);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "VirtualBoxSnapshot_Search_and_Load";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TreeView treeXML;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.Button cmdNodeSearch;
        private System.Windows.Forms.TextBox txtNodeSearch;
    }
}

