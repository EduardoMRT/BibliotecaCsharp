using Biblioteca.DatabaseConfig;
using Biblioteca.domain;
using iText.StyledXmlParser.Jsoup.Nodes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class DevolverLivro : Form
    {
        public DevolverLivro()
        {
            InitializeComponent();
            mascara();
            livrosNome.Clear();
        }

        public void mascara()
        {
            txtCPF.Mask = "999,999,999-99";
        }


        private List<Livro> livros = new List<Livro>();
        private List<Pessoa> PessoaList = new List<Pessoa>();
        private List<String> livrosNome = new List<String>();

        private List<String> nomeLivro()
        {
            try
            {
                List<String> nomesLivrosList = new List<String>();
                foreach (Livro livro in livros)
                {
                    nomesLivrosList.Add(livro.nome);
                }
                return nomesLivrosList;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os nomes dos livros\nPor favor entre em contato com o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private List<Livro> retornaLivrosEmprestados()
        {
            try
            {
                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "SELECT l.* FROM biblio.livros l, biblio.pessoa p WHERE p.cpf = @cpf AND p.id = l.idUsuario";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Livro livro = new Livro();
                        livro.id = reader.GetInt32(0);
                        livro.nome = reader.GetString(1);
                        livro.autor = reader.GetString(2);
                        livro.idUsuario = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        livro.situacao = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        livro.data_Emprestimo = reader.IsDBNull(5) ? new DateTime() : reader.GetDateTime(5);
                        livro.data_Devolucao = reader.IsDBNull(5) ? new DateTime() : reader.GetDateTime(6);
                        livros.Add(livro);
                    }
                }
                return livros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Pessoa? retornaPessoaPorCPF(string cpf)
        {
            foreach (Pessoa pessoa in PessoaList)
            {
                if (pessoa.CPF.Equals(cpf))
                {
                    return pessoa;
                }
            }
            return null;
        }

        private Livro? retornaLivroPorNome()
        {
            foreach (Livro livro in livros)
            {

                if (livro.nome.Equals(cbLivro.Text))
                {
                    return livro;
                }
            }
            return null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "UPDATE livros SET data_Emprestimo = @data_Emprestimo, data_Devolucao = @data_Devolucao, situacao = @situacao, idUsuario = @idUsuario WHERE id = @id AND situacao = 'EMPRESTADO'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@data_Emprestimo", DBNull.Value);
                    cmd.Parameters.AddWithValue("@data_Devolucao", DBNull.Value);

                    var livro = retornaLivroPorNome();

                    cmd.Parameters.AddWithValue("@id", livro.id);

                    var pessoa = retornaPessoaPorCPF(txtCPF.Text);
                    if (pessoa == null || pessoa.Id == 0)
                    {
                        MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@idUsuario", DBNull.Value);
                    cmd.Parameters.AddWithValue("@situacao", "DISPONIVEL");

                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Devolução realizada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetaLivros();
                    }
                    else
                    {
                        throw new Exception("Falha desconhecida ao tentar devolver o livro, entre em contato com o suporte!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private List<Pessoa> pesquisaPessoa()
        {
            try
            {
                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "SELECT * FROM pessoa WHERE cpf = @cpf ORDER BY nome ASC LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    var reader = cmd.ExecuteReader();
                    Console.WriteLine("SQL: " + cmd.CommandText);
                    while (reader.Read())
                    {
                        Pessoa pessoa = new Pessoa();
                        pessoa.Id = reader.GetInt32(0);
                        pessoa.Nome = reader.GetString(1);
                        pessoa.Sobrenome = reader.GetString(2);
                        pessoa.CEP = reader.GetString(3);
                        pessoa.Email = reader.GetString(4);
                        pessoa.Telefone = reader.GetString(5);
                        pessoa.CPF = reader.GetString(6);
                        pessoa.NumeroCasa = reader.GetString(7);
                        PessoaList.Add(pessoa);
                    }
                    return PessoaList;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao tentar cadastrar o usuário\nPor favor entre em contato com o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnVoltar_Click(Object sender, EventArgs e)
        {
            Thread thread = new Thread(() => Application.Run(new Iniciocs()));
            thread.Start();
            this.Close();
        }

        private void resetaLivros()
        {
            livros.Clear();
            livros = retornaLivrosEmprestados();
            livrosNome.Clear();
            livrosNome = nomeLivro();
            cbLivro.Items.Clear();
            cbLivro.Items.AddRange(livrosNome.ToArray());
            cbLivro.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                resetaLivros();
                Pessoa pessoa = pesquisaPessoa().FirstOrDefault();
                if (pessoa == null)
                {
                    throw new Exception("Não existe nenhum cadastro com esse CPF");
                }
                txtNome.Text = pessoa.Nome + " " + pessoa.Sobrenome;
                txtNome.Visible = true;
                lblNome.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string dataDevolucaoStr = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"); //Para evitar passar a hora

                    string sql = "UPDATE livros SET data_Devolucao = @data_Devolucao WHERE id = @id AND situacao = 'EMPRESTADO'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@data_Devolucao", DateTime.Parse(dataDevolucaoStr));

                    Livro? livro = retornaLivroPorNome();
                    int? id = livro != null ? livro.id : null;

                    cmd.Parameters.AddWithValue("@id", id.HasValue ? id.Value : 0);

                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show($"Renovação realizada com sucesso! \n Nova data de devolução: {dataDevolucaoStr}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Falha desconhecida ao tentar devolver o livro, entre em contato com o suporte!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }

}
