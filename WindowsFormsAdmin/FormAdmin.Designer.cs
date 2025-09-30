namespace WindowsFormsAdmin
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(50, 625);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 32);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAQ.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.ForeColor = System.Drawing.Color.Black;
            this.btnFAQ.Location = new System.Drawing.Point(50, 409);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(100, 32);
            this.btnFAQ.TabIndex = 19;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.UseVisualStyleBackColor = false;
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.Transparent;
            this.btnLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivros.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLivros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.Black;
            this.btnLivros.Location = new System.Drawing.Point(50, 339);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(100, 52);
            this.btnLivros.TabIndex = 18;
            this.btnLivros.Text = "Lista de Materiais";
            this.btnLivros.UseVisualStyleBackColor = false;
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.Black;
            this.btnSobre.Location = new System.Drawing.Point(50, 460);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(100, 32);
            this.btnSobre.TabIndex = 17;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Black;
            this.btnInicio.Location = new System.Drawing.Point(51, 292);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(100, 32);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlAzul
            // 
            this.pnlAzul.AutoScroll = true;
            this.pnlAzul.BackColor = System.Drawing.Color.Transparent;
            this.pnlAzul.Controls.Add(this.pictureBox1);
            this.pnlAzul.Controls.Add(this.btnInicio);
            this.pnlAzul.Controls.Add(this.btnSair);
            this.pnlAzul.Controls.Add(this.btnSobre);
            this.pnlAzul.Controls.Add(this.btnFAQ);
            this.pnlAzul.Controls.Add(this.btnLivros);
            this.pnlAzul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlAzul.Location = new System.Drawing.Point(0, 0);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(200, 700);
            this.pnlAzul.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pnlAzul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.pnlAzul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

