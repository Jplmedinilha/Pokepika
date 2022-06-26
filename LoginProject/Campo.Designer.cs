
namespace LoginProject
{
    partial class Campo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Campo));
            this.labely = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseMenu = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblPokeLabel = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.picCoins = new System.Windows.Forms.PictureBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.picGym2 = new System.Windows.Forms.PictureBox();
            this.picGym1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.picManager = new System.Windows.Forms.PictureBox();
            this.picFence = new System.Windows.Forms.PictureBox();
            this.picGrass1 = new System.Windows.Forms.PictureBox();
            this.picBag = new System.Windows.Forms.PictureBox();
            this.picGrass2 = new System.Windows.Forms.PictureBox();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.picMart = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGym2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGym1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMart)).BeginInit();
            this.SuspendLayout();
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(1182, 114);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(14, 13);
            this.labely.TabIndex = 4;
            this.labely.Text = "Y";
            this.labely.Visible = false;
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(1182, 83);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(14, 13);
            this.labelx.TabIndex = 3;
            this.labelx.Text = "X";
            this.labelx.Visible = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 30;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 588);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(36, 13);
            this.lblUsername.TabIndex = 62;
            this.lblUsername.Text = "Player";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnCloseMenu);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblPokeLabel);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.picCoins);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Location = new System.Drawing.Point(1222, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 683);
            this.panel1.TabIndex = 69;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCloseMenu
            // 
            this.btnCloseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.btnCloseMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseMenu.Image")));
            this.btnCloseMenu.Location = new System.Drawing.Point(331, 14);
            this.btnCloseMenu.Name = "btnCloseMenu";
            this.btnCloseMenu.Size = new System.Drawing.Size(15, 15);
            this.btnCloseMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseMenu.TabIndex = 71;
            this.btnCloseMenu.TabStop = false;
            this.btnCloseMenu.Click += new System.EventHandler(this.btnCloseMenu_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 265);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(317, 404);
            this.flowLayoutPanel1.TabIndex = 76;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.Enter += new System.EventHandler(this.flowLayoutPanel1_Enter);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.picLogo.Image = global::LoginProject.Properties.Resources.pokemon_logo_8;
            this.picLogo.Location = new System.Drawing.Point(12, 14);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 75;
            this.picLogo.TabStop = false;
            // 
            // lblPokeLabel
            // 
            this.lblPokeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPokeLabel.AutoSize = true;
            this.lblPokeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.lblPokeLabel.Font = new System.Drawing.Font("Montserrat Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokeLabel.ForeColor = System.Drawing.Color.Salmon;
            this.lblPokeLabel.Location = new System.Drawing.Point(24, 232);
            this.lblPokeLabel.Name = "lblPokeLabel";
            this.lblPokeLabel.Size = new System.Drawing.Size(134, 29);
            this.lblPokeLabel.TabIndex = 74;
            this.lblPokeLabel.Text = "Pokemons";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.lblUser.Font = new System.Drawing.Font("Montserrat ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(20, 128);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(269, 51);
            this.lblUser.TabIndex = 72;
            this.lblUser.Text = "Usernameds";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // picCoins
            // 
            this.picCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.picCoins.Image = global::LoginProject.Properties.Resources.icons8_coin_64;
            this.picCoins.Location = new System.Drawing.Point(219, 219);
            this.picCoins.Name = "picCoins";
            this.picCoins.Size = new System.Drawing.Size(40, 40);
            this.picCoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoins.TabIndex = 70;
            this.picCoins.TabStop = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.lblBalance.Font = new System.Drawing.Font("JetBrains Mono NL", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.LightGreen;
            this.lblBalance.Location = new System.Drawing.Point(265, 231);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 31);
            this.lblBalance.TabIndex = 71;
            this.lblBalance.Text = "9999";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1050, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(966, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1185, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(15, 15);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 68;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // picGym2
            // 
            this.picGym2.Image = ((System.Drawing.Image)(resources.GetObject("picGym2.Image")));
            this.picGym2.Location = new System.Drawing.Point(755, 55);
            this.picGym2.Name = "picGym2";
            this.picGym2.Size = new System.Drawing.Size(127, 72);
            this.picGym2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGym2.TabIndex = 64;
            this.picGym2.TabStop = false;
            // 
            // picGym1
            // 
            this.picGym1.Image = ((System.Drawing.Image)(resources.GetObject("picGym1.Image")));
            this.picGym1.Location = new System.Drawing.Point(568, 44);
            this.picGym1.Name = "picGym1";
            this.picGym1.Size = new System.Drawing.Size(80, 83);
            this.picGym1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGym1.TabIndex = 63;
            this.picGym1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1213, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 67;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // picManager
            // 
            this.picManager.Image = ((System.Drawing.Image)(resources.GetObject("picManager.Image")));
            this.picManager.Location = new System.Drawing.Point(113, 263);
            this.picManager.Name = "picManager";
            this.picManager.Size = new System.Drawing.Size(132, 126);
            this.picManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picManager.TabIndex = 61;
            this.picManager.TabStop = false;
            // 
            // picFence
            // 
            this.picFence.Image = ((System.Drawing.Image)(resources.GetObject("picFence.Image")));
            this.picFence.Location = new System.Drawing.Point(89, 303);
            this.picFence.Name = "picFence";
            this.picFence.Size = new System.Drawing.Size(178, 124);
            this.picFence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFence.TabIndex = 60;
            this.picFence.TabStop = false;
            // 
            // picGrass1
            // 
            this.picGrass1.Image = ((System.Drawing.Image)(resources.GetObject("picGrass1.Image")));
            this.picGrass1.Location = new System.Drawing.Point(21, 62);
            this.picGrass1.Name = "picGrass1";
            this.picGrass1.Size = new System.Drawing.Size(204, 177);
            this.picGrass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrass1.TabIndex = 58;
            this.picGrass1.TabStop = false;
            // 
            // picBag
            // 
            this.picBag.Image = global::LoginProject.Properties.Resources.mochila;
            this.picBag.Location = new System.Drawing.Point(1151, 162);
            this.picBag.Name = "picBag";
            this.picBag.Size = new System.Drawing.Size(65, 52);
            this.picBag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBag.TabIndex = 70;
            this.picBag.TabStop = false;
            this.picBag.Click += new System.EventHandler(this.picBag_Click);
            // 
            // picGrass2
            // 
            this.picGrass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picGrass2.Image = ((System.Drawing.Image)(resources.GetObject("picGrass2.Image")));
            this.picGrass2.Location = new System.Drawing.Point(681, 356);
            this.picGrass2.Name = "picGrass2";
            this.picGrass2.Size = new System.Drawing.Size(180, 214);
            this.picGrass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrass2.TabIndex = 57;
            this.picGrass2.TabStop = false;
            // 
            // picCharacter
            // 
            this.picCharacter.Image = ((System.Drawing.Image)(resources.GetObject("picCharacter.Image")));
            this.picCharacter.Location = new System.Drawing.Point(12, 603);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(20, 29);
            this.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCharacter.TabIndex = 56;
            this.picCharacter.TabStop = false;
            // 
            // picMart
            // 
            this.picMart.Image = ((System.Drawing.Image)(resources.GetObject("picMart.Image")));
            this.picMart.Location = new System.Drawing.Point(867, 468);
            this.picMart.Name = "picMart";
            this.picMart.Size = new System.Drawing.Size(106, 102);
            this.picMart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMart.TabIndex = 6;
            this.picMart.TabStop = false;
            // 
            // Campo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1580, 679);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.picGym2);
            this.Controls.Add(this.picGym1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picManager);
            this.Controls.Add(this.picFence);
            this.Controls.Add(this.picGrass1);
            this.Controls.Add(this.picBag);
            this.Controls.Add(this.picGrass2);
            this.Controls.Add(this.picCharacter);
            this.Controls.Add(this.picMart);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Campo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campo";
            this.Load += new System.EventHandler(this.Campo_Load);
            this.Click += new System.EventHandler(this.Campo_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Campo_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Campo_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Campo_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGym2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGym1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.PictureBox picMart;
        public System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox picGrass2;
        private System.Windows.Forms.PictureBox picGrass1;
        private System.Windows.Forms.PictureBox picFence;
        private System.Windows.Forms.PictureBox picManager;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picGym1;
        private System.Windows.Forms.PictureBox picGym2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picCoins;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPokeLabel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox picBag;
        private System.Windows.Forms.PictureBox btnCloseMenu;
    }
}