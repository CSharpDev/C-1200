namespace TreeForm
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("企业类型设置");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("企业性质设置");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("企业级别设置");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("企业资信设置");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("基础信息维护", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("客户信息");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("联系人信息");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("业务往来");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("客户信息维护", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("客户投诉");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("客户反馈");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("客户服务", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("联系人信息查询");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("客户信息查询");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("客户信息查询", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("客户信息报表");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("业务往来报表");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("联系人信息报表");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("打印报表", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("调用Word");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("调用Excel");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("辅助工具", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息维护ToolStripMenuItem,
            this.客户信息维护ToolStripMenuItem,
            this.客户服务ToolStripMenuItem,
            this.客户信息查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息维护ToolStripMenuItem
            // 
            this.基础信息维护ToolStripMenuItem.Name = "基础信息维护ToolStripMenuItem";
            this.基础信息维护ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.基础信息维护ToolStripMenuItem.Text = "基础信息维护";
            // 
            // 客户信息维护ToolStripMenuItem
            // 
            this.客户信息维护ToolStripMenuItem.Name = "客户信息维护ToolStripMenuItem";
            this.客户信息维护ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.客户信息维护ToolStripMenuItem.Text = "客户信息维护";
            // 
            // 客户服务ToolStripMenuItem
            // 
            this.客户服务ToolStripMenuItem.Name = "客户服务ToolStripMenuItem";
            this.客户服务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客户服务ToolStripMenuItem.Text = "客户服务";
            // 
            // 客户信息查询ToolStripMenuItem
            // 
            this.客户信息查询ToolStripMenuItem.Name = "客户信息查询ToolStripMenuItem";
            this.客户信息查询ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.客户信息查询ToolStripMenuItem.Text = "客户信息查询";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 77);
            this.treeView1.Name = "treeView1";
            treeNode23.Name = "节点1";
            treeNode23.Text = "企业类型设置";
            treeNode24.Name = "节点2";
            treeNode24.Text = "企业性质设置";
            treeNode25.Name = "节点3";
            treeNode25.Text = "企业级别设置";
            treeNode26.Name = "节点4";
            treeNode26.Text = "企业资信设置";
            treeNode27.Name = "节点0";
            treeNode27.Text = "基础信息维护";
            treeNode28.Name = "节点6";
            treeNode28.Text = "客户信息";
            treeNode29.Name = "节点7";
            treeNode29.Text = "联系人信息";
            treeNode30.Name = "节点9";
            treeNode30.Text = "业务往来";
            treeNode31.Name = "节点5";
            treeNode31.Text = "客户信息维护";
            treeNode32.Name = "节点11";
            treeNode32.Text = "客户投诉";
            treeNode33.Name = "节点12";
            treeNode33.Text = "客户反馈";
            treeNode34.Name = "节点10";
            treeNode34.Text = "客户服务";
            treeNode35.Name = "节点14";
            treeNode35.Text = "联系人信息查询";
            treeNode36.Name = "节点15";
            treeNode36.Text = "客户信息查询";
            treeNode37.Name = "节点13";
            treeNode37.Text = "客户信息查询";
            treeNode38.Name = "节点17";
            treeNode38.Text = "客户信息报表";
            treeNode39.Name = "节点18";
            treeNode39.Text = "业务往来报表";
            treeNode40.Name = "节点20";
            treeNode40.Text = "联系人信息报表";
            treeNode41.Name = "节点16";
            treeNode41.Text = "打印报表";
            treeNode42.Name = "节点21";
            treeNode42.Text = "调用Word";
            treeNode43.Name = "节点22";
            treeNode43.Text = "调用Excel";
            treeNode44.Name = "节点19";
            treeNode44.Text = "辅助工具";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode31,
            treeNode34,
            treeNode37,
            treeNode41,
            treeNode44});
            this.treeView1.Size = new System.Drawing.Size(139, 393);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TreeForm.Properties.Resources.右;
            this.pictureBox2.Location = new System.Drawing.Point(136, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(581, 416);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TreeForm.Properties.Resources.上;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 473);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "以树形显示的程序界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息查询ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

