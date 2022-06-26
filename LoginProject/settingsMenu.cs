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
    public partial class settingsMenu : Form
    {
        string name;
        public bool Logoff { get; set; }
        public settingsMenu(string username)
        {
            InitializeComponent();
            Logoff = false;
            name = username;

           
        }
        private void btnChangePW_Click(object sender, EventArgs e)
        {
            changePW change = new changePW(name);
            change.Show();
        }

      
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            changePW change = new changePW(name);
            change.ShowDialog();
            Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingsMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Logoff?", "Log Out", MessageBoxButtons.YesNo))
            {
                Logoff = true;
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Logoff?", "Log Out", MessageBoxButtons.YesNo))
            {
                Logoff = true;
                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Hide();
            changePW change = new changePW(name);
            change.ShowDialog();
            Show();
        }
    }
}
