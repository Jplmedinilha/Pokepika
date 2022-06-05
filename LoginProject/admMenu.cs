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
    public partial class admMenu : Form
    {
        string name;
        public admMenu(string username)
        {
            InitializeComponent();

            name = username;

            lblHello.Text = "Hello " + name + "!";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            usersManagement users = new usersManagement(name);
            users.Show();
        }

        private void btnPokemons_Click(object sender, EventArgs e)
        {
            this.Hide();
            pkmManagement pkm = new pkmManagement(name);
            pkm.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            typesManagement tp = new typesManagement(name);
            tp.Show();
        }


        private void btnChangePW_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePW tp = new changePW(name);
            tp.Show();
        }
    }
}
