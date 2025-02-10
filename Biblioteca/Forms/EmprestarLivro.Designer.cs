namespace Biblioteca.Forms
{
    partial class EmprestarLivro
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
            components = new System.ComponentModel.Container();
            lblSbiblio = new Label();
            txtCPF = new MaskedTextBox();
            lblCPF = new Label();
            btnPesquisar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNome = new MaskedTextBox();
            lblNome = new Label();
            btnVoltar = new Button();
            lblLivro = new Label();
            cbLivro = new ComboBox();
            txtDataEmprestimo = new MaskedTextBox();
            lblDataEmprestimo = new Label();
            lblDataDevolucao = new Label();
            txtDataDevolucao = new MaskedTextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblSbiblio
            // 
            lblSbiblio.AutoSize = true;
            lblSbiblio.Font = new Font("Segoe UI", 18F);
            lblSbiblio.Location = new Point(12, 9);
            lblSbiblio.Name = "lblSbiblio";
            lblSbiblio.Size = new Size(96, 32);
            lblSbiblio.TabIndex = 2;
            lblSbiblio.Text = "SBIBLIO";
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 12F);
            txtCPF.Location = new Point(79, 77);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(166, 29);
            txtCPF.TabIndex = 3;
            txtCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 12F);
            lblCPF.Location = new Point(35, 80);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(40, 21);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "CPF:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 12F);
            btnPesquisar.Location = new Point(251, 77);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(119, 29);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNome
            // 
            txtNome.CausesValidation = false;
            txtNome.Enabled = false;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(101, 112);
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
            lblNome.Location = new Point(35, 115);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome:";
            lblNome.Visible = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(550, 405);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 33);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblLivro
            // 
            lblLivro.AutoSize = true;
            lblLivro.Font = new Font("Segoe UI", 12F);
            lblLivro.Location = new Point(35, 150);
            lblLivro.Name = "lblLivro";
            lblLivro.Size = new Size(48, 21);
            lblLivro.TabIndex = 11;
            lblLivro.Text = "Livro:";
            // 
            // cbLivro
            // 
            cbLivro.Font = new Font("Segoe UI", 12F);
            cbLivro.FormattingEnabled = true;
            cbLivro.Location = new Point(101, 147);
            cbLivro.Name = "cbLivro";
            cbLivro.Size = new Size(350, 29);
            cbLivro.TabIndex = 12;
            cbLivro.KeyPress += cbLivro_KeyPress;
            cbLivro.KeyUp += cbLivro_KeyUp;
            // 
            // txtDataEmprestimo
            // 
            txtDataEmprestimo.Font = new Font("Segoe UI", 12F);
            txtDataEmprestimo.Location = new Point(35, 209);
            txtDataEmprestimo.Name = "txtDataEmprestimo";
            txtDataEmprestimo.Size = new Size(133, 29);
            txtDataEmprestimo.TabIndex = 13;
            txtDataEmprestimo.TextAlign = HorizontalAlignment.Center;
            txtDataEmprestimo.KeyUp += txtDataEmprestimo_KeyUp;
            // 
            // lblDataEmprestimo
            // 
            lblDataEmprestimo.AutoSize = true;
            lblDataEmprestimo.Font = new Font("Segoe UI", 12F);
            lblDataEmprestimo.Location = new Point(35, 185);
            lblDataEmprestimo.Name = "lblDataEmprestimo";
            lblDataEmprestimo.Size = new Size(130, 21);
            lblDataEmprestimo.TabIndex = 14;
            lblDataEmprestimo.Text = "Data Empréstimo";
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Font = new Font("Segoe UI", 12F);
            lblDataDevolucao.Location = new Point(229, 185);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new Size(119, 21);
            lblDataDevolucao.TabIndex = 15;
            lblDataDevolucao.Text = "Data Devolução";
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.Font = new Font("Segoe UI", 12F);
            txtDataDevolucao.Location = new Point(229, 209);
            txtDataDevolucao.Name = "txtDataDevolucao";
            txtDataDevolucao.Size = new Size(119, 29);
            txtDataDevolucao.TabIndex = 16;
            txtDataDevolucao.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(676, 405);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 33);
            btnCadastrar.TabIndex = 17;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // EmprestarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(txtDataDevolucao);
            Controls.Add(lblDataDevolucao);
            Controls.Add(lblDataEmprestimo);
            Controls.Add(txtDataEmprestimo);
            Controls.Add(cbLivro);
            Controls.Add(lblLivro);
            Controls.Add(btnVoltar);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(btnPesquisar);
            Controls.Add(lblCPF);
            Controls.Add(txtCPF);
            Controls.Add(lblSbiblio);
            Name = "EmprestarLivro";
            Text = "EmprestarLivro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSbiblio;
        private MaskedTextBox txtCPF;
        private Label lblCPF;
        private Button btnPesquisar;
        private ContextMenuStrip contextMenuStrip1;
        private MaskedTextBox txtNome;
        private Label lblNome;
        private Button btnVoltar;
        private Label lblLivro;
        private ComboBox cbLivro;
        private MaskedTextBox txtDataEmprestimo;
        private Label lblDataEmprestimo;
        private Label lblDataDevolucao;
        private MaskedTextBox txtDataDevolucao;
        private Button btnCadastrar;
    }
}