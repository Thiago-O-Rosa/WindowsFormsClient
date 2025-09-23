namespace WindowsFormsClient
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this._userControlBooks = new WindowsFormsClient.UserControlBooks();
            this._userControlSobre = new WindowsFormsClient.UserControlSobre();
            this._userControlFAQ = new WindowsFormsClient.UserControlFAQ();
            this._userControlHome = new WindowsFormsClient.UserControlHome();
            this.pnlAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(810, -125);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // pnlAzul
            // 
            this.pnlAzul.AutoScroll = true;
            this.pnlAzul.BackColor = System.Drawing.Color.Transparent;
            this.pnlAzul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAzul.BackgroundImage")));
            this.pnlAzul.Controls.Add(this.pictureBox1);
            this.pnlAzul.Controls.Add(this.btnSair);
            this.pnlAzul.Controls.Add(this.btnFAQ);
            this.pnlAzul.Controls.Add(this.btnLivros);
            this.pnlAzul.Controls.Add(this.btnSobre);
            this.pnlAzul.Controls.Add(this.btnInicio);
            this.pnlAzul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlAzul.Location = new System.Drawing.Point(0, 0);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(200, 700);
            this.pnlAzul.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(50, 623);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 32);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAQ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.ForeColor = System.Drawing.Color.Transparent;
            this.btnFAQ.Location = new System.Drawing.Point(50, 399);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(100, 32);
            this.btnFAQ.TabIndex = 14;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.UseVisualStyleBackColor = false;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.Transparent;
            this.btnLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivros.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLivros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(35, 339);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(131, 35);
            this.btnLivros.TabIndex = 13;
            this.btnLivros.Text = "Lista de livros";
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.Transparent;
            this.btnSobre.Location = new System.Drawing.Point(50, 457);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(100, 32);
            this.btnSobre.TabIndex = 12;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(50, 277);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(100, 32);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // _userControlBooks
            // 
            this._userControlBooks.Location = new System.Drawing.Point(200, 0);
            this._userControlBooks.Name = "_userControlBooks";
            this._userControlBooks.Size = new System.Drawing.Size(700, 700);
            this._userControlBooks.TabIndex = 11;
            // 
            // _userControlSobre
            // 
            this._userControlSobre.Location = new System.Drawing.Point(200, 0);
            this._userControlSobre.Name = "_userControlSobre";
            this._userControlSobre.Size = new System.Drawing.Size(700, 700);
            this._userControlSobre.TabIndex = 12;
            // 
            // _userControlFAQ
            // 
            this._userControlFAQ.Location = new System.Drawing.Point(200, 0);
            this._userControlFAQ.Name = "_userControlFAQ";
            this._userControlFAQ.Size = new System.Drawing.Size(700, 700);
            this._userControlFAQ.TabIndex = 13;
            // 
            // _userControlHome
            // 
            this._userControlHome.Location = new System.Drawing.Point(200, 0);
            this._userControlHome.Name = "_userControlHome";
            this._userControlHome.Size = new System.Drawing.Size(700, 700);
            this._userControlHome.TabIndex = 14;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this._userControlHome);
            this.Controls.Add(this._userControlFAQ);
            this.Controls.Add(this._userControlSobre);
            this.Controls.Add(this._userControlBooks);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlAzul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.pnlAzul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControlBooks _userControlBooks;
        private UserControlSobre _userControlSobre;
        private UserControlFAQ _userControlFAQ;
        private UserControlHome _userControlHome;
    }
}