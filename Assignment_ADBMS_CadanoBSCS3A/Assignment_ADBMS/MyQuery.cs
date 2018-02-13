using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace Assignment_ADBMS
{
    class MyQuery
    {
        public MyQuery() { }

        //public static MySqlConnection _MySqlConnection;
        //public static MySqlCommand _MySqlCommand;
        //public static MySqlDataReader _MySqlDataReader;

        public void OpenConnection()
        {
            try
            {
                MyConnection._MySqlConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ViewData(String Column, String TableName, String Criteria, bool Select)//, String ConditionStatement)
        {
            String query = "SELECT " + Column + " FROM " + TableName + " " + Criteria;
            //OpenConnection();
            MyConnection._MySqlCommand = new MySqlCommand(query, MyConnection._MySqlConnection);
            MyConnection._MySqlDataReader = MyConnection._MySqlCommand.ExecuteReader();

            //if (Select == true)
            //{
            //    while (_MySqlDataReader.Read())
            //    {
            //        //ConditionStatement = "";
            //    }
            //    _MySqlDataReader.Close();
            //}
            //else
            //{
            //    if (_MySqlDataReader.HasRows)
            //    {
            //        //ConditionStatement = "";
            //    }
            //    _MySqlDataReader.Close();
            //}
        }

        public void InsertData(String TableName, String Value, String Criteria)
        {
            String query = "INSERT INTO " + TableName + " VALUES (" + Value + ") " + Criteria;
            MyConnection._MySqlCommand = new MySqlCommand(query, MyConnection._MySqlConnection);
            MyConnection._MySqlCommand.ExecuteNonQuery();
        }

        public void UpdateData(String TableName, String Value, String Criteria)
        {
            String query = "UPDATE " + TableName + " VALUES (" + Value + ") " + Criteria;
            MyConnection._MySqlCommand = new MySqlCommand(query, MyConnection._MySqlConnection);
            MyConnection._MySqlCommand.ExecuteNonQuery();
        }

        public void DeleteData(String TableName, String Criteria)
        {

        }
    }
}
