namespace Biblioteca.Forms
{
    partial class criaUsuario
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
            lblCSenha = new Label();
            lblSenha = new Label();
            lblUsuario = new Label();
            btnCadastrar = new Button();
            txtCSenha = new MaskedTextBox();
            txtSenha = new MaskedTextBox();
            txtUsuario = new TextBox();
            lblSbiblio = new Label();
            btnVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(lblCSenha);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtCSenha);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(239, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 254);
            panel1.TabIndex = 0;
            // 
            // lblCSenha
            // 
            lblCSenha.AutoSize = true;
            lblCSenha.Font = new Font("Segoe UI", 12F);
            lblCSenha.Location = new Point(85, 148);
            lblCSenha.Name = "lblCSenha";
            lblCSenha.Size = new Size(154, 21);
            lblCSenha.TabIndex = 6;
            lblCSenha.Text = "CONFIRMAR SENHA";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.Location = new Point(130, 87);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 21);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "SENHA";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(124, 22);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 21);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "USUÁRIO";
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(164, 207);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(120, 40);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCSenha
            // 
            txtCSenha.Font = new Font("Segoe UI", 12F);
            txtCSenha.Location = new Point(69, 172);
            txtCSenha.Name = "txtCSenha";
            txtCSenha.Size = new Size(185, 29);
            txtCSenha.TabIndex = 2;
            txtCSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(69, 111);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(185, 29);
            txtSenha.TabIndex = 1;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.MaskInputRejected += txtSenha_MaskInputRejected;
            txtSenha.Click += txtSenha_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(69, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(185, 29);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
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
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(38, 207);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 40);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // criaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSbiblio);
            Controls.Add(panel1);
            Name = "criaUsuario";
            Text = "Criar Conta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblCSenha;
        private Label lblSenha;
        private Label lblUsuario;
        private Button btnCadastrar;
        private MaskedTextBox txtCSenha;
        private MaskedTextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblSbiblio;
        private Button btnVoltar;
    }
}