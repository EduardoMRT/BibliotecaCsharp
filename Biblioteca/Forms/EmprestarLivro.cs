using Biblioteca.DatabaseConfig;
using Biblioteca.domain;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class EmprestarLivro : Form
    {
        public EmprestarLivro()
        {
            InitializeComponent();
            mascara();
            livros = retornaLivros();
            livrosNome = nomeLivro();
            cbLivro.Items.Clear();
            cbLivro.Items.AddRange(livrosNome.ToArray());
            txtDataEmprestimo.Text = dataHoje.ToString();
            txtDataDevolucao.Text = dataHoje.AddDays(7).ToString();
        }

        public void mascara()
        {
            txtCPF.Mask = "999,999,999-99";
            txtDataDevolucao.Mask = "99/99/9999";
            txtDataEmprestimo.Mask = "99/99/9999";
        }

        private List<Pessoa> PessoaList = new List<Pessoa>();
        private List<Livro> livros = new List<Livro>();
        private List<String> livrosNome = new List<String>();
        private DateTime dataHoje = DateTime.Now;

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

        private List<Livro> retornaLivros()
        {
            try
            {
                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "SELECT * FROM livros WHERE situacao != 'EMPRESTADO'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
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
                        livro.data_Devolucao = reader.IsDBNull(6) ? new DateTime() : reader.GetDateTime(6);
                        livros.Add(livro);
                    }
                    return livros;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os livros\nPor favor entre em contato com o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => Application.Run(new Iniciocs()));
            thread.Start();
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
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

        private void cbLivro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbLivro_KeyUp(object sender, KeyEventArgs e)
        {
            string textoDigitado = cbLivro.Text.ToLower();

            if (cbLivro.Tag == null)
            {
                cbLivro.Tag = new List<string>(cbLivro.Items.Cast<string>());
            }
            List<string> livrosOriginais = (List<string>)cbLivro.Tag;
            cbLivro.Items.Clear();

            foreach (string livro in livrosOriginais)
            {
                if (livro.ToLower().Contains(textoDigitado))
                {
                    cbLivro.Items.Add(livro);
                }
            }

            cbLivro.DroppedDown = true;
            cbLivro.SelectionStart = textoDigitado.Length;
            cbLivro.SelectionLength = 0;
        }

        private void txtDataEmprestimo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtDataEmprestimo.Text.Length >= 10)
                {
                    DateTime dataEmprestimo = DateTime.Parse(txtDataEmprestimo.Text);
                    if (dataEmprestimo > dataHoje.AddDays(7) || dataEmprestimo < dataHoje.AddDays(-7))
                    {
                        txtDataEmprestimo.Text = dataHoje.ToString();
                        throw new Exception("O intervalo máximo permitido é de 7 dias para a data de empréstimo!");
                    }

                    DateTime dataDevolucao = dataEmprestimo.AddDays(7);
                    txtDataDevolucao.Text = dataDevolucao.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private Livro? retornaLivroPorNome()
        {
            foreach (Livro livro in livros)
            {
                if (!livro.situacao.Equals("EMPRESTADO") && livro.nome.Equals(cbLivro.Text))
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

                    string sql = "UPDATE livros SET data_Emprestimo = @data_Emprestimo, data_Devolucao = @data_Devolucao, situacao = @situacao, idUsuario = @idUsuario WHERE id = @id AND situacao != 'EMPRESTADO'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@data_Emprestimo", DateTime.Parse(txtDataEmprestimo.Text));
                    cmd.Parameters.AddWithValue("@data_Devolucao", DateTime.Parse(txtDataDevolucao.Text));
                    cmd.Parameters.AddWithValue("@situacao", "EMPRESTADO");

                    var livro = retornaLivroPorNome();
                    if (livro == null || livro.id == 0)
                    {
                        MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@id", livro.id);

                    var pessoa = retornaPessoaPorCPF(txtCPF.Text);
                    if (pessoa == null || pessoa.Id == 0)
                    {
                        MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cmd.Parameters.AddWithValue("@idUsuario", pessoa.Id);

                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Empréstimo realizado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Falha desconhecida ao tentar emprestar o livro, entre em contato com o suporte!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void EmprestarLivro_Load(object sender, EventArgs e)
        {

        }

        private void cbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
