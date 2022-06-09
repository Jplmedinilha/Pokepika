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
using System.IO;


namespace LoginProject
{
    public partial class pkmManagement : Form
    {
        string username;
        public pkmManagement(string name)
        {
            InitializeComponent();

            username = name;

            listPkm.View = View.Details; //EXIBE OS DETALHES
            listPkm.LabelEdit = true;
            listPkm.AllowColumnReorder = true;
            listPkm.FullRowSelect = true;
            listPkm.GridLines = true;
            listPkm.Sorting = SortOrder.Ascending;

            listPkm.Columns.Add("Num", 50, HorizontalAlignment.Left);
            listPkm.Columns.Add("Name", 60, HorizontalAlignment.Left);
            listPkm.Columns.Add("Type", 60, HorizontalAlignment.Left);
            listPkm.Columns.Add("Atk", 60, HorizontalAlignment.Left);
            listPkm.Columns.Add("HP", 60, HorizontalAlignment.Left);
            listPkm.Columns.Add("$$", 60, HorizontalAlignment.Left);
            listPkm.Columns.Add("Evolution", 60, HorizontalAlignment.Left);
            listPkm.Columns.Add("Gym", 60, HorizontalAlignment.Left);

            getPkm();
        }

        int id;
        

        public void getPkm()
        {
            listPkm.Items.Clear();
            Pokemon pkm = new Pokemon(txtSearch.Text);
            while (pkm.leitura.Read())
            {
                string[] row =
                {
                    pkm.leitura.GetString(0),
                    pkm.leitura.GetString(1),
                    pkm.leitura.GetString(2),
                    pkm.leitura.GetString(3),
                    pkm.leitura.GetString(4),
                    pkm.leitura.GetString(5),
                    pkm.leitura.GetString(6),
                    pkm.leitura.GetString(7),
                };

                var rowView = new ListViewItem(row);
                listPkm.Items.Add(rowView);
            }
        }

        private void pkmManagement_Load(object sender, EventArgs e)
        {
            try
            {
                cbbType.Items.Clear();
                Pokemon pkm = new Pokemon();
                pkm.getTypes();

                while (pkm.combobox.Read())
                {
                    cbbType.Items.Add(pkm.combobox.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void listPkm_Click(object sender, EventArgs e)
        {
            id = int.Parse(listPkm.SelectedItems[0].SubItems[0].Text);
            string nome = listPkm.SelectedItems[0].SubItems[1].Text;
            string type = listPkm.SelectedItems[0].SubItems[2].Text;
            string attack = listPkm.SelectedItems[0].SubItems[3].Text;
            string HP = listPkm.SelectedItems[0].SubItems[4].Text;
            string price = listPkm.SelectedItems[0].SubItems[5].Text;
            string evo = listPkm.SelectedItems[0].SubItems[6].Text;
            string gym = listPkm.SelectedItems[0].SubItems[7].Text;
            

            Pokemon pokemon = new Pokemon();
            txtName.Text = nome;
            cbbType.Text = type;
            txtAttack.Text = attack;
            txtHP.Text = HP;
            txtPrice.Text = price;
            txtEvolution.Text = (evo == "Y") ? "Yes" : "No";
            txtGym.Text = gym;
            txtNum.Text = id + "";
            picPokemon.Image = Image.FromStream(pokemon.GetImage(id));

            txtNum.ReadOnly = true;

            btnSave.Text = "Update";
        }

        private void limpar()
        {
            txtName.Clear();
            txtAttack.Clear();
            txtHP.Clear();
            txtNum.Clear();
            txtPrice.Clear();
            cbbType.SelectedIndex = -1;
            txtGym.SelectedIndex = -1;
            txtEvolution.SelectedIndex = -1;
            txtSearch.Clear();
            btnSave.Text = "Create";
            picPokemon.Image = null;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnPurchase_Click(object sender, EventArgs e) // real
        {
            this.Hide();
            admMenu Menu = new admMenu(username);
            Menu.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e) //real
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo))
            {
                Pokemon pkm = new Pokemon(id);
                limpar();
                getPkm();
                txtNum.ReadOnly = false;


            }
        }

        private void rjButton2_Click(object sender, EventArgs e) // real
        {
            limpar();
            btnSave.Text = "Create";
            txtNum.ReadOnly = false;
        }

        private void rjButton1_Click(object sender, EventArgs e) // real
        {
            if (btnSave.Text == "Create")
            {
                Pokemon pkm = new Pokemon();
                if (txtName.Text == "" || txtNum.Text == "" || cbbType.Text == "" || txtAttack.Text == ""
                    || txtHP.Text == "" || txtPrice.Text == "" || txtEvolution.Text == "" || txtGym.Text == "" || picPokemon == null)
                    MessageBox.Show("Insira as informações corretamente");
                else
                {
                    byte[] img = null;
                    FileStream Stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    img = brs.ReadBytes((int)Stream.Length);
                    //(string name, int num, string type, int attack, int hp, int price, string hasEvolution, int gym)
                    bool verifica = pkm.createPkm(txtName.Text, int.Parse(txtNum.Text), cbbType.Text,
                        int.Parse(txtAttack.Text), int.Parse(txtHP.Text), int.Parse(txtPrice.Text),
                        (txtEvolution.Text == "Yes") ? "Y" : "N", int.Parse(txtGym.Text), img);

                    if (verifica)
                    {
                        limpar();
                        getPkm();
                        MessageBox.Show(pkm.Message);
                    }
                    else
                    {
                        MessageBox.Show(pkm.Message);
                    }


                }
            }
            else if (btnSave.Text == "Update")
            {
                bool verifica;
                Pokemon pkm = new Pokemon();
                if (txtName.Text == "" || txtNum.Text == "" || cbbType.Text == "" || txtAttack.Text == ""
                    || txtHP.Text == "" || txtPrice.Text == "" || txtEvolution.Text == "" || txtGym.Text == "")
                    MessageBox.Show("Insira as informações corretamente");
                else
                {
                    if (imageLocation == null)
                    {
                        verifica = pkm.updatePkmWithoutPic(id, txtName.Text, cbbType.Text,
                           int.Parse(txtAttack.Text), int.Parse(txtHP.Text), int.Parse(txtPrice.Text),
                           (txtEvolution.Text == "Yes") ? "Y" : "N", int.Parse(txtGym.Text));
                    } else
                    {
                        byte[] img = null;
                        FileStream Stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Stream);
                        img = brs.ReadBytes((int)Stream.Length);

                        verifica = pkm.updatePkm(id, txtName.Text, cbbType.Text,
                            int.Parse(txtAttack.Text), int.Parse(txtHP.Text), int.Parse(txtPrice.Text),
                            (txtEvolution.Text == "Yes") ? "Y" : "N", int.Parse(txtGym.Text), img);
                    }
                    
                    if (verifica)
                    {
                        limpar();
                        getPkm();
                        MessageBox.Show(pkm.Message);
                        btnSave.Text = "Create";
                        txtNum.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show(pkm.Message);
                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string imageLocation;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image (*.jpg;*.png;*.gif) |*.jpg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageLocation = ofd.FileName.ToString();
                picPokemon.ImageLocation = imageLocation;
            }
        }

        private void listPkm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
