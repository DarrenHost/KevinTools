namespace KevinTools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmi_file = new ToolStripMenuItem();
            tsmi_image = new ToolStripMenuItem();
            tsim_map = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmi_file, tsmi_image, tsim_map });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            tsmi_file.Name = "tsmi_file";
            tsmi_file.Size = new Size(53, 24);
            tsmi_file.Text = "开始";
            tsmi_file.Click += tsmi_file_Click;
            // 
            // tsmi_image
            // 
            tsmi_image.Name = "tsmi_image";
            tsmi_image.Size = new Size(83, 24);
            tsmi_image.Text = "素材处理";
            tsmi_image.Click += tsmi_image_Click;
            // 
            // tsim_map
            // 
            tsim_map.Name = "tsim_map";
            tsim_map.Size = new Size(83, 24);
            tsim_map.Text = "地图编辑";
            tsim_map.Click += tsim_map_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "凯风工具箱";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmi_file;
        private ToolStripMenuItem tsmi_image;
        private ToolStripMenuItem tsim_map;
    }
}
