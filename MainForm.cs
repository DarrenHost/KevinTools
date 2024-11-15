namespace KevinTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmi_image_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm();
            imageForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tsmi_file_Click(object sender, EventArgs e)
        {

        }

        private void tsim_map_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm();
            mapForm.ShowDialog();

         


        }
    }
}
