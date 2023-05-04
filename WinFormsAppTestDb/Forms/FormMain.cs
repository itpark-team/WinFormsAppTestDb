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


        private void buttonDeleteSelectedWorker_Click(object sender, EventArgs e)
        {
            _formMainController.DeleteWorkerFromDataGridViewWorkers();
            _formMainController.PrintWorkerkToDataGridViewWorkers();
        }

        private void buttonAddNewWorker_Click(object sender, EventArgs e)
        {
            _formMainController.AddNewWorker();
            _formMainController.PrintWorkerkToDataGridViewWorkers();
        }

        private void dataGridViewWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _formMainController.FillUpdateWorkerFields();
        }

        private void buttonUpdateWorker_Click(object sender, EventArgs e)
        {
            _formMainController.UpdateWorker();
            _formMainController.PrintWorkerkToDataGridViewWorkers();
        }
    }
}