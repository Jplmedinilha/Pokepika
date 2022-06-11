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
      
        private void Form1_Load(object sender, EventArgs e)
        {

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

                rjButton2_Click(this, new EventArgs());

            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                rjButton2_Click(this, new EventArgs());

            }
        }

        public static string getUsername()
        {
            return username;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            User user = new User();
            MySqlDataReader leitura = user.getUser(txtUser.Text);

            if (leitura.Read())
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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                picPass.Image = Properties.Resources.view;
            }
            else
            {
                txtPass.PasswordChar = '*';
                picPass.Image = Properties.Resources.hide;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            newUser form1 = new newUser();
            form1.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
