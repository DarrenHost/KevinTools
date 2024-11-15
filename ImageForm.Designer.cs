namespace KevinTools
{
    partial class ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            pic_main = new PictureBox();
            statusStrip1 = new StatusStrip();
            tssl_file = new ToolStripStatusLabel();
            tssl_msg = new ToolStripStatusLabel();
            tssl_info = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            tsmi_open = new ToolStripMenuItem();
            tsmi_exit = new ToolStripMenuItem();
            tsmi_edit = new ToolStripMenuItem();
            tsmi_cut = new ToolStripMenuItem();
            tsmi_grid = new ToolStripMenuItem();
            tsmi_exp = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            tsb_cut = new ToolStripButton();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tssl_size = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pic_main).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pic_main
            // 
            pic_main.BackColor = Color.Transparent;
            pic_main.Dock = DockStyle.Fill;
            pic_main.Location = new Point(0, 0);
            pic_main.Margin = new Padding(10);
            pic_main.Name = "pic_main";
            pic_main.Size = new Size(749, 699);
            pic_main.TabIndex = 0;
            pic_main.TabStop = false;
            pic_main.Paint += pictureBox1_Paint;
            pic_main.MouseDown += pic_main_MouseDown;
            pic_main.MouseMove += pic_main_MouseMove;
            pic_main.MouseUp += pic_main_MouseUp;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssl_file, tssl_size, tssl_msg, tssl_info });
            statusStrip1.Location = new Point(0, 727);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1006, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssl_file
            // 
            tssl_file.Name = "tssl_file";
            tssl_file.Size = new Size(69, 20);
            tssl_file.Text = "准备就绪";
            tssl_file.TextChanged += tssl_file_TextChanged;
            // 
            // tssl_msg
            // 
            tssl_msg.Name = "tssl_msg";
            tssl_msg.Size = new Size(71, 20);
            tssl_msg.Text = "tssl_msg";
            // 
            // tssl_info
            // 
            tssl_info.Name = "tssl_info";
            tssl_info.Size = new Size(0, 20);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, tsmi_edit, tsmi_grid, tsmi_exp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmi_open, tsmi_exit });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(53, 24);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // tsmi_open
            // 
            tsmi_open.Name = "tsmi_open";
            tsmi_open.Size = new Size(152, 26);
            tsmi_open.Text = "打开文件";
            tsmi_open.Click += tsmi_open_Click;
            // 
            // tsmi_exit
            // 
            tsmi_exit.Name = "tsmi_exit";
            tsmi_exit.Size = new Size(152, 26);
            tsmi_exit.Text = "退出";
            // 
            // tsmi_edit
            // 
            tsmi_edit.DropDownItems.AddRange(new ToolStripItem[] { tsmi_cut });
            tsmi_edit.Name = "tsmi_edit";
            tsmi_edit.Size = new Size(53, 24);
            tsmi_edit.Text = "编辑";
            // 
            // tsmi_cut
            // 
            tsmi_cut.Name = "tsmi_cut";
            tsmi_cut.Size = new Size(152, 26);
            tsmi_cut.Text = "批量裁剪";
            tsmi_cut.Click += tsmi_cut_Click;
            // 
            // tsmi_grid
            // 
            tsmi_grid.Name = "tsmi_grid";
            tsmi_grid.Size = new Size(53, 24);
            tsmi_grid.Text = "网格";
            tsmi_grid.Click += tsmi_grid_Click;
            // 
            // tsmi_exp
            // 
            tsmi_exp.Name = "tsmi_exp";
            tsmi_exp.Size = new Size(53, 24);
            tsmi_exp.Text = "导出";
            tsmi_exp.Click += tsmi_exp_Click;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.AutoScroll = true;
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(976, 699);
            toolStripContainer1.Dock = DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            toolStripContainer1.LeftToolStripPanel.Controls.Add(toolStrip1);
            toolStripContainer1.Location = new Point(0, 28);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(1006, 699);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pic_main);
            splitContainer1.Size = new Size(976, 699);
            splitContainer1.SplitterDistance = 749;
            splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_cut });
            toolStrip1.Location = new Point(0, 4);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(30, 39);
            toolStrip1.TabIndex = 0;
            // 
            // tsb_cut
            // 
            tsb_cut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_cut.Image = Properties.Resources.cut;
            tsb_cut.ImageTransparentColor = Color.Magenta;
            tsb_cut.Name = "tsb_cut";
            tsb_cut.Size = new Size(28, 24);
            tsb_cut.Text = "矩形";
            tsb_cut.Click += tsb_cut_Click;
            // 
            // tssl_size
            // 
            tssl_size.Name = "tssl_size";
            tssl_size.Size = new Size(67, 20);
            tssl_size.Text = "tssl_size";
            // 
            // ImageForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 753);
            Controls.Add(toolStripContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "ImageForm";
            Text = " 凯风游戏素材编辑器 by Kevin";
            Load += ImageForm_Load;
            Resize += ImageForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pic_main).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            toolStripContainer1.LeftToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pic_main;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssl_msg;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem tsmi_open;
        private ToolStripMenuItem tsmi_exit;
        private ToolStripMenuItem tsmi_edit;
        private ToolStripMenuItem tsmi_exp;
        private ToolStripMenuItem tsmi_cut;
        private ToolStripStatusLabel tssl_file;
        private ToolStripContainer toolStripContainer1;
        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsb_cut;
        private ToolStripStatusLabel tssl_info;
        private ToolStripMenuItem tsmi_grid;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripStatusLabel tssl_size;
    }
}