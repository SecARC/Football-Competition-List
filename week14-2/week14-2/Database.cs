using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

namespace week14_2
{
    public class Database
    {
        public MySqlConnection sqlConnection { get; set; }

        public Database()
        {
            sqlConnection = new MySqlConnection("Server=localhost;Database=footballdb;Uid=gamesdba;Pwd=gamesdba123;");
        }

        public void Connect()
        {
            sqlConnection.Open();
        }

        public void Disconnect()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public MySqlCommand CreateCommand(string query)
        {
            return new MySqlCommand(query, sqlConnection);
        }

        public MySqlDataReader GetDataReader(string query)
        {
            return CreateCommand(query).ExecuteReader();
        }

        public MySqlDataReader GetDataReader(MySqlCommand sqlCommand)
        {
            return sqlCommand.ExecuteReader();
        }

        public DataTable getDataTable(string query)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, sqlConnection);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable getDataTable(MySqlCommand sqlCommand)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void addParameter(MySqlCommand sqlCommand, string parameter, object value)
        {
            if (value == null)
                sqlCommand.Parameters.AddWithValue(parameter, DBNull.Value);
            else
                sqlCommand.Parameters.AddWithValue(parameter, value);
        }
    }
}
