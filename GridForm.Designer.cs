namespace KevinTools
{
    partial class GridForm
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
            label5 = new Label();
            num_size = new NumericUpDown();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            label2 = new Label();
            pic_color = new PictureBox();
            btn_ok = new Button();
            cb_enabled = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)num_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_color).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 44);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 18;
            label5.Text = "网格大小：";
            // 
            // num_size
            // 
            num_size.Location = new Point(102, 37);
            num_size.Name = "num_size";
            num_size.Size = new Size(186, 27);
            num_size.TabIndex = 15;
            num_size.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 44);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 20;
            label1.Text = "px";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 21;
            label2.Text = "线条颜色：";
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.DarkGray;
            pic_color.Location = new Point(102, 91);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(186, 34);
            pic_color.TabIndex = 22;
            pic_color.TabStop = false;
            pic_color.Click += pic_color_Click;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(194, 209);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(94, 29);
            btn_ok.TabIndex = 23;
            btn_ok.Text = "确定";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // cb_enabled
            // 
            cb_enabled.AutoSize = true;
            cb_enabled.Location = new Point(102, 143);
            cb_enabled.Name = "cb_enabled";
            cb_enabled.Size = new Size(91, 24);
            cb_enabled.TabIndex = 24;
            cb_enabled.Text = "显示网格";
            cb_enabled.UseVisualStyleBackColor = true;
            // 
            // GridForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 275);
            Controls.Add(cb_enabled);
            Controls.Add(btn_ok);
            Controls.Add(pic_color);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(num_size);
            Name = "GridForm";
            ShowIcon = false;
            Text = "网格设置";
            Load += GridForm_Load;
            KeyDown += GridForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)num_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_color).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private NumericUpDown num_size;
        private Label label1;
        private ColorDialog colorDialog1;
        private Label label2;
        private PictureBox pic_color;
        private Button btn_ok;
        private CheckBox cb_enabled;
    }
}