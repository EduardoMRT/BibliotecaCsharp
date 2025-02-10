namespace Biblioteca.Forms
{
    partial class CadastrarPessoa
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
            panel1 = new Panel();
            txtCEP = new MaskedTextBox();
            txtCPF = new MaskedTextBox();
            lblCPF = new Label();
            txtNCasa = new TextBox();
            label6 = new Label();
            lblCep = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblTelefone = new Label();
            txtSobrenome = new TextBox();
            lblSobrenome = new Label();
            btnVoltar = new Button();
            lblCadastrarPessoa = new Label();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            lblSbiblio = new Label();
            txtTelefone = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(txtCEP);
            panel1.Controls.Add(txtCPF);
            panel1.Controls.Add(lblCPF);
            panel1.Controls.Add(txtNCasa);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblCep);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblTelefone);
            panel1.Controls.Add(txtSobrenome);
            panel1.Controls.Add(lblSobrenome);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(lblCadastrarPessoa);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(71, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 368);
            panel1.TabIndex = 3;
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 12F);
            txtCEP.Location = new Point(103, 248);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(214, 29);
            txtCEP.TabIndex = 20;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 12F);
            txtCPF.Location = new Point(103, 68);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(214, 29);
            txtCPF.TabIndex = 19;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 12F);
            lblCPF.Location = new Point(12, 70);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(40, 21);
            lblCPF.TabIndex = 17;
            lblCPF.Text = "CPF:";
            // 
            // txtNCasa
            // 
            txtNCasa.Font = new Font("Segoe UI", 12F);
            txtNCasa.Location = new Point(103, 283);
            txtNCasa.Name = "txtNCasa";
            txtNCasa.Size = new Size(214, 29);
            txtNCasa.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 286);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 15;
            label6.Text = "N° Casa:";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 12F);
            lblCep.Location = new Point(12, 251);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(40, 21);
            lblCep.TabIndex = 13;
            lblCep.Text = "CEP:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(103, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 29);
            txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(12, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "E-mail:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F);
            lblTelefone.Location = new Point(12, 178);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(62, 21);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Celular:";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Font = new Font("Segoe UI", 12F);
            txtSobrenome.Location = new Point(103, 137);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(214, 29);
            txtSobrenome.TabIndex = 8;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Font = new Font("Segoe UI", 12F);
            lblSobrenome.Location = new Point(12, 140);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(94, 21);
            lblSobrenome.TabIndex = 7;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(366, 330);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 33);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblCadastrarPessoa
            // 
            lblCadastrarPessoa.AutoSize = true;
            lblCadastrarPessoa.Font = new Font("Segoe UI", 14F);
            lblCadastrarPessoa.Location = new Point(12, 16);
            lblCadastrarPessoa.Name = "lblCadastrarPessoa";
            lblCadastrarPessoa.Size = new Size(155, 25);
            lblCadastrarPessoa.TabIndex = 6;
            lblCadastrarPessoa.Text = "Cadastrar Pessoa";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(493, 330);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 33);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(103, 102);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 29);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(12, 102);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblSbiblio
            // 
            lblSbiblio.AutoSize = true;
            lblSbiblio.Font = new Font("Segoe UI", 18F);
            lblSbiblio.Location = new Point(12, 9);
            lblSbiblio.Name = "lblSbiblio";
            lblSbiblio.Size = new Size(96, 32);
            lblSbiblio.TabIndex = 4;
            lblSbiblio.Text = "SBIBLIO";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F);
            txtTelefone.Location = new Point(103, 175);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(214, 29);
            txtTelefone.TabIndex = 21;
            // 
            // CadastrarPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSbiblio);
            Controls.Add(panel1);
            Name = "CadastrarPessoa";
            Text = "CadastrarPessoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnVoltar;
        private Label lblCadastrarPessoa;
        private Button btnCadastrar;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblSbiblio;
        private TextBox txtNCasa;
        private Label label6;
        private Label lblCep;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtSobrenome;
        private Label lblSobrenome;
        private Label lblCPF;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtCEP;
        private MaskedTextBox txtTelefone;
    }
}