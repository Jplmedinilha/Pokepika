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
    public partial class changePW : Form
    {   
        string username;
        public changePW(string name)
        {
            InitializeComponent();

            username = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCurrPass.PasswordChar == '*')
            {
                txtCurrPass.PasswordChar = '\0';
                button2.Text = "Hide";
            }
            else
            {
                txtCurrPass.PasswordChar = '*';
                button2.Text = "Show";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPass1.PasswordChar == '*')
            {
                txtNewPass1.PasswordChar = '\0';
                button1.Text = "Hide";
            }
            else
            {
                txtNewPass1.PasswordChar = '*';
                button1.Text = "Show";
            }
        }

        private void btnPass1_Click(object sender, EventArgs e)
        {
            if (txtNewPass2.PasswordChar == '*')
            {
                txtNewPass2.PasswordChar = '\0';
                btnPass1.Text = "Hide";
            }
            else
            {
                txtNewPass2.PasswordChar = '*';
                btnPass1.Text = "Show";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            MySqlDataReader leitura = user.getUser(username);

            if (leitura.Read())
            {
                Hash hash = new Hash();
                if (hash.VerificarSenha(txtCurrPass.Text, leitura.GetString(0)))
                {
                    //curr pw correta

                    if(txtNewPass1.Text == txtNewPass2.Text)
                    {
                        Hash pass = new Hash();
                        string newpass = pass.CriptografarSenha(txtNewPass1.Text);

                        bool verifica = user.changePassword(username, newpass);

                        if (verifica)
                        {
                            txtCurrPass.Clear();
                            txtNewPass1.Clear();
                            txtNewPass2.Clear();
                            MessageBox.Show(user.Message);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(user.Message);
                        }

                    }
                    else MessageBox.Show("New Passwords does not match!");


                }
                else MessageBox.Show("Wrong Password!");
            }
            else
            {
                MessageBox.Show("User doesn't exists! Create a new one");
            }
        }
    }
}
