using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppTestDb.Db.Tables;

namespace WinFormsAppTestDb.Db
{
    internal class DbManager
    {
        private static DbManager _instance = null;

        public static DbManager Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DbManager();
                }
                return _instance;
            }
        }
        
        public TableWorkers TableWorkers { get; private set; }

        private DbManager()
        {
            DbConnection dbConnection = new DbConnection("194.67.105.79", "mcd_alex_user","12345", "mcd_alex_db");

            TableWorkers = new TableWorkers(dbConnection.Connection);
        }
    }
}
