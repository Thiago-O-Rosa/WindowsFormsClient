namespace WindowsFormsClient
{
    partial class FormLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblBemVindo01 = new System.Windows.Forms.Label();
            this.lblBemVindo02 = new System.Windows.Forms.Label();
            this.pnlAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAzul
            // 
            this.pnlAzul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAzul.Controls.Add(this.lblBemVindo02);
            this.pnlAzul.Controls.Add(this.lblBemVindo01);
            this.pnlAzul.Controls.Add(this.pbxLogo);
            this.pnlAzul.Location = new System.Drawing.Point(0, 0);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(400, 700);
            this.pnlAzul.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.FlatAppearance.BorderSize = 2;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.Location = new System.Drawing.Point(860, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.ErrorImage = null;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.ImageLocation = "10";
            this.pbxLogo.InitialImage = null;
            this.pbxLogo.Location = new System.Drawing.Point(135, 200);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(130, 130);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lblBemVindo01
            // 
            this.lblBemVindo01.AutoSize = true;
            this.lblBemVindo01.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo01.Location = new System.Drawing.Point(72, 335);
            this.lblBemVindo01.Name = "lblBemVindo01";
            this.lblBemVindo01.Size = new System.Drawing.Size(271, 30);
            this.lblBemVindo01.TabIndex = 1;
            this.lblBemVindo01.Text = "Seja Bem Vindo ao Sistema ";
            // 
            // lblBemVindo02
            // 
            this.lblBemVindo02.AutoSize = true;
            this.lblBemVindo02.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo02.ForeColor = System.Drawing.Color.Black;
            this.lblBemVindo02.Location = new System.Drawing.Point(39, 365);
            this.lblBemVindo02.Name = "lblBemVindo02";
            this.lblBemVindo02.Size = new System.Drawing.Size(317, 45);
            this.lblBemVindo02.TabIndex = 2;
            this.lblBemVindo02.Text = "Controle de Estoque";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlAzul);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pnlAzul.ResumeLayout(false);
            this.pnlAzul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblBemVindo02;
        private System.Windows.Forms.Label lblBemVindo01;
    }
}

