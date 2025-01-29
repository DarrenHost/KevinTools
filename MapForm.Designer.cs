namespace KevinTools
{
    partial class MapForm
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
            picMain = new PictureBox();
            textBox1 = new TextBox();
            btnOpen = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            folderBrowserDialog1 = new FolderBrowserDialog();
            statusStrip1 = new StatusStrip();
            tssi_progress = new ToolStripProgressBar();
            tssl_xy = new ToolStripStatusLabel();
            tssi_msg = new ToolStripStatusLabel();
            groupBox2 = new GroupBox();
            btnSelect = new Button();
            txt_y = new TextBox();
            label3 = new Label();
            txt_x = new TextBox();
            label2 = new Label();
            cb_model = new CheckBox();
            label1 = new Label();
            txt_bgh = new TextBox();
            txt_bgw = new TextBox();
            linkBackground = new LinkLabel();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btn_save = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)picMain).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // picMain
            // 
            picMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picMain.Location = new Point(3, 3);
            picMain.Name = "picMain";
            picMain.Size = new Size(534, 474);
            picMain.TabIndex = 0;
            picMain.TabStop = false;
            picMain.Paint += picMain_Paint;
            picMain.MouseClick += picMain_MouseClick;
            picMain.MouseMove += picMain_MouseMove;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(6, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 2;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpen.Location = new Point(146, 6);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(99, 29);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "加载素材";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.GridLines = true;
            listView1.Location = new Point(0, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(249, 436);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "素材";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssi_progress, tssl_xy, tssi_msg });
            statusStrip1.Location = new Point(0, 477);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1019, 28);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssi_progress
            // 
            tssi_progress.Enabled = false;
            tssi_progress.Name = "tssi_progress";
            tssi_progress.Size = new Size(167, 20);
            // 
            // tssl_xy
            // 
            tssl_xy.Name = "tssl_xy";
            tssl_xy.Size = new Size(55, 22);
            tssl_xy.Text = "x：y：";
            // 
            // tssi_msg
            // 
            tssi_msg.Name = "tssi_msg";
            tssi_msg.Size = new Size(54, 22);
            tssi_msg.Text = "已就绪";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnSelect);
            groupBox2.Controls.Add(txt_y);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_x);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(543, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 233);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "属性";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(68, 134);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 4;
            btnSelect.Text = "选择其他";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txt_y
            // 
            txt_y.Location = new Point(66, 84);
            txt_y.Name = "txt_y";
            txt_y.Size = new Size(142, 27);
            txt_y.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 87);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "y：";
            // 
            // txt_x
            // 
            txt_x.Location = new Point(66, 42);
            txt_x.Name = "txt_x";
            txt_x.Size = new Size(142, 27);
            txt_x.TabIndex = 1;
            txt_x.TextChanged += sprite_point_changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 45);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 0;
            label2.Text = "x：";
            // 
            // cb_model
            // 
            cb_model.AutoSize = true;
            cb_model.Location = new Point(66, 150);
            cb_model.Name = "cb_model";
            cb_model.Size = new Size(91, 24);
            cb_model.TabIndex = 4;
            cb_model.Text = "是否平铺";
            cb_model.UseVisualStyleBackColor = true;
            cb_model.CheckedChanged += cb_model_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 75);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 3;
            label1.Text = "宽：";
            // 
            // txt_bgh
            // 
            txt_bgh.Location = new Point(66, 108);
            txt_bgh.Name = "txt_bgh";
            txt_bgh.Size = new Size(142, 27);
            txt_bgh.TabIndex = 2;
            // 
            // txt_bgw
            // 
            txt_bgw.Location = new Point(66, 72);
            txt_bgw.Name = "txt_bgw";
            txt_bgw.Size = new Size(142, 27);
            txt_bgw.TabIndex = 1;
            // 
            // linkBackground
            // 
            linkBackground.AutoSize = true;
            linkBackground.Location = new Point(16, 35);
            linkBackground.Name = "linkBackground";
            linkBackground.Size = new Size(156, 20);
            linkBackground.TabIndex = 0;
            linkBackground.TabStop = true;
            linkBackground.Text = "点击选择游戏背景图...";
            linkBackground.LinkClicked += linkBackground_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cb_model);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_bgh);
            groupBox1.Controls.Add(txt_bgw);
            groupBox1.Controls.Add(linkBackground);
            groupBox1.Location = new Point(543, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 180);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "背景";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 111);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 5;
            label4.Text = "高：";
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_save.Location = new Point(566, 428);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(188, 35);
            btn_save.TabIndex = 6;
            btn_save.Text = "保存地图";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listView1);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(btnOpen);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(picMain);
            splitContainer1.Panel2.Controls.Add(btn_save);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1019, 477);
            splitContainer1.SplitterDistance = 252;
            splitContainer1.TabIndex = 7;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 505);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            KeyPreview = true;
            Name = "MapForm";
            Text = "地图编辑器";
            WindowState = FormWindowState.Maximized;
            FormClosing += MapForm_FormClosing;
            Load += MapForm_Load;
            KeyDown += MapForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picMain).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button btnOpen;
        private ListView listView1;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox picMain;
        private ColumnHeader columnHeader1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssl_xy;
        private ToolStripStatusLabel tssi_msg;
        private GroupBox groupBox2;
        private CheckBox cb_model;
        private Label label1;
        private TextBox txt_bgh;
        private TextBox txt_bgw;
        private LinkLabel linkBackground;
        private GroupBox groupBox1;
        private Button btn_save;
        private SplitContainer splitContainer1;
        private ToolStripProgressBar tssi_progress;
        private Label label2;
        private TextBox txt_y;
        private Label label3;
        private TextBox txt_x;
        private Label label4;
        private Button btnSelect;
    }
}