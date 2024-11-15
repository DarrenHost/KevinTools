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
    public partial class CutControl : UserControl
    {


        public ImageForm.PaintCut PaintCut { get; set; } = new ImageForm.PaintCut();
        public Control mainControl;
        public event EventHandler resultEventHandler;
        public CutControl()
        {
            InitializeComponent();
        }

        private void CutControl_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }
        public void RefreshData()
        {

            if (PaintCut != null)
            {
                this.text_x.Text = this.PaintCut.rect.X.ToString();
                this.text_y.Text = this.PaintCut.rect.Y.ToString();
                this.text_w.Text = this.PaintCut.rect.Width.ToString();
                this.text_h.Text = this.PaintCut.rect.Height.ToString();

            }
        }

        public override void Refresh()
        {
            base.Refresh();
            this.RefreshData();
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "图片文件|*.png|图片文件|*.jpg|图片文件|*.jpeg|图片文件|*.bmp";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {
               bool success=  this.CutImage(this.PaintCut.fileName, PaintCut.rect,saveFileDialog.FileName);

                if (success) {
                    dialogResult = MessageBox.Show("是否打开新文件继续编辑", "裁剪完成", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        this.PaintCut.fileName = saveFileDialog.FileName;
                        resultEventHandler?.Invoke(this, new EventArgs());

                    }
                }
            }

            
        }

        private bool CutImage(string filePath, Rectangle rectangle,string fileName) {


            try
            {
                // 创建新的Bitmap对象用于存储分割后的图片
                Bitmap newImage = new Bitmap(rectangle.Width, rectangle.Height);
                Image originalImage = Bitmap.FromFile(filePath);

                // 使用Graphics对象在新图片上绘制原始图片的指定部分
                using (Graphics g = Graphics.FromImage(newImage))
                {
                    g.DrawImage(originalImage, new Rectangle(0, 0, rectangle.Width, rectangle.Height),
                        new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height), GraphicsUnit.Pixel);
                }
                newImage.Save(fileName, ImageFormat.Png);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("保存失败，保存文件被占用");
            }
            return false;                  

          

        }
        private void textChanged(object sender, EventArgs e)
        {

            try
            {

                string txt = ((TextBox)sender).Text;
                int number = 0;
                if (int.TryParse(txt,out number)) {
                    if (sender == this.text_x)
                    {
                        this.PaintCut.rect.X = number;
                    }
                    if (sender == this.text_y)
                    {
                        this.PaintCut.rect.Y = number;
                    }
                    if (sender == this.text_w)
                    {
                        this.PaintCut.rect.Width = number;
                    }
                    if (sender == this.text_h)
                    {
                        this.PaintCut.rect.Height = number;
                    }
                    
                }
                if (mainControl != null)
                {

                    mainControl.Invalidate();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("输入错误");
            }
            
        }
    }
}
