using System.Windows.Forms;

namespace Biblioteca.Forms
{
    partial class Iniciocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciocs));
            lblUsuario = new Label();
            lblSbiblio = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnPesquisa = new Button();
            txtNomeLivro = new TextBox();
            label1 = new Label();
            dGVLivrosEmprestimosAtuais = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            btnImprimir = new Button();
            dGVLivros = new DataGridView();
            panel1 = new Panel();
            btnCadastrarPessoa = new Button();
            btnCadastrarAutor = new Button();
            btnConsultaAutor = new Button();
            btnCadastrarLivro = new Button();
            lbAutores = new ListBox();
            cbEmprestimo = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVLivrosEmprestimosAtuais).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVLivros).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            resources.ApplyResources(lblUsuario, "lblUsuario");
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblSbiblio
            // 
            resources.ApplyResources(lblSbiblio, "lblSbiblio");
            lblSbiblio.Name = "lblSbiblio";
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Controls.Add(btnPesquisa);
            tabPage1.Controls.Add(txtNomeLivro);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dGVLivrosEmprestimosAtuais);
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            resources.ApplyResources(btnPesquisa, "btnPesquisa");
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // txtNomeLivro
            // 
            resources.ApplyResources(txtNomeLivro, "txtNomeLivro");
            txtNomeLivro.Name = "txtNomeLivro";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // dGVLivrosEmprestimosAtuais
            // 
            resources.ApplyResources(dGVLivrosEmprestimosAtuais, "dGVLivrosEmprestimosAtuais");
            dGVLivrosEmprestimosAtuais.AllowUserToAddRows = false;
            dGVLivrosEmprestimosAtuais.AllowUserToDeleteRows = false;
            dGVLivrosEmprestimosAtuais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVLivrosEmprestimosAtuais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVLivrosEmprestimosAtuais.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dGVLivrosEmprestimosAtuais.Name = "dGVLivrosEmprestimosAtuais";
            dGVLivrosEmprestimosAtuais.ReadOnly = true;
            dGVLivrosEmprestimosAtuais.RowHeadersVisible = false;
            dGVLivrosEmprestimosAtuais.CellContentClick += dGVLivrosEmprestimosAtuais_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Controls.Add(btnImprimir);
            tabPage2.Controls.Add(dGVLivros);
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnImprimir
            // 
            resources.ApplyResources(btnImprimir, "btnImprimir");
            btnImprimir.Name = "btnImprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // dGVLivros
            // 
            resources.ApplyResources(dGVLivros, "dGVLivros");
            dGVLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVLivros.Name = "dGVLivros";
            dGVLivros.ReadOnly = true;
            dGVLivros.CellContentClick += dGVLivros_CellContentClick;
            dGVLivros.KeyPress += dGVLivros_KeyPress;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCadastrarPessoa);
            panel1.Controls.Add(btnCadastrarAutor);
            panel1.Controls.Add(btnConsultaAutor);
            panel1.Controls.Add(btnCadastrarLivro);
            panel1.Name = "panel1";
            // 
            // btnCadastrarPessoa
            // 
            resources.ApplyResources(btnCadastrarPessoa, "btnCadastrarPessoa");
            btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            btnCadastrarPessoa.UseVisualStyleBackColor = true;
            btnCadastrarPessoa.Click += btnCadastrarPessoa_Click;
            // 
            // btnCadastrarAutor
            // 
            resources.ApplyResources(btnCadastrarAutor, "btnCadastrarAutor");
            btnCadastrarAutor.Name = "btnCadastrarAutor";
            btnCadastrarAutor.UseVisualStyleBackColor = true;
            btnCadastrarAutor.Click += btnCadastrarAutor_Click_1;
            // 
            // btnConsultaAutor
            // 
            resources.ApplyResources(btnConsultaAutor, "btnConsultaAutor");
            btnConsultaAutor.Name = "btnConsultaAutor";
            btnConsultaAutor.UseVisualStyleBackColor = true;
            btnConsultaAutor.Click += btnConsultaAutor_Click;
            // 
            // btnCadastrarLivro
            // 
            resources.ApplyResources(btnCadastrarLivro, "btnCadastrarLivro");
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.UseVisualStyleBackColor = true;
            btnCadastrarLivro.Click += btnCadastrarLivro_Click;
            // 
            // lbAutores
            // 
            resources.ApplyResources(lbAutores, "lbAutores");
            lbAutores.FormattingEnabled = true;
            lbAutores.Name = "lbAutores";
            lbAutores.SelectedIndexChanged += lbAutores_SelectedIndexChanged;
            // 
            // cbEmprestimo
            // 
            resources.ApplyResources(cbEmprestimo, "cbEmprestimo");
            cbEmprestimo.FormattingEnabled = true;
            cbEmprestimo.Items.AddRange(new object[] { resources.GetString("cbEmprestimo.Items"), resources.GetString("cbEmprestimo.Items1"), resources.GetString("cbEmprestimo.Items2") });
            cbEmprestimo.Name = "cbEmprestimo";
            // 
            // Iniciocs
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbEmprestimo);
            Controls.Add(lbAutores);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(lblSbiblio);
            Controls.Add(lblUsuario);
            Name = "Iniciocs";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVLivrosEmprestimosAtuais).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGVLivros).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSbiblio;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dGVLivrosEmprestimosAtuais;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextBox txtNomeLivro;
        private Label label1;
        private Button btnPesquisa;
        private DataGridView dGVLivros;
        private Button btnImprimir;
        private Panel panel1;
        private Button btnCadastrarLivro;
        private Button btnConsultaAutor;
        private Button btnCadastrarAutor;
        private ListBox lbAutores;
        private Button btnCadastrarPessoa;
        private ComboBox cbEmprestimo;
    }
}