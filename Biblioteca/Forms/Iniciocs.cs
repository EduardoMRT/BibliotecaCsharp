using Biblioteca.DatabaseConfig;
using Biblioteca.domain;
using MySql.Data.MySqlClient;
using System.Data;


namespace Biblioteca.Forms
{
    public partial class Iniciocs : Form
    {

        private DataTable tabelaLivrosEmprestados = new DataTable();
        private DataTable tabelaLivros = new DataTable();
        private List<string> autores = new List<string>();
        private string consultaAutorTxt;

        public Iniciocs()
        {
            InitializeComponent();
            lblUsuario.Text += " " + Usuario.UsuarioNome;
            carregaListaEmprestimosAtuais();
            carregaLivros();
            consultaAutorTxt = btnConsultaAutor.Text;
        }

        public void carregaLivros()
        {
            using (MySqlConnection conn = Databasecs.Conn())
            {
                try
                {
                    string sql = "SELECT l.nome AS Nome, l.situacao AS 'Situação' FROM livros l ORDER BY l.nome ASC";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();

                    dGVLivros.Rows.Clear();
                    dGVLivros.Columns.Clear();

                    tabelaLivros.Load(reader);
                    dGVLivros.DataSource = tabelaLivros;

                    foreach (DataGridViewRow row in dGVLivros.Rows)
                    {
                        var situacao = row.Cells["Situação"].Value?.ToString()?.Trim();

                        if (string.IsNullOrEmpty(situacao))
                        {
                            row.Cells["Situação"].Value = "DISPONÍVEL";
                        }
                        else if (situacao == "EMPRESTADO")
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    dGVLivros.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar os livros\n{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void carregaListaEmprestimosAtuais()
        {
            using (MySqlConnection conn = Databasecs.Conn())
            {
                try
                {
                    string sql = "SELECT l.nome, l.autor, l.data_Emprestimo, l.data_Devolucao FROM livros l WHERE l.situacao = 'EMPRESTADO' ORDER BY l.data_Emprestimo ASC";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();

                    dGVLivrosEmprestimosAtuais.Rows.Clear();
                    dGVLivrosEmprestimosAtuais.Columns.Clear();

                    tabelaLivrosEmprestados.Load(reader);
                    dGVLivrosEmprestimosAtuais.DataSource = tabelaLivrosEmprestados;

                    dGVLivrosEmprestimosAtuais.Columns["nome"].HeaderText = "Nome";
                    dGVLivrosEmprestimosAtuais.Columns["autor"].HeaderText = "Autor";
                    dGVLivrosEmprestimosAtuais.Columns["data_Emprestimo"].HeaderText = "Data Empréstimo";
                    dGVLivrosEmprestimosAtuais.Columns["data_Devolucao"].HeaderText = "Data Devolução";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar os livros emprestados!\n{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dGVLivrosEmprestimosAtuais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string filtro = txtNomeLivro.Text;

            if (!string.IsNullOrEmpty(filtro))
            {
                DataView dv = tabelaLivrosEmprestados.DefaultView;
                dv.RowFilter = $"Nome LIKE '%{filtro}%'";
            }
            else
            {
                tabelaLivrosEmprestados.DefaultView.RowFilter = "";
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não implementado");
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => Application.Run(new CadastrarLivro()));
            thread.Start();
            this.Close();
        }


        private void btnCadastrarAutor_Click_1(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => Application.Run(new CadastrarAutor()));
            thread.Start();
            this.Close();
        }

        private void btnConsultaAutor_Click(object sender, EventArgs e)
        {
            if (lbAutores.Visible)
            {
                lbAutores.Visible = false;
                btnConsultaAutor.Text = consultaAutorTxt;
            }
            else
            {
                autores.Clear();
                autores = new CadastrarAutor().autorList;

                lbAutores.Items.Clear();

                lbAutores.Items.AddRange(autores.ToArray());

                lbAutores.Visible = true;
                btnConsultaAutor.Text = "FECHAR AUTORES";
            }

        }

        private void lbAutores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dGVLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGVLivros_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => Application.Run(new CadastrarPessoa()));
            thread.Start();
            this.Close();
        }

        private void cbEmprestimo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmprestimo.SelectedIndex == 0)
            {
                Thread thread = new Thread(() => Application.Run(new EmprestarLivro()));
                thread.Start();
                this.Close();
            }

            if (cbEmprestimo.SelectedIndex == 1)
            {
                Thread thread = new Thread(() => Application.Run(new DevolverLivro()));
                thread.Start();
                this.Close();
            }

            if (cbEmprestimo.SelectedIndex == 2)
            {
                MessageBox.Show("Ai sim campeao");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
