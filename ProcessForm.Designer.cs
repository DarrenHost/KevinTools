namespace KevinTools
{
    partial class ProcessForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            num_rows = new NumericUpDown();
            label5 = new Label();
            text_name = new TextBox();
            label4 = new Label();
            btn_cut = new Button();
            num_count = new NumericUpDown();
            label3 = new Label();
            text_h = new TextBox();
            text_w = new TextBox();
            label2 = new Label();
            label1 = new Label();
            text_y = new TextBox();
            text_x = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_rows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_count).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(358, 399);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(num_rows);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(text_name);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btn_cut);
            tabPage1.Controls.Add(num_count);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(text_h);
            tabPage1.Controls.Add(text_w);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(text_y);
            tabPage1.Controls.Add(text_x);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(350, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "批量裁剪";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // num_rows
            // 
            num_rows.Location = new Point(118, 132);
            num_rows.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_rows.Name = "num_rows";
            num_rows.Size = new Size(162, 27);
            num_rows.TabIndex = 13;
            num_rows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 179);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 12;
            label5.Text = "裁剪列数：";
            // 
            // text_name
            // 
            text_name.Location = new Point(118, 221);
            text_name.Name = "text_name";
            text_name.Size = new Size(162, 27);
            text_name.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 224);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 10;
            label4.Text = "文件前缀：";
            // 
            // btn_cut
            // 
            btn_cut.Location = new Point(186, 300);
            btn_cut.Name = "btn_cut";
            btn_cut.Size = new Size(94, 29);
            btn_cut.TabIndex = 8;
            btn_cut.Text = "预览";
            btn_cut.UseVisualStyleBackColor = true;
            btn_cut.Click += btn_cut_Click;
            // 
            // num_count
            // 
            num_count.Location = new Point(118, 177);
            num_count.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_count.Name = "num_count";
            num_count.Size = new Size(162, 27);
            num_count.TabIndex = 7;
            num_count.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 134);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "裁剪行数：";
            // 
            // text_h
            // 
            text_h.Location = new Point(212, 89);
            text_h.Name = "text_h";
            text_h.Size = new Size(68, 27);
            text_h.TabIndex = 5;
            // 
            // text_w
            // 
            text_w.Location = new Point(118, 89);
            text_w.Name = "text_w";
            text_w.Size = new Size(62, 27);
            text_w.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "裁剪大小：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 40);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "裁剪位置：";
            // 
            // text_y
            // 
            text_y.Location = new Point(212, 37);
            text_y.Name = "text_y";
            text_y.Size = new Size(68, 27);
            text_y.TabIndex = 1;
            // 
            // text_x
            // 
            text_x.Location = new Point(118, 37);
            text_x.Name = "text_x";
            text_x.Size = new Size(62, 27);
            text_x.TabIndex = 0;
            // 
            // ProcessForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 399);
            Controls.Add(tabControl1);
            Name = "ProcessForm";
            ShowIcon = false;
            Text = "编辑";
            Load += ProcessForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_rows).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_count).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btn_cut;
        private NumericUpDown num_count;
        private Label label3;
        private TextBox text_h;
        private TextBox text_w;
        private Label label2;
        private Label label1;
        private TextBox text_y;
        private TextBox text_x;
        private TextBox text_name;
        private Label label4;
        private Label label5;
        private NumericUpDown num_rows;
    }
}