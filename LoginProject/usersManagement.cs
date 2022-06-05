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
    public partial class usersManagement : Form
    {
        string username;
        public usersManagement(string name)
        {
            InitializeComponent();

            username = name;

            listUsers.View = View.Details; //EXIBE OS DETALHES
            listUsers.LabelEdit = true;
            listUsers.AllowColumnReorder = true;
            listUsers.FullRowSelect = true;
            listUsers.GridLines = true;
            listUsers.Sorting = SortOrder.Ascending;

            listUsers.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listUsers.Columns.Add("Name", 90, HorizontalAlignment.Left);
            listUsers.Columns.Add("Username", 80, HorizontalAlignment.Left);
            listUsers.Columns.Add("ADM", 50, HorizontalAlignment.Left);
            listUsers.Columns.Add("Balance", 70, HorizontalAlignment.Left);


            getUser();
        }

        int id;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            btnSave.Text = "Create";
            txtPassword.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(btnSave.Text == "Create")
            {
                User user = new User();
                if (txtName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
                    MessageBox.Show("Insira as informações corretamente");
                else
                {
                    bool verifica = user.CreateUser(txtName.Text, txtUsername.Text, txtPassword.Text);
                    if (verifica)
                    {
                        limpar();
                        getUser();
                        MessageBox.Show(user.Message);
                    }
                    else
                    {
                        MessageBox.Show(user.Message);
                    }
                }
            }
            else if(btnSave.Text == "Update")
            {

                User user = new User();
                if(txtPassword.Text != "")
                {
                    MessageBox.Show("Impossivel alterar senha");
                }
                else if (txtName.Text == "" || txtUsername.Text == "")
                    MessageBox.Show("Insira as informações corretamente");
                else
                {
                    string isAdm;
                    if (txtAdm.Text == "Yes")
                        isAdm = "Y";
                    else
                        isAdm = "N";

                    bool verifica = user.UpdateUser(id, txtName.Text, txtUsername.Text, isAdm, int.Parse(txtBalance.Text));

                    if (verifica)
                    {
                        limpar();
                        getUser();
                        MessageBox.Show(user.Message);
                    }
                    else
                    {
                        MessageBox.Show(user.Message);
                    }
                }

            }

        }
        public void getUser()
        {
            listUsers.Items.Clear();
            User user = new User(txtSearch.Text);
            while (user.leitura.Read())
            {
                string[] row =
                {
                    user.leitura.GetString(0),
                    user.leitura.GetString(1),
                    user.leitura.GetString(2),
                    user.leitura.GetString(4),
                    user.leitura.GetString(5),

                };

                var rowView = new ListViewItem(row);
                listUsers.Items.Add(rowView);
            }
        }

        private void listUsers_Click(object sender, EventArgs e)
        {
            id = int.Parse(listUsers.SelectedItems[0].SubItems[0].Text);
            string nome = listUsers.SelectedItems[0].SubItems[1].Text;
            string username = listUsers.SelectedItems[0].SubItems[2].Text;
            string adm = listUsers.SelectedItems[0].SubItems[3].Text;
            string balance = listUsers.SelectedItems[0].SubItems[4].Text;

            txtName.Text = nome;
            txtUsername.Text = username;
            txtAdm.Text = (adm == "Y") ? "Yes" : "No";
            btnSave.Text = "Update";
            txtBalance.Text = balance;
            txtPassword.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";

            this.Hide();
            admMenu Menu = new admMenu(username);
            Menu.Show();
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void limpar()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtSearch.Clear();
            txtBalance.Clear();
            txtAdm.SelectedIndex = -1;
            btnSave.Text = "Create";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo))
            {
                User user = new User(id);
                limpar();
                getUser();
            }
        }

        private void usersManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
