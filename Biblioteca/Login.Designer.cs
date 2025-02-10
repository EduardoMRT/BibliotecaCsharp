
namespace Biblioteca
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSbiblio = new Label();
            lblUsuario = new Label();
            panel1 = new Panel();
            btnEntrar = new Button();
            txtSenha = new MaskedTextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            linkNaoTemConta = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSbiblio
            // 
            lblSbiblio.AutoSize = true;
            lblSbiblio.Font = new Font("Segoe UI", 18F);
            lblSbiblio.Location = new Point(10, 7);
            lblSbiblio.Name = "lblSbiblio";
            lblSbiblio.Size = new Size(96, 32);
            lblSbiblio.TabIndex = 0;
            lblSbiblio.Text = "SBIBLIO";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(77, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário";
            lblUsuario.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblUsuario);
            panel1.Location = new Point(241, 61);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 182);
            panel1.TabIndex = 2;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(65, 136);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 31);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += Button1_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(26, 98);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(171, 29);
            txtSenha.TabIndex = 4;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(26, 32);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(171, 29);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.Location = new Point(82, 75);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(53, 21);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // linkNaoTemConta
            // 
            linkNaoTemConta.AutoSize = true;
            linkNaoTemConta.Location = new Point(289, 254);
            linkNaoTemConta.Name = "linkNaoTemConta";
            linkNaoTemConta.Size = new Size(133, 15);
            linkNaoTemConta.TabIndex = 3;
            linkNaoTemConta.TabStop = true;
            linkNaoTemConta.Text = "Não possuo uma conta.";
            linkNaoTemConta.LinkClicked += linkNaoTemConta_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(linkNaoTemConta);
            Controls.Add(panel1);
            Controls.Add(lblSbiblio);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

       

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label lblSbiblio;
        private Label lblUsuario;
        private Panel panel1;
        private Label lblSenha;
        private Button btnEntrar;
        private MaskedTextBox txtSenha;
        private TextBox txtUsuario;
        private LinkLabel linkNaoTemConta;
    }
}
