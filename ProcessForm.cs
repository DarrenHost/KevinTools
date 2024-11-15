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
    public partial class ProcessForm : Form
    {


        public static ResultData DataResult { get; set; } = new ResultData();


        public class ResultData
        {
            public CutData CutData { get; set; } = new CutData();
            
                
        }
        public class CutData
        {
            public Rectangle Rectangle { get; set; }
            public Int32[] Table { get; set; } = [];

            public string Name { get; set; } = string.Empty;
        }

        public static int Num { get; set; }
        public ProcessForm()
        {
            InitializeComponent();
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {

            try
            {

                ProcessForm.DataResult.CutData.Name = this.text_name.Text;

                ProcessForm.DataResult.CutData.Rectangle = new Rectangle(
                    int.Parse(this.text_x.Text.ToString()),
                    int.Parse(this.text_y.Text.ToString()),
                    int.Parse(this.text_w.Text.ToString()),
                    int.Parse(this.text_h.Text.ToString())); 

                ProcessForm.DataResult.CutData.Table = [((int)this.num_count.Value), ((int)this.num_rows.Value) ];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            this.DialogResult = DialogResult.Continue;
            this.Close();
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {

            Rectangle rect = ProcessForm.DataResult.CutData.Rectangle;
            int[] table = ProcessForm.DataResult.CutData.Table;

            this.text_name.Text = ProcessForm.DataResult.CutData.Name;

            this.text_x.Text = rect.X.ToString();
            this.text_y.Text = rect.Y.ToString();
            this.text_w.Text = rect.Width.ToString();
            this.text_h.Text = rect.Height.ToString();


            if(table!=null && table.Length > 1)
            {
                this.num_count.Value = table[0];
                this.num_rows.Value = table[1];
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
