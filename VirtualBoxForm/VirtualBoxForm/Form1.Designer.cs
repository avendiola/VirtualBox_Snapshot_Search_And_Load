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
            this.SuspendLayout();
            // 
            // treeView1
            // 
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
            // 
            // cmdNodeSearch
            // 
            this.cmdNodeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
    }
}

