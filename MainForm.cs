namespace KevinTools
{
    public partial class MainForm : Form
    {


        MapForm mapForm = new MapForm();
        ImageForm imageForm = new ImageForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmi_image_Click(object sender, EventArgs e)
        {
            imageForm.Show();
            imageForm.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tsmi_file_Click(object sender, EventArgs e)
        {

        }

        private void tsim_map_Click(object sender, EventArgs e)
        {
             mapForm.Show();
             mapForm.BringToFront();
        }
    }
}
