namespace KevinTools
{
    partial class CutControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            btn_cut = new Button();
            text_h = new TextBox();
            text_w = new TextBox();
            label2 = new Label();
            label1 = new Label();
            text_y = new TextBox();
            text_x = new TextBox();
            SuspendLayout();
            // 
            // btn_cut
            // 
            btn_cut.Location = new Point(186, 148);
            btn_cut.Name = "btn_cut";
            btn_cut.Size = new Size(94, 29);
            btn_cut.TabIndex = 22;
            btn_cut.Text = "确定";
            btn_cut.UseVisualStyleBackColor = true;
            btn_cut.Click += btn_cut_Click;
            // 
            // text_h
            // 
            text_h.Location = new Point(205, 74);
            text_h.Name = "text_h";
            text_h.Size = new Size(75, 27);
            text_h.TabIndex = 19;
            text_h.Text = "10";
            text_h.TextChanged += textChanged;
            // 
            // text_w
            // 
            text_w.Location = new Point(94, 74);
            text_w.Name = "text_w";
            text_w.Size = new Size(75, 27);
            text_w.TabIndex = 18;
            text_w.Text = "10";
            text_w.TextChanged += textChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 81);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 17;
            label2.Text = "裁剪大小：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 36);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 16;
            label1.Text = "裁剪位置：";
            // 
            // text_y
            // 
            text_y.Location = new Point(205, 33);
            text_y.Name = "text_y";
            text_y.Size = new Size(75, 27);
            text_y.TabIndex = 15;
            text_y.Text = "10";
            text_y.TextChanged += textChanged;
            // 
            // text_x
            // 
            text_x.Location = new Point(94, 33);
            text_x.Name = "text_x";
            text_x.Size = new Size(75, 27);
            text_x.TabIndex = 14;
            text_x.Text = "10";
            text_x.TextChanged += textChanged;
            // 
            // CutControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_cut);
            Controls.Add(text_h);
            Controls.Add(text_w);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_y);
            Controls.Add(text_x);
            Name = "CutControl";
            Size = new Size(300, 600);
            Load += CutControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btn_cut;
        private TextBox text_h;
        private TextBox text_w;
        private Label label2;
        private Label label1;
        private TextBox text_y;
        private TextBox text_x;
    }
}
