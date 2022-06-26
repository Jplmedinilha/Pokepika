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

   

        

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picPass2_Click(object sender, EventArgs e)
        {

            if (txtNewPass1.PasswordChar == '*')
            {
                txtNewPass1.PasswordChar = '\0';
                picPass2.Image = Properties.Resources.view;
            }
            else
            {
                txtNewPass1.PasswordChar = '*';
                picPass2.Image = Properties.Resources.hide;
            }
        }

        private void picPass1_Click(object sender, EventArgs e)
        {

            if (txtCurrPass.PasswordChar == '*')
            {
                txtCurrPass.PasswordChar = '\0';
                picPass1.Image = Properties.Resources.view;
            }
            else
            {
                txtCurrPass.PasswordChar = '*';
                picPass1.Image = Properties.Resources.hide;
            }
        }

        private void picPass3_Click(object sender, EventArgs e)
        {
            if (txtNewPass2.PasswordChar == '*')
            {
                txtNewPass2.PasswordChar = '\0';
                picPass3.Image = Properties.Resources.view;
            }
            else
            {
                txtNewPass2.PasswordChar = '*';
                picPass3.Image = Properties.Resources.hide;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            User user = new User();
            MySqlDataReader leitura = user.getUser(username);

            if (leitura.Read())
            {
                Hash hash = new Hash();
                if (hash.VerificarSenha(txtCurrPass.Text, leitura.GetString(0)))
                {
                    //curr pw correta

                    if (txtNewPass1.Text == txtNewPass2.Text)
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
