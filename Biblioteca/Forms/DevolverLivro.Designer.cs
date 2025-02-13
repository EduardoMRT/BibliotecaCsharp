namespace Biblioteca.Forms
{
    partial class DevolverLivro
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
            label1 = new Label();
            panel1 = new Panel();
            btnRenovar = new Button();
            btnCadastrar = new Button();
            txtCPF = new MaskedTextBox();
            btnVoltar = new Button();
            lblCPF = new Label();
            btnPesquisar = new Button();
            txtNome = new MaskedTextBox();
            lblNome = new Label();
            lblLivro = new Label();
            cbLivro = new ComboBox();
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
            lblSbiblio.TabIndex = 3;
            lblSbiblio.Text = "SBIBLIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(29, 55);
            label1.Name = "label1";
            label1.Size = new Size(342, 25);
            label1.TabIndex = 21;
            label1.Text = "DEVOLUÇÃO / RENOVAÇÃO DE LIVROS";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRenovar);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtCPF);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(lblCPF);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(lblLivro);
            panel1.Controls.Add(cbLivro);
            panel1.Location = new Point(29, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 219);
            panel1.TabIndex = 20;
            // 
            // btnRenovar
            // 
            btnRenovar.Font = new Font("Segoe UI", 12F);
            btnRenovar.Location = new Point(372, 181);
            btnRenovar.Name = "btnRenovar";
            btnRenovar.Size = new Size(112, 33);
            btnRenovar.TabIndex = 24;
            btnRenovar.Text = "RENOVAR";
            btnRenovar.UseVisualStyleBackColor = true;
            btnRenovar.Click += btnRenovar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(254, 181);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 33);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "DEVOLVER";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 12F);
            txtCPF.Location = new Point(72, 19);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(166, 29);
            txtCPF.TabIndex = 3;
            txtCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(136, 181);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 33);
            btnVoltar.TabIndex = 22;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 12F);
            lblCPF.Location = new Point(28, 22);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(40, 21);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "CPF:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 12F);
            btnPesquisar.Location = new Point(244, 19);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(119, 29);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtNome
            // 
            txtNome.CausesValidation = false;
            txtNome.Enabled = false;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(94, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 29);
            txtNome.TabIndex = 7;
            txtNome.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.CausesValidation = false;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(28, 57);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome:";
            lblNome.Visible = false;
            // 
            // lblLivro
            // 
            lblLivro.AutoSize = true;
            lblLivro.Font = new Font("Segoe UI", 12F);
            lblLivro.Location = new Point(28, 92);
            lblLivro.Name = "lblLivro";
            lblLivro.Size = new Size(48, 21);
            lblLivro.TabIndex = 11;
            lblLivro.Text = "Livro:";
            // 
            // cbLivro
            // 
            cbLivro.Font = new Font("Segoe UI", 12F);
            cbLivro.FormattingEnabled = true;
            cbLivro.Location = new Point(94, 89);
            cbLivro.Name = "cbLivro";
            cbLivro.Size = new Size(350, 29);
            cbLivro.TabIndex = 12;
            // 
            // DevolverLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblSbiblio);
            Name = "DevolverLivro";
            Text = "Devolução e Renovação de Livros";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSbiblio;
        private Label label1;
        private Panel panel1;
        private MaskedTextBox txtCPF;
        private Label lblCPF;
        private Button btnPesquisar;
        private MaskedTextBox txtNome;
        private Label lblNome;
        private Label lblLivro;
        private ComboBox cbLivro;
        private Button btnCadastrar;
        private Button btnVoltar;
        private Button btnRenovar;
    }
}