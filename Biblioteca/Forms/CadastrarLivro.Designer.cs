namespace Biblioteca.Forms
{
    partial class CadastrarLivro
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
            lblSbiblio = new Label();
            panel1 = new Panel();
            lblCadastrarLivro = new Label();
            btnCadastrar = new Button();
            cbAutor = new ComboBox();
            txtNome = new TextBox();
            lblAutor = new Label();
            lblNome = new Label();
            btnVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSbiblio
            // 
            lblSbiblio.AutoSize = true;
            lblSbiblio.Font = new Font("Segoe UI", 18F);
            lblSbiblio.Location = new Point(12, 9);
            lblSbiblio.Name = "lblSbiblio";
            lblSbiblio.Size = new Size(96, 32);
            lblSbiblio.TabIndex = 1;
            lblSbiblio.Text = "SBIBLIO";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(lblCadastrarLivro);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(cbAutor);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblAutor);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(251, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 273);
            panel1.TabIndex = 2;
            // 
            // lblCadastrarLivro
            // 
            lblCadastrarLivro.AutoSize = true;
            lblCadastrarLivro.Font = new Font("Segoe UI", 14F);
            lblCadastrarLivro.Location = new Point(73, 11);
            lblCadastrarLivro.Name = "lblCadastrarLivro";
            lblCadastrarLivro.Size = new Size(139, 25);
            lblCadastrarLivro.TabIndex = 6;
            lblCadastrarLivro.Text = "Cadastrar Livro";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(149, 208);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 33);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cbAutor
            // 
            cbAutor.Font = new Font("Segoe UI", 12F);
            cbAutor.FormattingEnabled = true;
            cbAutor.Location = new Point(73, 155);
            cbAutor.Name = "cbAutor";
            cbAutor.Size = new Size(139, 29);
            cbAutor.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(73, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(139, 29);
            txtNome.TabIndex = 3;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 12F);
            lblAutor.Location = new Point(118, 131);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(49, 21);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(118, 52);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(22, 208);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 33);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // CadastrarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblSbiblio);
            Name = "CadastrarLivro";
            Text = "CadastrarLivro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSbiblio;
        private Panel panel1;
        private TextBox txtNome;
        private Label lblAutor;
        private Label lblNome;
        private Button btnCadastrar;
        private ComboBox cbAutor;
        private Label lblCadastrarLivro;
        private Button btnVoltar;
    }
}