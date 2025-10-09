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
            this.lblBemVindo02 = new System.Windows.Forms.Label();
            this.lblBemVindo01 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pbxSenha = new System.Windows.Forms.PictureBox();
            this.pbxEmail = new System.Windows.Forms.PictureBox();
            this.pnlAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAzul
            // 
            this.pnlAzul.AutoScroll = true;
            this.pnlAzul.BackColor = System.Drawing.Color.Transparent;
            this.pnlAzul.BackgroundImage = global::WindowsFormsClient.Properties.Resources.blue_gradient_background_07xqmk2r9n9vmxli;
            this.pnlAzul.Controls.Add(this.lblBemVindo02);
            this.pnlAzul.Controls.Add(this.lblBemVindo01);
            this.pnlAzul.Controls.Add(this.pbxLogo);
            this.pnlAzul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlAzul.Location = new System.Drawing.Point(0, 0);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(400, 700);
            this.pnlAzul.TabIndex = 0;
            // 
            // lblBemVindo02
            // 
            this.lblBemVindo02.AutoSize = true;
            this.lblBemVindo02.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo02.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo02.Location = new System.Drawing.Point(12, 397);
            this.lblBemVindo02.Name = "lblBemVindo02";
            this.lblBemVindo02.Size = new System.Drawing.Size(364, 50);
            this.lblBemVindo02.TabIndex = 6;
            this.lblBemVindo02.Text = "Controle de Estoque";
            // 
            // lblBemVindo01
            // 
            this.lblBemVindo01.AutoSize = true;
            this.lblBemVindo01.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBemVindo01.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo01.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo01.Location = new System.Drawing.Point(51, 365);
            this.lblBemVindo01.Name = "lblBemVindo01";
            this.lblBemVindo01.Size = new System.Drawing.Size(313, 32);
            this.lblBemVindo01.TabIndex = 5;
            this.lblBemVindo01.Text = "Seja Bem Vindo ao Sistema ";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.ErrorImage = null;
            this.pbxLogo.ImageLocation = "10";
            this.pbxLogo.InitialImage = null;
            this.pbxLogo.Location = new System.Drawing.Point(146, 223);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(130, 130);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 4;
            this.pbxLogo.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.FlatAppearance.BorderSize = 2;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.ImageKey = "(nenhum/a)";
            this.btnFechar.Location = new System.Drawing.Point(846, -9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(115, 43);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X           ";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(631, 194);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(59, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(626, 297);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 25);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(598, 222);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(125, 20);
            this.tbxEmail.TabIndex = 4;
            this.tbxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmail_KeyPress);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(598, 324);
            this.tbxSenha.MaxLength = 16;
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(125, 20);
            this.tbxSenha.TabIndex = 5;
            this.tbxSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSenha_KeyPress);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(616, 439);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(84, 32);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pbxSenha
            // 
            this.pbxSenha.Image = ((System.Drawing.Image)(resources.GetObject("pbxSenha.Image")));
            this.pbxSenha.Location = new System.Drawing.Point(562, 319);
            this.pbxSenha.Name = "pbxSenha";
            this.pbxSenha.Size = new System.Drawing.Size(30, 30);
            this.pbxSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSenha.TabIndex = 8;
            this.pbxSenha.TabStop = false;
            this.pbxSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxSenha_MouseDown);
            this.pbxSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxSenha_MouseUp);
            // 
            // pbxEmail
            // 
            this.pbxEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbxEmail.Image")));
            this.pbxEmail.Location = new System.Drawing.Point(562, 214);
            this.pbxEmail.Name = "pbxEmail";
            this.pbxEmail.Size = new System.Drawing.Size(30, 30);
            this.pbxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEmail.TabIndex = 7;
            this.pbxEmail.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pbxSenha);
            this.Controls.Add(this.pbxEmail);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlAzul);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pnlAzul.ResumeLayout(false);
            this.pnlAzul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pbxEmail;
        private System.Windows.Forms.PictureBox pbxSenha;
        private System.Windows.Forms.Label lblBemVindo02;
        private System.Windows.Forms.Label lblBemVindo01;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}

