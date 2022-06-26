using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginProject
{
    class Conexao
    {
        MySqlConnection con = new MySqlConnection();

        string server = "localhost";
        string database = "pokemon";
        string user = "root";
        string pass = "Allahuakbar2016!";
        string port = "3306";
        public Conexao()
        {
            con.ConnectionString = "server=" + server + "; database=" + database + "; " +
                "user id=" + user + "; password =" + pass + "; port =" + port + ";";
        }

        public MySqlConnection connect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;

    
        }
        public void disconnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }


        }
    }
}
