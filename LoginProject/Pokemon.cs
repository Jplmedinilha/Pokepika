using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginProject
{
    public class Pokemon
    {
        public Pokemon()
        {
            
        }
        Conexao conn = new Conexao();
        MySqlCommand cmd = new MySqlCommand(); 

        public String Message = ""; 
        public MySqlDataReader leitura;
        public MySqlDataReader combobox; 

        public bool createPkm(string name, int num, string type, int attack, int hp, int price, 
            string hasEvolution, int gym, byte[] pic)
        {

            cmd.CommandText = "INSERT INTO `pokemon`.`pokemons`" +
                                "(`numPokemon`, `name`, `type`, `attack`, `hp`, `price`, `hasEvolution`, `gym`, `picture`) " +
                                    "VALUES (@num, @name, @type, @attack, @hp, @price, @hasEvolution, @gym, @pic);";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@attack", attack);
            cmd.Parameters.AddWithValue("@hp", hp);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@hasEvolution", hasEvolution);
            cmd.Parameters.AddWithValue("@gym", gym);
            cmd.Parameters.AddWithValue("@pic", pic);

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

        public bool updatePkm(int id, string name, string type, int attack, int hp, int price, 
            string hasEvolution, int gym, byte[] pic)
        {
            cmd.CommandText = "UPDATE pokemon.pokemons SET name = @name, type = @type, attack = @attack, hp = @hp, " +
                "price = @price, hasEvolution = @hasEvolution, gym = @gym, picture = @pic WHERE numPokemon = @id ;";

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@attack", attack);
            cmd.Parameters.AddWithValue("@hp", hp);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@hasEvolution", hasEvolution);
            cmd.Parameters.AddWithValue("@gym", gym);
            cmd.Parameters.AddWithValue("@pic", pic);
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

        public bool updatePkmWithoutPic(int id, string name, string type, int attack, int hp, int price,
            string hasEvolution, int gym)
        {
            cmd.CommandText = "UPDATE pokemon.pokemons SET name = @name, type = @type, attack = @attack, hp = @hp, " +
                "price = @price, hasEvolution = @hasEvolution, gym = @gym WHERE numPokemon = @id ;";

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@attack", attack);
            cmd.Parameters.AddWithValue("@hp", hp);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@hasEvolution", hasEvolution);
            cmd.Parameters.AddWithValue("@gym", gym);
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

        public void getTypes()
        {
            cmd.CommandText = "SELECT type FROM pokemon.types";

            try
            {
                cmd.Connection = conn.connect();
                combobox = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                this.Message = "Error" + ex;
            }

        }

        public Pokemon(String nome)
        {
            cmd.CommandText = "SELECT * FROM pokemon.pokemons WHERE name like '%" + nome + "%';";

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

        public Pokemon(int id)
        {
            cmd.CommandText = "CALL deletePokemon(@id);";
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
        
        public MemoryStream GetImage(int id)
        {
            MemoryStream ms;
           
            cmd.CommandText = $"Select * from pokemon.pokemons where numPokemon = {id}";
            cmd.Connection = conn.connect();
            leitura = cmd.ExecuteReader();
            if (leitura.Read())
            {
                byte[] img = (byte[])leitura["picture"];
                 ms = new MemoryStream(img);
            } else
            {
                ms = null;
            }

            return ms;

        }

    }
}
