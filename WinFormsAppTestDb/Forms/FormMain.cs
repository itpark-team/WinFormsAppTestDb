using WinFormsAppTestDb.Contoller;

namespace WinFormsAppTestDb.Forms
{
    public partial class FormMain : Form
    {
        private FormMainController _formMainController;

        public FormMain()
        {
            InitializeComponent();

            _formMainController = new FormMainController(this);
        }

        private void buttonLoadWorkers_Click(object sender, EventArgs e)
        {
            _formMainController.PrintWorkerkToDataGridViewWorkers();
        }
    }
}