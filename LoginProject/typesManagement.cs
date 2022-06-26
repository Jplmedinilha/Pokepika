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
    public partial class typesManagement : Form
    {
        string username;
        int id;
        public typesManagement(string name)
        {
            InitializeComponent();

            username = name;

            listType.View = View.Details; //EXIBE OS DETALHES
            listType.LabelEdit = true;
            listType.AllowColumnReorder = true;
            listType.FullRowSelect = true;
            listType.GridLines = true;
            listType.Sorting = SortOrder.Ascending;

            listType.Columns.Add("ID", 60, HorizontalAlignment.Left);
            listType.Columns.Add("Type", 100, HorizontalAlignment.Left);

            getType();
        }

       
        public void getType()
        {
            listType.Items.Clear();
            Type type = new Type(txtSearch.Text);
            while (type.leitura.Read())
            {
                string[] row =
                {
                    type.leitura.GetString(0),
                    type.leitura.GetString(1)
                };

                var rowView = new ListViewItem(row);
                listType.Items.Add(rowView);
            }
        }

        public void limpar()
        {
            txtName.Clear();
            btnSalvar.Text = "Create";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            limpar();
            btnSalvar.Text = "Create";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admMenu Menu = new admMenu(username);
            Menu.Show();
        }

        private void typesManagement_Load(object sender, EventArgs e)
        {

        }

        private void listType_Click(object sender, EventArgs e)
        {
            id = int.Parse(listType.SelectedItems[0].SubItems[0].Text);
            string type = listType.SelectedItems[0].SubItems[1].Text;


            txtName.Text = type;

            btnSalvar.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo))
            {
                Type type = new Type(id);
                limpar();
                getType();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Create")
            {
                Type type = new Type();
                if (txtName.Text == "")
                    MessageBox.Show("Insira as informações corretamente");
                else
                {
                    bool verifica = type.CreateType(txtName.Text);
                    if (verifica)
                    {
                        txtName.Clear();
                        getType();
                        MessageBox.Show(type.Message);
                    }
                    else
                    {
                        MessageBox.Show(type.Message);
                    }
                }
            }
            else
            {
                Type type = new Type();
                if (txtName.Text == "")
                    MessageBox.Show("Insira as informações corretamente");
                else
                {
                    bool verifica = type.UpdateType(id, txtName.Text);
                    if (verifica)
                    {
                        txtName.Clear();
                        getType();
                        MessageBox.Show(type.Message);
                    }
                    else
                    {
                        MessageBox.Show(type.Message);
                    }
                }
            }

        }

     

        private void rjButton2_Click(object sender, EventArgs e)
        {
            limpar();
            btnSalvar.Text = "Create";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            getType();
        }
    }
}
