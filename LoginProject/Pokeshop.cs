using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class Pokeshop : Form
    {
        User user = new User();
        public Pokeshop()
        {
            InitializeComponent();

           

            lstPokemon.View = View.Details; 
            lstPokemon.LabelEdit = true;
            lstPokemon.AllowColumnReorder = true;
            lstPokemon.FullRowSelect = true;
            lstPokemon.GridLines = true;
            lstPokemon.Sorting = SortOrder.Ascending;

            lstPokemon.Columns.Add("Num", 60, HorizontalAlignment.Left);
            lstPokemon.Columns.Add("Name", 60, HorizontalAlignment.Left);
            lstPokemon.Columns.Add("Type", 60, HorizontalAlignment.Left);
            lstPokemon.Columns.Add("Atk", 60, HorizontalAlignment.Left);
            lstPokemon.Columns.Add("HP", 60, HorizontalAlignment.Left);
            lstPokemon.Columns.Add("$$", 60, HorizontalAlignment.Left);
            lstPokemon.Columns.Add("Gym", 60, HorizontalAlignment.Left);


            updateCoins();

            getPkm();
        }
        int id = -1;
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            

            if (id != -1)
            {
                int price = int.Parse(lstPokemon.SelectedItems[0].SubItems[5].Text);
                int balance = user.getBalance(Login.getUsername());
                Inventory inv = new Inventory();

                if (balance - price < 0)
                {
                    MessageBox.Show("You don't have enough coins!");
                }
                else if (inv.exists(id, Login.getUsername()))
                {
                    MessageBox.Show("You already have this Pokemon");
                }
                else
                {
                    if (inv.addInventory(Login.getUsername(), int.Parse(lstPokemon.SelectedItems[0].SubItems[0].Text)))
                    {
                        if (user.updateBalance(Login.getUsername(), price))
                        {
                            MessageBox.Show($"Congrats! You've bought {lblName.Text}");
                            updateCoins();
                        }
                    }
                }

            } else
            {
                MessageBox.Show("selecione um");
            }
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {

            id = int.Parse(lstPokemon.SelectedItems[0].SubItems[0].Text);
            string name = lstPokemon.SelectedItems[0].SubItems[1].Text;
            string type = lstPokemon.SelectedItems[0].SubItems[2].Text;
            string attack = lstPokemon.SelectedItems[0].SubItems[3].Text;
            string HP = lstPokemon.SelectedItems[0].SubItems[4].Text;
            string price = lstPokemon.SelectedItems[0].SubItems[5].Text;
            

            Pokemon pokemon = new Pokemon();

            lblName.Text = name;
            lblAtttack.Text = attack;
            lblHp.Text = HP;
            lblPrice.Text = price;
            lblType.Text = type;
            picPokemon.Image = Image.FromStream(pokemon.GetImage(id));

        }

        public void getPkm()
        {
            lstPokemon.Items.Clear();
            Pokemon pkm = new Pokemon(txtSearch.Text);
            while (pkm.leitura.Read())
            {
                string[] row =
                {
                    pkm.leitura.GetString(0),
                    pkm.leitura.GetString(1),
                    pkm.leitura.GetString(2),
                    pkm.leitura.GetString(3),
                    pkm.leitura.GetString(4),
                    pkm.leitura.GetString(5),
                    pkm.leitura.GetString(7),
                };

                var rowView = new ListViewItem(row);
                lstPokemon.Items.Add(rowView);
            }
        }

        public void updateCoins()
        {
            lblBalance.Text = user.getBalance(Login.getUsername()).ToString();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            getPkm();
        }

    }
}
