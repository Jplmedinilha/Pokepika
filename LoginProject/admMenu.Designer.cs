
namespace LoginProject
{
    partial class admMenu
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnPokemons = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(46, 62);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(138, 67);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Users management";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnPokemons
            // 
            this.btnPokemons.Location = new System.Drawing.Point(235, 62);
            this.btnPokemons.Name = "btnPokemons";
            this.btnPokemons.Size = new System.Drawing.Size(138, 67);
            this.btnPokemons.TabIndex = 1;
            this.btnPokemons.Text = "Pokemons management";
            this.btnPokemons.UseVisualStyleBackColor = true;
            this.btnPokemons.Click += new System.EventHandler(this.btnPokemons_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(51, 20);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(37, 13);
            this.lblHello.TabIndex = 6;
            this.lblHello.Text = "Hello !";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 67);
            this.button1.TabIndex = 7;
            this.button1.Text = "Type management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Location = new System.Drawing.Point(235, 154);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(138, 67);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Close";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // admMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 252);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPokemons);
            this.Controls.Add(this.btnUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnPokemons;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogOut;
    }
}