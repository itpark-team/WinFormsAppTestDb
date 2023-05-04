using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppTestDb.Db;
using WinFormsAppTestDb.Db.Entities;
using WinFormsAppTestDb.Forms;

namespace WinFormsAppTestDb.Contoller
{
    internal class FormMainController
    {
        private FormMain _formMain;
        private DbManager _dbManager;

        public FormMainController(FormMain formMain)
        {
            _formMain = formMain;
            _dbManager = DbManager.Instance;
        }

        public void PrintWorkerkToDataGridViewWorkers()
        {
            DataGridView dataGridView = (DataGridView)_formMain.Controls["dataGridViewWorkers"];

            dataGridView.DataSource = null;
            dataGridView.DataSource = _dbManager.TableWorkers.SelectAllWorkers();

            dataGridView.Columns["Id"].HeaderText = "ИД";
            dataGridView.Columns["Name"].HeaderText = "Имя";
            dataGridView.Columns["Experience"].HeaderText = "Опыт";
        }

        public void DeleteWorkerFromDataGridViewWorkers()
        {
            DataGridView dataGridView = (DataGridView)_formMain.Controls["dataGridViewWorkers"];

            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            Worker worker = (Worker)dataGridView.CurrentRow.DataBoundItem;

            _dbManager.TableWorkers.DeleteWorkerById(worker.Id);
        }

        public void AddNewWorker()
        {
            TextBox textBoxWorkerName = (TextBox)_formMain.Controls["textBoxWorkerName"];
            TextBox textBoxWokerExperience = (TextBox)_formMain.Controls["textBoxWokerExperience"];

            Worker worker = new Worker()
            {
                Id = 0,
                Name = textBoxWorkerName.Text,
                Experience = int.Parse(textBoxWokerExperience.Text)
            };

            _dbManager.TableWorkers.InsertNewWorker(worker);
        }

        public void FillUpdateWorkerFields()
        {
            TextBox textBoxWorkerUpdateId = (TextBox)_formMain.Controls["textBoxWorkerUpdateId"];
            TextBox textBoxWorkerUpdateName = (TextBox)_formMain.Controls["textBoxWorkerUpdateName"];
            TextBox textBoxWorkerExperience = (TextBox)_formMain.Controls["textBoxWorkerExperience"];

            DataGridView dataGridView = (DataGridView)_formMain.Controls["dataGridViewWorkers"];

            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            Worker worker = (Worker)dataGridView.CurrentRow.DataBoundItem;

            textBoxWorkerUpdateId.Text = worker.Id.ToString();
            textBoxWorkerUpdateName.Text = worker.Name;
            textBoxWorkerExperience.Text = worker.Experience.ToString();
        }

        public void UpdateWorker()
        {
            TextBox textBoxWorkerUpdateId = (TextBox)_formMain.Controls["textBoxWorkerUpdateId"];
            TextBox textBoxWorkerUpdateName = (TextBox)_formMain.Controls["textBoxWorkerUpdateName"];
            TextBox textBoxWorkerExperience = (TextBox)_formMain.Controls["textBoxWorkerExperience"];

            Worker worker = new Worker()
            {
                Id = 0,
                Name = textBoxWorkerUpdateName.Text,
                Experience = int.Parse(textBoxWorkerExperience.Text)
            };

            int id  = int.Parse(textBoxWorkerUpdateId.Text);

            _dbManager.TableWorkers.UpdateWorkerById(worker, id);
        }
    }
}
