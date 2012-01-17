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
            this.treeView1 = new System.Windows.Forms.TreeView();
<<<<<<< HEAD
            this.lstbox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdNodeSearch = new System.Windows.Forms.Button();
            this.txtNodeSearch = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
=======
            this.txtNodeSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdNodeSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showNodes = new System.Windows.Forms.Button();
            this.cmdVM = new System.Windows.Forms.Button();
            this.lView = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e
            this.SuspendLayout();
            // 
            // treeView1
            // 
<<<<<<< HEAD
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(5, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(402, 678);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.Location = new System.Drawing.Point(439, 126);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(551, 602);
            this.lstbox.TabIndex = 7;
            this.lstbox.DoubleClick += new System.EventHandler(this.lstbox_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 716);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contents";
            this.tabPage1.UseVisualStyleBackColor = true;
=======
            this.treeView1.Location = new System.Drawing.Point(30, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(553, 729);
            this.treeView1.TabIndex = 0;
            // 
            // txtNodeSearch
            // 
            this.txtNodeSearch.Location = new System.Drawing.Point(151, 30);
            this.txtNodeSearch.Name = "txtNodeSearch";
            this.txtNodeSearch.Size = new System.Drawing.Size(298, 20);
            this.txtNodeSearch.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdNodeSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNodeSearch);
            this.groupBox1.Location = new System.Drawing.Point(656, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Node Text Search";
>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e
            // 
            // cmdNodeSearch
            // 
            this.cmdNodeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.cmdNodeSearch.Location = new System.Drawing.Point(580, 66);
            this.cmdNodeSearch.Name = "cmdNodeSearch";
            this.cmdNodeSearch.Size = new System.Drawing.Size(74, 23);
            this.cmdNodeSearch.TabIndex = 1;
            this.cmdNodeSearch.Text = "Search";
            this.cmdNodeSearch.UseVisualStyleBackColor = true;
            this.cmdNodeSearch.Click += new System.EventHandler(this.cmdNodeSearch_Click);
            // 
            // txtNodeSearch
            // 
            this.txtNodeSearch.AllowDrop = true;
            this.txtNodeSearch.Location = new System.Drawing.Point(468, 40);
            this.txtNodeSearch.Name = "txtNodeSearch";
            this.txtNodeSearch.Size = new System.Drawing.Size(297, 20);
            this.txtNodeSearch.TabIndex = 0;
            this.txtNodeSearch.TextChanged += new System.EventHandler(this.txtNodeSearch_TextChanged);
=======
            this.cmdNodeSearch.Location = new System.Drawing.Point(242, 61);
            this.cmdNodeSearch.Name = "cmdNodeSearch";
            this.cmdNodeSearch.Size = new System.Drawing.Size(94, 23);
            this.cmdNodeSearch.TabIndex = 3;
            this.cmdNodeSearch.Text = "Search Node";
            this.cmdNodeSearch.UseVisualStyleBackColor = true;
            this.cmdNodeSearch.Click += new System.EventHandler(this.cmdNodeSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text String";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(973, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search Results";
            // 
            // showNodes
            // 
            this.showNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNodes.Location = new System.Drawing.Point(318, 6);
            this.showNodes.Name = "showNodes";
            this.showNodes.Size = new System.Drawing.Size(112, 23);
            this.showNodes.TabIndex = 4;
            this.showNodes.Text = "Collapse Nodes";
            this.showNodes.UseVisualStyleBackColor = true;
            this.showNodes.Click += new System.EventHandler(this.showNodes_Click);
            // 
            // cmdVM
            // 
            this.cmdVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVM.Location = new System.Drawing.Point(436, 6);
            this.cmdVM.Name = "cmdVM";
            this.cmdVM.Size = new System.Drawing.Size(147, 23);
            this.cmdVM.TabIndex = 4;
            this.cmdVM.Text = "Virtual Machine";
            this.cmdVM.UseVisualStyleBackColor = true;
            this.cmdVM.Click += new System.EventHandler(this.cmdVM_Click_1);
            // 
            // lView
            // 
            this.lView.FormattingEnabled = true;
            this.lView.Location = new System.Drawing.Point(656, 236);
            this.lView.Name = "lView";
            this.lView.Size = new System.Drawing.Size(463, 433);
            this.lView.TabIndex = 8;
>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1004, 738);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.txtNodeSearch);
            this.Controls.Add(this.cmdNodeSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
=======
            this.ClientSize = new System.Drawing.Size(1154, 791);
            this.Controls.Add(this.lView);
            this.Controls.Add(this.cmdVM);
            this.Controls.Add(this.showNodes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e
            this.ResumeLayout(false);
            this.PerformLayout();

        }
<<<<<<< HEAD
        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdNodeSearch;
        private System.Windows.Forms.TextBox txtNodeSearch;
=======

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtNodeSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdNodeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showNodes;
        private System.Windows.Forms.Button cmdVM;
        private System.Windows.Forms.ListBox lView;
>>>>>>> cf35eff97007bc61b8a99437f87b2cff4371e22e
    }
}

