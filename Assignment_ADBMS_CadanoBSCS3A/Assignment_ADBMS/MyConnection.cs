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
    class MyConnection
    {
        public MyConnection() { }

        public static MySqlConnection _MySqlConnection;
        public static MySqlCommand _MySqlCommand;
        public static MySqlDataReader _MySqlDataReader;

        public static String Connection = @".../Connection.ini";

        public static void MyDatabaseConnection(Form CurrentForm)
        {
            if (File.Exists(Connection))
            {
                String[] _Connection = File.ReadAllLines(Connection);
                if (_Connection.Length > 0)
                {
                    try
                    {
                        _MySqlConnection = new MySqlConnection(_Connection[0] + "; " +
                                                              _Connection[1] + "; " +
                                                              _Connection[2] + "; " +
                                                              _Connection[3] + "; " +
                                                              _Connection[4]);
                        _MySqlConnection.Open();
                        MessageBox.Show("The Connection is now open.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Walang Connection Jhow");
                    }
                }
            }
        }     
    }
}
