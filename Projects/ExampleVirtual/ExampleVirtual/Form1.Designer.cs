namespace ListView
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
            this.components = new System.ComponentModel.Container();
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.lwFilesAndFolders = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblCurrentPath
            // 
            this.lblCurrentPath.Location = new System.Drawing.Point(16, 8);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(528, 16);
            this.lblCurrentPath.TabIndex = 3;
            // 
            // ilLarge
            // 
            this.ilLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilSmall
            // 
            this.ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lwFilesAndFolders
            // 
            this.lwFilesAndFolders.LargeImageList = this.ilLarge;
            this.lwFilesAndFolders.Location = new System.Drawing.Point(16, 32);
            this.lwFilesAndFolders.MultiSelect = false;
            this.lwFilesAndFolders.Name = "lwFilesAndFolders";
            this.lwFilesAndFolders.Size = new System.Drawing.Size(631, 216);
            this.lwFilesAndFolders.SmallImageList = this.ilSmall;
            this.lwFilesAndFolders.TabIndex = 0;
            this.lwFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.lwFilesAndFolders.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1139, 293);
            this.Controls.Add(this.lblCurrentPath);
            this.Controls.Add(this.lwFilesAndFolders);
            this.Name = "Form1";
            this.Text = "ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}

