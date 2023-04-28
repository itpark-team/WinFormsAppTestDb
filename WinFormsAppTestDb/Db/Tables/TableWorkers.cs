using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppTestDb.Db.Entities;

namespace WinFormsAppTestDb.Db.Tables
{
    internal class TableWorkers
    {
        public NpgsqlConnection _connection;

        public TableWorkers(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public List<Worker> SelectAllWorkers()
        {
            List<Worker> workers = new List<Worker>();

            string sqlRequest = "SELECT * FROM workers ORDER BY id ASC";
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                string name = dataReader.GetString(dataReader.GetOrdinal("name"));
                int experience = dataReader.GetInt32(dataReader.GetOrdinal("experience"));

                workers.Add(new Worker()
                {
                    Id = id,
                    Name = name,
                    Experience = experience,
                });
            }

            dataReader.Close();

            return workers;
        }
    }
}
