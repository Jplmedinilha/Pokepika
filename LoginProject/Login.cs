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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private static string username;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            MySqlDataReader leitura = user.getUser(txtUser.Text);

            if(leitura.Read())
            {
                Hash hash = new Hash();
                if (hash.VerificarSenha(txtPass.Text, leitura.GetString(0)))
                {
                    username = txtUser.Text;
                    int isAdm = 0;

                    if (user.isAdm(txtUser.Text))
                    {
                        isAdm = 1; //user adm
                    }

                    this.Hide();
                    Campo form1 = new Campo(txtUser.Text, isAdm);
                    //admMenu form1 = new admMenu(txtUser.Text);
                    form1.Show();
                 

                }
                else MessageBox.Show("Wrong Password!");
            }
            else
            {
                MessageBox.Show("User doesn't exists! Create a new one");
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            newUser form1 = new newUser();
            form1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPass2_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                btnPass.Text = "Hide";
            }
            else
            {
                txtPass.PasswordChar = '*';
                btnPass.Text = "Show";
            }
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            PwRecovery recovery = new PwRecovery();
            recovery.Show();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnLogin_Click(this, new EventArgs());

            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnLogin_Click(this, new EventArgs());

            }
        }

        public static string getUsername()
        {
            return username;
        }
    }
}
