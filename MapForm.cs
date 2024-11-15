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

        private ImageList imageList = new ImageList();
        public MapForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string fileName = folderBrowserDialog1.SelectedPath;
                this.textBox1.Text = fileName;
                imageList.Images.Clear();

                imageList.ImageSize = new Size(48, 48);

                DirectoryInfo dir = new DirectoryInfo(fileName);
                FileInfo[] files = dir.GetFiles("*.png");

                this.listView1.LargeImageList = imageList;
                this.listView1.SmallImageList = imageList;

                this.listView1.BeginUpdate();
                foreach (FileInfo file in files)
                {

                    this.imageList.Images.Add(file.FullName, Image.FromFile(file.FullName));
                    this.listView1.Items.Add(new ListViewItem(file.Name,file.FullName));
                }
                this.listView1.EndUpdate();

                

               
                foreach (FileInfo file in files)
                {
                    this.listView1.Items.Add(new ListViewItem(file.Name,file.FullName));
                }

              
            }
        }

        private void LoadImageList()
        {

            

        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            this.LoadImageList();
        }
    }
}
