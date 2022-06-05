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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            
            if(txtPass.Text == txtPass2.Text)
            {

                User user = new User();
                bool verifica = user.CreateUser(txtName.Text, txtUsername.Text, txtPass.Text);
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
                MessageBox.Show("Revise sua nova senha!");
            }

            
        }

        private void btnPass1_Click(object sender, EventArgs e)
        {   
            if(txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                btnPass1.Text = "Hide";
            }
            else
            {
                txtPass.PasswordChar = '*';
                btnPass1.Text = "Show";
            }
            
        }

        private void btnPass2_Click(object sender, EventArgs e)
        {
            if (txtPass2.PasswordChar == '*')
            {
                txtPass2.PasswordChar = '\0';
                btnPass2.Text = "Hide";
            }
            else
            {
                txtPass2.PasswordChar = '*';
                btnPass2.Text = "Show";
            }
        }
    }
}
