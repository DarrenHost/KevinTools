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
    public partial class GridForm : Form
    {
        public GridForm()
        {
            InitializeComponent();
        }

        public static DataResult ResultData { get; private set; } = new DataResult();

        public class DataResult
        {
            public Color Color = Color.DarkGray;
            public int Size = 100;
            public bool Enabled = true;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            GridForm.ResultData.Enabled = this.cb_enabled.Checked;
            GridForm.ResultData.Color = this.pic_color.BackColor;
            GridForm.ResultData.Size = ((int)this.num_size.Value);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pic_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                this.pic_color.BackColor = colorDialog1.Color;
            }

        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            this.cb_enabled.Checked = GridForm.ResultData.Enabled;
            this.pic_color.BackColor = GridForm.ResultData.Color;
            this.num_size.Value = GridForm.ResultData.Size;
        }

        private void GridForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                btn_ok.PerformClick();
            }
        }
    }
}
