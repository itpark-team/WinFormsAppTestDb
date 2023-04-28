using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppTestDb.Db;
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
    }
}
