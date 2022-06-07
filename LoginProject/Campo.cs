using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class Campo : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;

        int speed = 2;

        int isAdm;
        User user = new User();
        public Campo(string nome, int adm)
        {
            InitializeComponent();

            isAdm = adm;
            lblUsername.Text = nome;

            if (isAdm == 1)
            {
                lblUsername.ForeColor = System.Drawing.Color.Red;
                picFence.Visible = false;
                labelx.Visible = true;
                labely.Visible = true;
            }

            picCharacter.BringToFront();
            updateCoins();
            lblUser.Text = nome;

         

        }

  


        private void Campo_KeyDown(object sender, KeyEventArgs e)
        {
            picCharacter.Visible = true;
            lblUsername.Visible = true;
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    moveLeft = true;
                    speed = 20;
                }
                else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    moveRight = true;
                    speed = 20;
                }
                else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    moveUp = true;
                    speed = 20;
                }
                else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    moveDown = true;
                    speed = 20;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    moveLeft = true;
                    speed = 6;
                }
                else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    moveRight = true;
                    speed = 6;
                }
                else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    moveUp = true;
                    speed = 6;
                }
                else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    moveDown = true;
                    speed = 6;
                }
            }

            if (Control.ModifierKeys == Keys.Control)
            {

                if (e.KeyCode == Keys.D)
                {
                    picCharacter.Left = 608;
                    lblUsername.Left = 600;
                    picCharacter.Top = 300;
                    lblUsername.Top = 282;
                }

            }

            flowLayoutPanel1.Enabled = false;// gambiarra para nao bugar o boneco
        }

        private void Campo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
            flowLayoutPanel1.Enabled = true;// gambiarra para nao bugar o boneco
        }

        private void Campo_Load(object sender, EventArgs e)
        {
          
            populateItems();
            flowLayoutPanel1.Enabled = false; // gambiarra para nao bugar o boneco

        }

        private void populateItems()
        {
            List<Listitem> listItems = new List<Listitem>();

        
            Inventory inventory = new Inventory();
            inventory.getFullInventory(lblUsername.Text);

            while (inventory.leitura.Read())
            {
                Listitem lstItem = new Listitem();


                lstItem.Name = inventory.leitura.GetString(0);
                lstItem.Type = inventory.leitura.GetString(1);
              

                byte[] img = (byte[])inventory.leitura["getPokeImage(numPokemon)"];

                MemoryStream ms = new MemoryStream(img);
                lstItem.Icon = Image.FromStream(ms);

                listItems.Add(lstItem);

                if (flowLayoutPanel1.Controls.Count < 0)
                     flowLayoutPanel1.Controls.Clear();
                else
                     flowLayoutPanel1.Controls.Add(lstItem);


            }

        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft == true && leftAble())
            {
                picCharacter.Left -= speed;
                lblUsername.Left -= speed;
            }
            if (moveRight == true && rightAble())
            {
                picCharacter.Left += speed;
                lblUsername.Left += speed;
            }
            if (moveUp == true && upAble())
            {
                picCharacter.Top -= speed;
                lblUsername.Top -= speed;
            }
            if (moveDown == true && downAble())
            {
                picCharacter.Top += speed;
                lblUsername.Top += speed;
            }

            labelx.Text = "X: " + picCharacter.Left;
            labely.Text = "Y: " + picCharacter.Top;

            
            checkPosition();
        }

        private void cleanMoves()
        {
            moveDown = false;
            moveUp = false;
            moveRight = false;
            moveLeft = false;
        }

        private bool leftAble()// <---
        {
            int positionX = picCharacter.Left;
            int currPosY = picCharacter.Top;
            bool able = true;

            if(positionX - speed < 0) able = false;//borda

            if (isAdm == 0) //not manager
            {
                if (positionX < 266 + speed && positionX > 70 && currPosY < 419 && currPosY > 235) able = false;//manager
            }
            else
            {
                if (positionX < 244 + speed && positionX > 90 && currPosY < 387 && currPosY > 235) able = false; //manager
            }

            if (positionX < 648 + speed && positionX > 548 && currPosY < 125 && currPosY > 15) able = false; //gym 1

            if (positionX < 880 + speed && positionX > 736 && currPosY < 127 && currPosY > 25) able = false; //gym 2

            if (positionX < 1098 + speed && positionX > 948 && currPosY < 127 && currPosY > 3) able = false; //gym 3

            if (positionX < 1210 + speed && positionX > 1036 && currPosY < 417 && currPosY > 273) able = false; //settings

            if (positionX < 972 + speed && positionX > 846 && currPosY < 567 && currPosY > 437) able = false;//market

            return able;


        }

        public void updateCoins()
        {
            lblBalance.Text = user.getBalance(Login.getUsername()).ToString();
        }

        private void Campo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private bool rightAble()// --->
        {
            int positionX = picCharacter.Left;
            int currPosY = picCharacter.Top;
            bool able = true;

            if (positionX + speed > 1244) able = false;//borda

            if (isAdm == 0) //not manager
            {
                if (positionX > 70 - speed && positionX < 266 && currPosY < 419 && currPosY > 235) able = false;//manager area
            }
            else
            {
                if (positionX > 90 - speed && positionX < 244 && currPosY < 387 && currPosY > 235) able = false;//manager
            }

            if (positionX < 648 && positionX > 548 - speed && currPosY < 125 && currPosY > 15) able = false;//gym 1

            if (positionX < 880 && positionX > 736 - speed && currPosY < 127 && currPosY > 25) able = false;//gym 2

            if (positionX < 1089 && positionX > 948 - speed && currPosY < 127 && currPosY > 3) able = false;//gym 3

            if (positionX < 1210 && positionX > 1036 - speed && currPosY < 417 && currPosY > 273) able = false;//settings

            if (positionX < 972 && positionX > 846 - speed && currPosY < 567 && currPosY > 437) able = false;//market  

            return able;


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void Campo_Click(object sender, EventArgs e)
        {
            
          
        }

        private bool upAble()// ^^^
        {
            int positionX = picCharacter.Left;
            int currPosY = picCharacter.Top;
            bool able = true;

            if (currPosY - speed < -8) able = false; //borda

            if (isAdm == 0) //not manager
            {
                if (currPosY > 235 && currPosY < 419 + speed && positionX > 70 && positionX < 266) able = false;//manager area
            }
            else
            {
                if (currPosY > 235 && currPosY < 387 + speed && positionX > 90 && positionX < 244) able = false;//manager
            }

            if (currPosY > 15 && currPosY < 125 + speed && positionX > 548 && positionX < 648) able = false;//gym 1

            if (currPosY > 25 && currPosY < 127 + speed && positionX > 736 && positionX < 880) able = false;//gym 2

            if (currPosY > 3 && currPosY < 127 + speed && positionX > 948 && positionX < 1098) able = false;//gym 3

            if (currPosY > 273 && currPosY < 417 + speed && positionX > 1036 && positionX < 1210) able = false;//settings

            if (currPosY > 437 && currPosY < 567 + speed && positionX > 846 && positionX < 972) able = false;//market

            return able;


        }
        private bool downAble()// vvv
        {
            int positionX = picCharacter.Left;
            int currPosY = picCharacter.Top;
            bool able = true;

            if (currPosY + speed > 620) able = false; //borda

            if (isAdm == 0)
            {
                if (currPosY > 235 - speed && currPosY < 419 && positionX > 70 && positionX < 266) able = false;//manager area
            }
            else
            {
                if (currPosY > 235 - speed && currPosY < 387 && positionX > 90 && positionX < 244 - speed) able = false;
            }

            if (positionX < 648 && positionX > 548 && currPosY < 125 && currPosY > 15 - speed) able = false;//gym 1

            if (positionX < 880 && positionX > 736 && currPosY < 127 && currPosY > 25 - speed) able = false;//gym 2

            if (positionX < 1089 && positionX > 948 && currPosY < 127 && currPosY > 3 - speed) able = false;//gym 3

            if (positionX < 1210 && positionX > 1036 && currPosY < 417 && currPosY > 273 - speed) able = false;//settings

            if (positionX < 972 && positionX > 846 && currPosY < 567 && currPosY > 437 - speed) able = false;//market

            return able;


        }

        private void checkPosition()
        {
            int positionX = picCharacter.Left;
            int currPosY = picCharacter.Top;

            if(moveUp == true)
            {
                if (positionX >= 130 && positionX <= 155 && currPosY <= 397 && currPosY > 360) // markett
                {
                    lblUsername.Top += 10; //volta o bicho pra
                    picCharacter.Top += 10; //volta o bicho pra fora
                    cleanMoves(); // faz parar de mover
                    admMenu menu = new admMenu(lblUsername.Text);
                    menu.Show();
                    picCharacter.Visible = false;
                    lblUsername.Visible = false;
                }

                if (positionX >= 580 && positionX <= 595 && currPosY <= 130 && currPosY > 100) // markett
                {
                    lblUsername.Top += 10; //volta o bicho pra
                    picCharacter.Top += 10; //volta o bicho pra fora
                    cleanMoves(); // faz parar de move

                    // ############## GYM 1
                    MessageBox.Show("Open gym 1"); 

                    picCharacter.Visible = false;
                    lblUsername.Visible = false;
                }

                if (positionX >= 780 && positionX <= 810 && currPosY <= 133 && currPosY > 100) // markett
                {
                    lblUsername.Top += 10; //volta o bicho pra
                    picCharacter.Top += 10; //volta o bicho pra fora
                    cleanMoves(); // faz parar de move

                    // ############## GYM 2
                    MessageBox.Show("Open gym 2"); 

                    picCharacter.Visible = false;
                    lblUsername.Visible = false;
                }

                if (positionX >= 1020 && positionX <= 1050 && currPosY <= 133 && currPosY > 100) // markett
                {
                    lblUsername.Top += 10; //volta o bicho pra
                    picCharacter.Top += 10; //volta o bicho pra fora
                    cleanMoves(); // faz parar de move

                    // ############## GYM 3
                    MessageBox.Show("Open gym 3"); 

                    picCharacter.Visible = false;
                    lblUsername.Visible = false;
                }

                if (positionX >= 1110 && positionX <= 1140 && currPosY <= 423 && currPosY > 390) // markett
                {
                    lblUsername.Top += 10; //volta o bicho pra
                    picCharacter.Top += 10; //volta o bicho pra fora
                    cleanMoves(); // faz parar de move

                    settingsMenu menu = new settingsMenu(lblUsername.Text);
                    menu.Show();

                    picCharacter.Visible = false;
                    lblUsername.Visible = false;
                }

                if (positionX >= 910 && positionX <= 935 && currPosY <= 575 && currPosY > 540) // markett
                {
                    lblUsername.Top += 10; //volta o bicho pra
                    picCharacter.Top += 10; //volta o bicho pra fora
                    cleanMoves(); // faz parar de move

                    // ############## MARKET
                   Pokeshop pokeshop = new Pokeshop();
                    Hide();
                    pokeshop.ShowDialog();
                    Show();
                    picCharacter.Visible = false;
                    lblUsername.Visible = false;
                }

            }
                
        }


    }
}
