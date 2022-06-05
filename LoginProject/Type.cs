using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginProject
{
    class Type
    {

        public Type()
        {
            
        }
        Conexao conn = new Conexao();
        MySqlCommand cmd = new MySqlCommand(); 

        public String Message = "";
        public MySqlDataReader leitura;

        public bool CreateType(string name)
        {
            cmd.CommandText = "INSERT INTO `pokemon`.`types` (`type`) VALUES (@name);";
            cmd.Parameters.AddWithValue("@name", name);

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
                this.Message = "Error! " + ex;
                return false;
            }

        }

        public bool UpdateType(int id, string name)
        {
            cmd.CommandText = "UPDATE pokemon.types SET type = @name where idType = @id ;";
            cmd.Parameters.AddWithValue("@name", name);
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
                return false;
            }

        }

        public Type(String nome)
        {
            cmd.CommandText = "SELECT * FROM pokemon.types WHERE type like '%" + nome + "%';";

            try
            {
                cmd.Connection = conn.connect();
                leitura = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                this.Message = "Error" + ex;
            }

        }

        public Type(int id)
        {
            cmd.CommandText = "DELETE FROM pokemon.types WHERE idType = @id ;";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conn.connect();
                leitura = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                this.Message = "Errado!" + ex;
            }

        }

    }
}
