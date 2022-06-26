using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginProject
{
    public class User
    {
        public User()
        {
            //Construtora - Instancia primaria da classe
        }
        Conexao conn = new Conexao();
        MySqlCommand cmd = new MySqlCommand(); //Variavel para chamar o comando mysql

        public String Message = ""; //retorna mensagem (Iremos usar por enquanto)
        public MySqlDataReader leitura; //variavel tipo MSDATAREADER

        public bool CreateUser(string name, string username, string password, string isAdm, int balance)
        {
            Hash hash = new Hash();
            string newpass = hash.CriptografarSenha(password);

            cmd.CommandText = "INSERT INTO `pokemon`.`user` (`name`, `username`, `password`, `isAdm`, `balance`) " +
                "VALUES (@name, @username, @password, @isAdm, @balance);";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", newpass);
            cmd.Parameters.AddWithValue("@isAdm", isAdm);
            cmd.Parameters.AddWithValue("@balance", balance);

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                this.Message = "Create success";
                return true;
            }
            catch (Exception ex)
            {
                Message = "This user already exists!";
                return false;
            }
            
        }


        public bool CreateDefaultUser(string name, string username, string password)
        {
            Hash hash = new Hash();
            string newpass = hash.CriptografarSenha(password);

            cmd.CommandText = "INSERT INTO `pokemon`.`user` (`name`, `username`, `password`) " +
                "VALUES (@name, @username, @password);";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", newpass);
          

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                this.Message = "Create success";
                return true;
            }
            catch (Exception ex)
            {
                Message = "This user already exists!";
                return false;
            }

        }

        public bool UpdateUser(int id, string name, string username, string isAdm, int balance)
        {
            cmd.CommandText = "UPDATE pokemon.user SET name = @name, username = @username, isAdm = @isAdm, balance = @balance where idUser = @id ;";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@isAdm", isAdm);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                this.Message = "CERTO!";
                return true;
            }
            catch (Exception ex)
            {
                this.Message = "Errado!" + ex;
                MessageBox.Show("Error: " + ex);
                return false;
            }

        }

        public bool changePassword(string username, string newPass)
        {
            cmd.CommandText = "UPDATE pokemon.user SET password = @newPass where username = @username;";
            cmd.Parameters.AddWithValue("@newPass", newPass);
            cmd.Parameters.AddWithValue("@username", username);

            try
            {
                conn.disconnect();
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                this.Message = "CERTO!";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }

        }

        public bool isAdm(string username)
        {
            cmd.CommandText = "SELECT * FROM pokemon.user WHERE username = '" + username + "' AND isAdm = 'Y' ";

            try
            {
                conn.disconnect();
                cmd.Connection = conn.connect();
                leitura = cmd.ExecuteReader();

                if (leitura.HasRows)
                {
                    return true; //user adm
                }
                else
                {
                    return false; //user normal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return false; //deu ruim
            }

        }

        public User(String nome)
        {
            cmd.CommandText = "SELECT * FROM pokemon.user WHERE name like '%" + nome + "%';";

            try
            {
                cmd.Connection = conn.connect();
                leitura = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        public User(int id)
        {
            cmd.CommandText = "CALL deleteUser(@id);";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conn.connect();
                leitura = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        public MySqlDataReader getUser(string username)
        {
            cmd.CommandText = "SELECT password FROM user WHERE username ='" +
                              username + "';";

            try
            {
                cmd.Connection = conn.connect();
                leitura = cmd.ExecuteReader();
                return leitura;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return leitura;
            }
        }

        public int getBalance(string username)
        {
            cmd.CommandText = $"SELECT * FROM pokemon.user WHERE username = '{username}' ";
            int balance;
            conn.disconnect();
            cmd.Connection = conn.connect();
            leitura = cmd.ExecuteReader();
            if (leitura.Read()) balance = (int)leitura["balance"];
            else balance = 0;


            return balance;
        }

        public bool updateBalance(string username, int price)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "CALL updateBalance(@price, @username);";

            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@username", username);
            

            try
            {
                conn.disconnect();
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
                this.Message = "CERTO!";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }
        }

    }
}
