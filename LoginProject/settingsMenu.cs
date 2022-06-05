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
        public settingsMenu(string username)
        {
            InitializeComponent();

            name = username;

            lblHello.Text = "Hello " + name + "!";
        }
        private void btnChangePW_Click(object sender, EventArgs e)
        {
            changePW change = new changePW(name);
            change.Show();
        }

        private void btnDesloga_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Log Out", MessageBoxButtons.YesNo))
            {
                //Environment.Exit(1);
            }
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
