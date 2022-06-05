
namespace LoginProject
{
    partial class settingsMenu
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
            this.lblHello = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.btnDesloga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(17, 21);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(37, 13);
            this.lblHello.TabIndex = 11;
            this.lblHello.Text = "Hello !";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogOut.Location = new System.Drawing.Point(106, 154);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(138, 67);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Close";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnChangePW
            // 
            this.btnChangePW.Location = new System.Drawing.Point(20, 65);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(138, 67);
            this.btnChangePW.TabIndex = 9;
            this.btnChangePW.Text = "Change Password";
            this.btnChangePW.UseVisualStyleBackColor = true;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // btnDesloga
            // 
            this.btnDesloga.BackColor = System.Drawing.Color.Red;
            this.btnDesloga.Location = new System.Drawing.Point(201, 65);
            this.btnDesloga.Name = "btnDesloga";
            this.btnDesloga.Size = new System.Drawing.Size(138, 67);
            this.btnDesloga.TabIndex = 8;
            this.btnDesloga.Text = "Log Out";
            this.btnDesloga.UseVisualStyleBackColor = false;
            this.btnDesloga.Click += new System.EventHandler(this.btnDesloga_Click);
            // 
            // settingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 245);
            this.ControlBox = false;
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnChangePW);
            this.Controls.Add(this.btnDesloga);
            this.Name = "settingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnDesloga;
    }
}