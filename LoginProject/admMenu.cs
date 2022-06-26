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

            lblHello.Text = "Welcome, " + name + "!";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePW tp = new changePW(name);
            tp.Show();
        }


        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            usersManagement users = new usersManagement(name);
            users.ShowDialog();
            this.Show();
        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pkmManagement pkm = new pkmManagement(name);
            pkm.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            usersManagement users = new usersManagement(name);
            users.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pkmManagement pkm = new pkmManagement(name);
            pkm.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            typesManagement tp = new typesManagement(name);
            tp.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            typesManagement tp = new typesManagement(name);
            tp.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
