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
            panel1 = new Panel();
            label1 = new Label();
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
            lblSbiblio.TabIndex = 2;
            lblSbiblio.Text = "SBIBLIO";
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
            cbLivro.SelectedIndexChanged += cbLivro_SelectedIndexChanged;
            cbLivro.KeyPress += cbLivro_KeyPress;
            cbLivro.KeyUp += cbLivro_KeyUp;
            // 
            // txtDataEmprestimo
            // 
            txtDataEmprestimo.Font = new Font("Segoe UI", 12F);
            txtDataEmprestimo.Location = new Point(28, 151);
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
            lblDataEmprestimo.Location = new Point(28, 127);
            lblDataEmprestimo.Name = "lblDataEmprestimo";
            lblDataEmprestimo.Size = new Size(130, 21);
            lblDataEmprestimo.TabIndex = 14;
            lblDataEmprestimo.Text = "Data Empréstimo";
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Font = new Font("Segoe UI", 12F);
            lblDataDevolucao.Location = new Point(222, 127);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new Size(119, 21);
            lblDataDevolucao.TabIndex = 15;
            lblDataDevolucao.Text = "Data Devolução";
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.Font = new Font("Segoe UI", 12F);
            txtDataDevolucao.Location = new Point(222, 151);
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtCPF);
            panel1.Controls.Add(lblCPF);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(txtDataDevolucao);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblDataDevolucao);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(lblDataEmprestimo);
            panel1.Controls.Add(lblLivro);
            panel1.Controls.Add(txtDataEmprestimo);
            panel1.Controls.Add(cbLivro);
            panel1.Location = new Point(41, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 219);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(41, 58);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 19;
            label1.Text = "EMPRÉSTIMO DE LIVROS";
            // 
            // EmprestarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(lblSbiblio);
            Name = "EmprestarLivro";
            Text = "EmprestarLivro";
            Load += EmprestarLivro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label1;
    }
}