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
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPass2.Text)
            {

                User user = new User();
                bool verifica = user.CreateDefaultUser(txtName.Text, txtUsername.Text, txtPass.Text);
                if (verifica)
                {
                    txtPass.Clear();
                    txtPass2.Clear();
                    txtName.Clear();
                    txtUsername.Clear();
                    MessageBox.Show(user.Message);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(user.Message);
                }

            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picPass1_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                picPass1.Image = Properties.Resources.view;
            }
            else
            {
                txtPass.PasswordChar = '*';
                picPass1.Image = Properties.Resources.hide;
            }
        }

        private void picPass2_Click(object sender, EventArgs e)
        {
            if (txtPass2.PasswordChar == '*')
            {
                txtPass2.PasswordChar = '\0';
                picPass2.Image = Properties.Resources.view;
            }
            else
            {
                txtPass2.PasswordChar = '*';
                picPass2.Image = Properties.Resources.hide;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
