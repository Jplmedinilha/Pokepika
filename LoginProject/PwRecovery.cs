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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPass1.PasswordChar == '*')
            {
                txtNewPass1.PasswordChar = '\0';
                btnPw1.Text = "Hide";
            }
            else
            {
                txtNewPass1.PasswordChar = '*';
                btnPw1.Text = "Show";
            }
        }

        private void btnPass1_Click(object sender, EventArgs e)
        {
            if (txtNewPass2.PasswordChar == '*')
            {
                txtNewPass2.PasswordChar = '\0';
                btnPw2.Text = "Hide";
            }
            else
            {
                txtNewPass2.PasswordChar = '*';
                btnPw2.Text = "Show";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
    }
}
