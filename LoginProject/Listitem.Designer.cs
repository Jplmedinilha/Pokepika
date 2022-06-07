namespace LoginProject
{
    partial class Listitem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPoke = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPoke)).BeginInit();
            this.SuspendLayout();
            // 
            // picPoke
            // 
            this.picPoke.Image = global::LoginProject.Properties.Resources._001;
            this.picPoke.Location = new System.Drawing.Point(-1, 0);
            this.picPoke.Name = "picPoke";
            this.picPoke.Size = new System.Drawing.Size(97, 80);
            this.picPoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoke.TabIndex = 0;
            this.picPoke.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblName.Location = new System.Drawing.Point(102, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Bulbassaur";
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.DarkGray;
            this.lblType.Location = new System.Drawing.Point(103, 38);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 22);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Grass";
            // 
            // Listitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picPoke);
            this.Name = "Listitem";
            this.Size = new System.Drawing.Size(292, 78);
            this.Load += new System.EventHandler(this.Listitem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPoke;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
    }
}
