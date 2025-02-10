using Biblioteca.DatabaseConfig;
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
    public partial class CadastrarLivro : Form
    {
        public CadastrarLivro()
        {
            InitializeComponent();
            autorList.Clear();
            autorList = retornaAutores();
            cbAutor.Items.Clear();
            cbAutor.Items.AddRange(autorList.ToArray());
        }

        private List<string> autorList = new List<string>();

        private List<string> retornaAutores()
        {
            try
            {
                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "SELECT nome FROM autor ORDER BY nome ASC";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        autorList.Add(reader.GetString(0));
                    }
                    return autorList;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao carregar os autores!\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeLivro = txtNome.Text;
                string autor = cbAutor.Text;

                if (autor == null || string.IsNullOrEmpty(autor))
                {
                    throw new Exception("Escolha um autor");
                }

                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "INSERT INTO livros(nome, autor) VALUES(@nome, @autor)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nomeLivro);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Livro cadastrado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar cadastrar o livro! \nPor favor, entre em contato com o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => Application.Run(new Iniciocs()));
            thread.Start();
            this.Close();
        }
    }
}
