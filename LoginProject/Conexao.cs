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

        string server = "pokepika.c3qampssxtve.us-east-1.rds.amazonaws.com";
        string database = "pokemon";
        string user = "ifspadm";
        string pass = "Jplm12345!";
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
