
namespace LoginProject
{
    partial class pkmManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pkmManagement));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listPkm = new System.Windows.Forms.ListView();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtGym = new System.Windows.Forms.ComboBox();
            this.txtEvolution = new System.Windows.Forms.ComboBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.picPokemon = new System.Windows.Forms.PictureBox();
            this.btnUpload = new Market.Style.RJButton();
            this.rjButton3 = new Market.Style.RJButton();
            this.rjButton2 = new Market.Style.RJButton();
            this.btnSave = new Market.Style.RJButton();
            this.btnPurchase = new Market.Style.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtSearch.Location = new System.Drawing.Point(37, 188);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(417, 31);
            this.txtSearch.TabIndex = 37;
            // 
            // listPkm
            // 
            this.listPkm.HideSelection = false;
            this.listPkm.Location = new System.Drawing.Point(37, 239);
            this.listPkm.Name = "listPkm";
            this.listPkm.Size = new System.Drawing.Size(474, 395);
            this.listPkm.TabIndex = 36;
            this.listPkm.UseCompatibleStateImageBehavior = false;
            this.listPkm.SelectedIndexChanged += new System.EventHandler(this.listPkm_SelectedIndexChanged);
            this.listPkm.Click += new System.EventHandler(this.listPkm_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNum.Location = new System.Drawing.Point(712, 188);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(195, 31);
            this.txtNum.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1036, 192);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 31);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(932, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(712, 251);
            this.cbbType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(195, 33);
            this.cbbType.TabIndex = 47;
            // 
            // txtHP
            // 
            this.txtHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtHP.Location = new System.Drawing.Point(1036, 316);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(195, 31);
            this.txtHP.TabIndex = 49;
            // 
            // txtAttack
            // 
            this.txtAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtAttack.Location = new System.Drawing.Point(1036, 254);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(195, 31);
            this.txtAttack.TabIndex = 48;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtPrice.Location = new System.Drawing.Point(712, 316);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(195, 31);
            this.txtPrice.TabIndex = 52;
            // 
            // txtGym
            // 
            this.txtGym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGym.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtGym.FormattingEnabled = true;
            this.txtGym.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtGym.Location = new System.Drawing.Point(1036, 378);
            this.txtGym.Margin = new System.Windows.Forms.Padding(2);
            this.txtGym.Name = "txtGym";
            this.txtGym.Size = new System.Drawing.Size(195, 33);
            this.txtGym.TabIndex = 56;
            // 
            // txtEvolution
            // 
            this.txtEvolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEvolution.FormattingEnabled = true;
            this.txtEvolution.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.txtEvolution.Location = new System.Drawing.Point(712, 379);
            this.txtEvolution.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvolution.Name = "txtEvolution";
            this.txtEvolution.Size = new System.Drawing.Size(195, 33);
            this.txtEvolution.TabIndex = 58;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1216, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(15, 15);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 60;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(1237, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 15);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 59;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.label9.Font = new System.Drawing.Font("Montserrat ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(395, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(455, 48);
            this.label9.TabIndex = 65;
            this.label9.Text = "Pokemon Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.pictureBox1.Image = global::LoginProject.Properties.Resources.pokemon_logo_8;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(622, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 67;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(923, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 33);
            this.label3.TabIndex = 68;
            this.label3.Text = "Attack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(969, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 33);
            this.label5.TabIndex = 69;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(618, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 33);
            this.label6.TabIndex = 70;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(580, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 33);
            this.label7.TabIndex = 71;
            this.label7.Text = "Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(563, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 33);
            this.label8.TabIndex = 72;
            this.label8.Text = "Evolution";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(948, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 33);
            this.label10.TabIndex = 73;
            this.label10.Text = "Gym";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.pictureBox7.Image = global::LoginProject.Properties.Resources.search;
            this.pictureBox7.Location = new System.Drawing.Point(460, 184);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 74;
            this.pictureBox7.TabStop = false;
            // 
            // picPokemon
            // 
            this.picPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPokemon.Location = new System.Drawing.Point(1036, 472);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(195, 162);
            this.picPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPokemon.TabIndex = 75;
            this.picPokemon.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUpload.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.btnUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpload.BorderRadius = 0;
            this.btnUpload.BorderSize = 0;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(929, 607);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(92, 27);
            this.btnUpload.TabIndex = 76;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextColor = System.Drawing.Color.White;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(725, 659);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(150, 40);
            this.rjButton3.TabIndex = 64;
            this.rjButton3.Text = "Delete";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(903, 659);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 63;
            this.rjButton2.Text = "Cancel";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(547, 659);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Create";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPurchase.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPurchase.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPurchase.BorderRadius = 20;
            this.btnPurchase.BorderSize = 0;
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(1081, 659);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(150, 40);
            this.btnPurchase.TabIndex = 61;
            this.btnPurchase.Text = "Close";
            this.btnPurchase.TextColor = System.Drawing.Color.White;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // pkmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picPokemon);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txtEvolution);
            this.Controls.Add(this.txtGym);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.txtAttack);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listPkm);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pkmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemons Management";
            this.Load += new System.EventHandler(this.pkmManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView listPkm;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtAttack;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox txtGym;
        private System.Windows.Forms.ComboBox txtEvolution;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Market.Style.RJButton btnPurchase;
        private Market.Style.RJButton btnSave;
        private Market.Style.RJButton rjButton2;
        private Market.Style.RJButton rjButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox picPokemon;
        private Market.Style.RJButton btnUpload;
    }
}