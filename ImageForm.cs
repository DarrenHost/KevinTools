using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinTools
{
    public partial class ImageForm : Form
    {

        private string fileName = string.Empty;
        private UserControl currentControl;
        public ImageForm()
        {
            InitializeComponent();
        }

        private int Operation_Current;

        public class PaintCut
        {
            public string fileName;
            public Rectangle rect;
            public int state = 0;
        }


        public void SplitImage(Image originalImage, string path)
        {

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string name = ProcessForm.DataResult.CutData.Name;
            Rectangle rect = ProcessForm.DataResult.CutData.Rectangle;
            int[] table = ProcessForm.DataResult.CutData.Table;

            if (table == null || table.Length < 2)
            {
                return;
            }

            int columns = table[0];
            int rows = table[1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // 创建新的Bitmap对象用于存储分割后的图片
                    Bitmap newImage = new Bitmap(rect.Width, rect.Height);

                    // 使用Graphics对象在新图片上绘制原始图片的指定部分
                    using (Graphics g = Graphics.FromImage(newImage))
                    {
                        g.DrawImage(originalImage, new Rectangle(0, 0, rect.Width, rect.Height),
                            new Rectangle(rect.X + (rect.Width * j), rect.Y + (rect.Height * i), rect.Width, rect.Height), GraphicsUnit.Pixel);
                    }
                    newImage.Save(string.Format("{0}/{1}_{2}_{3}.png", path, name, i, j), ImageFormat.Png);

                }
            }


        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {


            if (!GridForm.ResultData.Enabled)
            {
                return;
            }
            Rectangle rect = new Rectangle(0, 0, GridForm.ResultData.Size, GridForm.ResultData.Size);


            using (Pen pen = new Pen(GridForm.ResultData.Color, 1))
            {

                Graphics g = e.Graphics;


                decimal w = this.splitContainer1.Panel1.Width / rect.Width;
                decimal h = this.splitContainer1.Panel1.Height / rect.Height;
                int columns = (int)Math.Truncate(w);
                int rows = (int)Math.Truncate(h);

                for (int i = 0; i <= rows; i++)
                {
                    g.DrawLine(pen, new Point(0, rect.Height * i), new Point(this.splitContainer1.Panel1.Width, rect.Height * i));


                }
                for (int j = 0; j <= columns; j++)
                {
                    g.DrawLine(pen, new Point(rect.Width * j, 0), new Point(rect.Width * j, this.splitContainer1.Panel1.Height));

                }

                pen.Dispose();

            }


        }

        private void pic_main_MouseMove(object sender, MouseEventArgs e)
        {
            this.tssl_msg.Text = string.Format("x:{0},y:{1}", e.X, e.Y);

            if (this.tsb_cut.Tag != null)
            {

                if (this.tsb_cut.Tag is PaintCut)
                {
                    PaintCut cut = (PaintCut)this.tsb_cut.Tag;

                    if (cut.state == 1)
                    {
                        cut.rect.Width = e.X - cut.rect.X;
                        cut.rect.Height = e.Y - cut.rect.Y;

                        this.pic_main.Invalidate();
                    }

                }
            }

        }

        private void showEditWindow()
        {

            ProcessForm processForm = new ProcessForm();
            DialogResult dialogResult = processForm.ShowDialog();
            if (dialogResult == DialogResult.Continue)
            {
                this.Operation_Current = 1;
            }
            else if (dialogResult == DialogResult.OK)
            {
                this.Operation_Current = 0;
            }

            this.pic_main.Invalidate();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (this.Operation_Current > 0)
            {
                // 获取Graphics对象用于绘图
                Graphics g = e.Graphics;

                // 设置绘制矩形的颜色
                Pen pen = new Pen(Color.Red, 1);

                Rectangle rect = ProcessForm.DataResult.CutData.Rectangle;
                int[] table = ProcessForm.DataResult.CutData.Table;

                if (table == null || table.Length < 2)
                {
                    return;
                }

                int columns = table[0];
                int rows = table[1];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        g.DrawRectangle(pen, new Rectangle(rect.X + (rect.Width * j), rect.Y + (rect.Height * i), rect.Width, rect.Height));
                    }
                }

                // 释放资源
                pen.Dispose();
            }

            this.DrawEdit(e.Graphics);
        }

        private void tsmi_open_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件|*.png|图片文件|*.jpg|图片文件|*.jpeg|图片文件|*.bmp";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.fileName = openFileDialog.FileName;

                this.pic_main.Load(openFileDialog.FileName);

                this.tssl_file.Text = openFileDialog.FileName;
            }

        }

        private void tsmi_cut_Click(object sender, EventArgs e)
        {
            this.showEditWindow();
        }

        private void tsb_cut_Click(object sender, EventArgs e)
        {

            if (this.fileName == string.Empty)
            {
                return;
            }

            
            if (tsb_cut.Tag == null)
            {

                this.splitContainer1.Panel2.Controls.Clear();

                CutControl cutControl = new CutControl();
                cutControl.mainControl = this.pic_main;
                cutControl.resultEventHandler += CutControl_resultEventHandler;

                PaintCut paintCut = new PaintCut();
                paintCut.fileName = this.fileName;
                tsb_cut.Tag = paintCut;
                cutControl.PaintCut = paintCut;
                this.currentControl = cutControl;
                this.splitContainer1.Panel2.Controls.Add(cutControl);
                splitContainer1.SplitterDistance = splitContainer1.Width - cutControl.Width;
            }
            else
            {
                tsb_cut.Tag = null;

            }


            this.pic_main.Invalidate();

        }

        private void CutControl_resultEventHandler(object? sender, EventArgs e)
        {
            if (this.tsb_cut.Tag is PaintCut)
            {

                PaintCut paintCut = ((PaintCut)this.tsb_cut.Tag);
                this.fileName = paintCut.fileName;
                this.pic_main.Load(paintCut.fileName);
                this.tssl_file.Text = paintCut.fileName;

                this.tsb_cut.Tag = null;
            }

        }

        private void pic_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (tsb_cut.Tag != null)
            {
                PaintCut cut = (PaintCut)tsb_cut.Tag;
                cut.rect = new Rectangle(e.X, e.Y, 0, 0);
                cut.state = 1;


            }

        }

        private void DrawEdit(Graphics g)
        {
            if (tsb_cut.Tag != null)
            {
                if (this.tsb_cut.Tag is PaintCut)
                {
                    PaintCut cut = (PaintCut)this.tsb_cut.Tag;
                    Rectangle rect = cut.rect;

                    if (rect.Width > 0 && rect.Height > 0)
                    {

                        using (Pen pen = new Pen(Color.Green, 1))
                        {
                            g.DrawRectangle(pen, rect);
                        }

                    }

                    this.tssl_info.Text = string.Format("矩形：{0}，{1}，{2}，{3}", rect.X, rect.Y, rect.Width, rect.Height);

                }
            }
            
        }

        private void pic_main_MouseUp(object sender, MouseEventArgs e)
        {
            PaintCut cut = ((PaintCut)tsb_cut.Tag);
            if (cut != null)
            {
                cut.state = 2;
            }
            if (this.currentControl is CutControl)
            {
                this.currentControl.Refresh();
            }


        }

        private void tsmi_exp_Click(object sender, EventArgs e)
        {

            if (this.fileName == string.Empty)
            {
                return;
            }

            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {

                return;
            }




            string path = Path.Combine(folderBrowserDialog1.SelectedPath);

            Image originalImage = Bitmap.FromFile(this.fileName);

            this.SplitImage(originalImage, path);


            originalImage.Dispose();

            MessageBox.Show("导出文件成功：" + path);
        }

        private void tsmi_grid_Click(object sender, EventArgs e)
        {
            GridForm gridForm = new GridForm();
            gridForm.ShowDialog();
            this.splitContainer1.Panel1.Invalidate();
        }

        private void ImageForm_Resize(object sender, EventArgs e)
        {
            if (splitContainer1.Width > 500)
            {

                splitContainer1.SplitterDistance = splitContainer1.Width - 300;
            }

        }

        private void tssl_file_TextChanged(object sender, EventArgs e)
        {

            if (this.pic_main.Image != null) {
                this.tssl_size.Text = string.Format("{0}x{1}", this.pic_main.Image.Width, this.pic_main.Image.Height);
            }
           
        }
    }
}
