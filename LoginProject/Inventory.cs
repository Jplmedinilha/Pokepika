using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    internal class Inventory
    {
        Conexao conn = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public MySqlDataReader leitura; 
        public bool addInventory(string username, int numPokemon)
        {
            conn.disconnect();
            cmd.CommandText = "INSERT INTO `pokemon`.`userpokemon` (`idUser`, `numPokemon`) VALUES (" +
                "(SELECT idUser FROM pokemon.user WHERE username = @username), @numPokemon);";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@numPokemon", numPokemon);

            try
            {
                cmd.Connection = conn.connect();
                cmd.ExecuteNonQuery();
                conn.disconnect();
 
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("erro add" + ex);
                return false;
            }

            
        }

        public bool exists(int idPokemon, string username)
        {
            cmd.CommandText = $"SELECT * FROM pokemon.userpokemon WHERE numPokemon = '{idPokemon}'" +
                $"AND idUser = (SELECT idUser FROM pokemon.user WHERE username = '{username}');";

            try
            {
                conn.disconnect();
                cmd.Connection = conn.connect();
                leitura = cmd.ExecuteReader();

                return leitura.HasRows;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro exits" + ex);
                return false; 
            }
        }


    }
}
