using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginProject
{
    public partial class PwRecovery : Form
    {
        public PwRecovery()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }        

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            User user = new User();
            MySqlDataReader leitura = user.getUser(txtUsername.Text);

            if (leitura.Read())
            {
                Hash pass = new Hash();
                string newpass = pass.CriptografarSenha(txtNewPass1.Text);

                bool verifica = user.changePassword(txtUsername.Text, newpass);

                if (verifica)
                {
                    txtUsername.Clear();
                    txtNewPass1.Clear();
                    txtNewPass2.Clear();
                    MessageBox.Show(user.Message);
                    this.Hide();
                    Login form1 = new Login();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show(user.Message);
                }
            }
            else
            {
                MessageBox.Show("User doesn't exists!");
            }
        }

        private void picPass1_Click(object sender, EventArgs e)
        {
            if (txtNewPass1.PasswordChar == '*')
            {
                txtNewPass1.PasswordChar = '\0';
                picPass1.Image = Properties.Resources.view;
            }
            else
            {
                txtNewPass1.PasswordChar = '*';
                picPass1.Image = Properties.Resources.hide;
            }
        }

        private void picPass2_Click_1(object sender, EventArgs e)
        {
            if (txtNewPass2.PasswordChar == '*')
            {
                txtNewPass2.PasswordChar = '\0';
                picPass2.Image = Properties.Resources.view;
            }
            else
            {
                txtNewPass2.PasswordChar = '*';
                picPass2.Image = Properties.Resources.hide;
            }
        }
    }
}
