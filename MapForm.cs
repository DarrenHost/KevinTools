using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinTools
{
    public partial class MapForm : Form
    {


        public MapForm()
        {
            InitializeComponent();
        }

        //所有元素
        public List<SpriteData> spriteDatas = new List<SpriteData>();

        //当前选择元素
        public SpriteData? currentSpriteData = null;

        //最后一个元素
        public SpriteData? selectSpriteData = null;


        public SelectStatus selectStatus = SelectStatus.FINISH;
        public enum SelectStatus { 
            BEGIN,
            SELECT,
            FINISH
        
        }

        public class SpriteData
        {
            public Image? image;
            public string? filePath;
            public int x;
            public int y;
            public int z;  //层数
            public int r;  //旋转角度
            public int w;  //宽
            public int h;  //高
            public SpriteStatus status;
        }
        public enum SpriteStatus
        {
            ADD, FINISH, MOVIEW

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string fileName = folderBrowserDialog1.SelectedPath;
                this.textBox1.Text = fileName;

                this.btnOpen.Enabled = false;
                this.tssi_msg.Text = "正在加载素材";
                new Thread(delegate ()
                {
                    LoadImageList();
                }).Start();

            }
        }

        private void LoadImageList()
        {
            ImageList imageList = new ImageList();
            //imageList.Images.Clear();
            imageList.ImageSize = new Size(48, 48);

            DirectoryInfo dir = new DirectoryInfo(this.textBox1.Text);
            FileInfo[] files = dir.GetFiles("*.png");


            if (this.listView1.InvokeRequired)
            {

                this.listView1.Invoke(delegate ()
                {
                    this.listView1.Items.Clear();
                    this.tssi_progress.Maximum = files.Length;
                    this.listView1.LargeImageList = imageList;
                    this.listView1.BeginUpdate();
                });
            }
            //this.listView1.SmallImageList = imageList;


            int i = 0;

            foreach (FileInfo file in files)
            {
                i++;
                Image image = Image.FromFile(file.FullName);



                if (this.listView1.InvokeRequired)
                {

                    this.listView1.Invoke(delegate ()
                    {
                        imageList.Images.Add(file.FullName, image);
                        this.tssi_progress.Value = i;
                        this.listView1.Items.Add(new ListViewItem(file.Name, file.FullName));

                    });
                }


            }

            if (this.btnOpen.InvokeRequired)
            {
                this.btnOpen.BeginInvoke(delegate ()
                {
                    this.listView1.EndUpdate();
                    this.tssi_msg.Text = "素材加载完成";
                    this.listView1.Invalidate();
                    this.btnOpen.Enabled = true;
                });
            }



        }

        private void MapForm_Load(object sender, EventArgs e)
        {

        }

        private void picMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 设置绘制矩形的颜色
            using (Pen pen = new Pen(Color.Red, 1))
            {
                //pen.Dispose();
            }

            this.PaintSpriteData(g);
            this.PaintCurrent(g);
            this.PaintLast(g);

        }
        private void PaintLast(Graphics g)
        {

            if (this.selectSpriteData != null)
            {
                SpriteData sd = selectSpriteData;
                Rectangle rect = new Rectangle(sd.x + 2, sd.y + 2, sd.w - 4, sd.h - 4);
                Random rd = new Random();

                using (Pen pen = new Pen(Color.FromArgb(255, rd.Next(255), rd.Next(255), rd.Next(255)), 1))
                {
                    g.DrawRectangle(pen, rect);
                }
            }


        }
        private void PaintCurrent(Graphics g)
        {
            SpriteData? sd = currentSpriteData;
            if (sd != null && sd.image != null)
            {
                g.DrawImage(sd.image,
                    sd.x, sd.y,
                    sd.w, sd.h);

            }
        }
        private void PaintSpriteData(Graphics g)
        {
            foreach (var item in this.spriteDatas)
            {
                if (item.image != null)
                {
                    g.DrawImage(item.image, item.x, item.y, item.w, item.h);
                }
            }

        }

        private void picMain_MouseMove(object sender, MouseEventArgs e)
        {
            SpriteData? sd = currentSpriteData;
            if (sd != null && sd.image != null)
            {
                this.tssl_xy.Text = string.Format("{0},{1}", sd.x, sd.y);

                sd.x = e.X - sd.w / 2;
                sd.y = e.Y - sd.h / 2;

                if (e.Button == MouseButtons.Left)
                {

                    SpriteData newData = new SpriteData();
                    newData.image = sd.image;
                    newData.x = e.X - sd.w / 2; ;
                    newData.y = e.Y - sd.h / 2; ;
                    newData.w = sd.w;
                    newData.h = sd.h;

                    this.FinshAddSprite(newData);

                }
            }
            if (SelectStatus.BEGIN == selectStatus) {

                foreach (SpriteData sprite in spriteDatas) {
                    Rectangle rect=  new Rectangle(sprite.x, sprite.y, sprite.w, sprite.h);
                    if(rect.Contains(e.X, e.Y)){
                        SelectSprite(sprite);
                    }
                }
            
            }


            this.picMain.Invalidate();


        }

        private SpriteData CloneSprite(SpriteData sprite)
        {
            SpriteData newData = new SpriteData();
            newData.image = sprite.image;
            newData.x = sprite.x;
            newData.y = sprite.y;
            newData.w = sprite.w;
            newData.h = sprite.h;
            return newData;
        }
        private void BeginAddSprite()
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                SpriteData spriteData = new SpriteData();
                spriteData.filePath = this.listView1.SelectedItems[0].ImageKey;
                spriteData.image = Image.FromFile(spriteData.filePath);
                spriteData.w = spriteData.image.Width;
                spriteData.h = spriteData.image.Height;
                spriteData.status = SpriteStatus.ADD;
                this.currentSpriteData = spriteData;
            }
        }

        private void FinshAddSprite(SpriteData spriteData)
        {
            this.spriteDatas.Add(spriteData);
            this.picMain.Invalidate();

            

        }
        private void RemoveSprite()
        {
            int len = this.spriteDatas.Count;
            if (len > 1)
            {
                this.selectSpriteData = null;
                this.spriteDatas.RemoveAt(len - 1);
            }

        }

        private void SelectSprite(SpriteData sprite) {
            if (sprite != null)
            {
                selectSpriteData = sprite;
                this.txt_x.Text = "" + sprite.x;
                this.txt_y.Text = "" + sprite.y;
            }
        }
        private void picMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentSpriteData != null)
            {
                if (currentSpriteData.status == SpriteStatus.ADD)
                {
                    currentSpriteData.status = SpriteStatus.FINISH;
                    this.FinshAddSprite(currentSpriteData);
                }
                this.currentSpriteData = CloneSprite(this.currentSpriteData);
            }

            if (selectStatus == SelectStatus.BEGIN) {
                if (selectSpriteData != null) {
                    selectStatus = SelectStatus.SELECT;
                }
            }
            if (selectStatus == SelectStatus.SELECT)
            {
                if (selectSpriteData != null)
                {
                    selectSpriteData = null;
                    selectStatus = SelectStatus.FINISH;
                }
            }
            this.picMain.Invalidate();
        }

        private void linkBackground_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件|*.png";
            openFileDialog.Multiselect = false;
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (DialogResult.OK == dialogResult)
            {
                this.picMain.Image = Image.FromFile(openFileDialog.FileName);
                this.txt_bgw.Text = this.picMain.Image.Width + "";
                this.txt_bgh.Text = this.picMain.Image.Height + "";

                this.linkBackground.Text = openFileDialog.FileName;
            }
        }

        private void cb_model_CheckedChanged(object sender, EventArgs e)
        {

            if (this.linkBackground.Text.EndsWith("..."))
            {
                return;
            }
            if (this.cb_model.Checked)
            {
                this.TileBackground();
            }
            else
            {
                Image srcImage = Image.FromFile(this.linkBackground.Text);
                this.picMain.Image = srcImage;
                this.picMain.Invalidate();
            }
        }

        private void TileBackground()
        {
            Image srcImage = Image.FromFile(this.linkBackground.Text);
            Image desImage = new Bitmap(this.picMain.Width, this.picMain.Height);
            decimal w = this.picMain.Width / srcImage.Width;
            decimal h = this.picMain.Height / srcImage.Height;

            using (Graphics g = Graphics.FromImage(desImage))
            {

                int columns = (int)Math.Truncate(w);
                int rows = (int)Math.Truncate(h);

                for (int i = 0; i <= rows; i++)
                {
                    for (int j = 0; j <= columns; j++)
                    {
                        g.DrawImage(srcImage, new Point(srcImage.Width * j - 1, srcImage.Height * i - 1));
                    }

                }
            }

            this.picMain.Image = desImage;
            this.picMain.Invalidate();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            this.selectStatus = SelectStatus.FINISH;
            
            this.BeginAddSprite();
            this.picMain.Invalidate();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "图片文件|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                this.SaveMapFile(saveFileDialog.FileName);

                MessageBox.Show("文件保存成功：" + saveFileDialog.FileName);
            }
        }


        private void SaveMapFile(string fileName)
        {

            Image desImage = this.picMain.Image;

            using (Graphics g = Graphics.FromImage(desImage))
            {

                PaintSpriteData(g);
            }

            desImage.Save(fileName);
        }

        private void MapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void MapForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Control)
            {
                this.RemoveSprite();

            }
            this.picMain.Invalidate();
        }

        private void sprite_point_changed(object sender, EventArgs e)
        {
            if (sender == this.txt_x && this.selectSpriteData != null)
            {
                int result = 0;
                if (int.TryParse(this.txt_x.Text + "", out result))
                    this.selectSpriteData.x = result;
            }
            if (sender == this.txt_y && this.selectSpriteData != null)
            {
                int result = 0;
                if (int.TryParse(this.txt_y.Text + "", out result))
                    this.selectSpriteData.y = result;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.currentSpriteData = null;
            this.selectStatus = SelectStatus.BEGIN;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
