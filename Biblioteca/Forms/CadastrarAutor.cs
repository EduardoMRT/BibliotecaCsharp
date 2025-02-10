using Biblioteca.DatabaseConfig;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class CadastrarAutor : Form
    {
        public CadastrarAutor()
        {
            InitializeComponent();
            autorList.Clear();
            autorList = retornaAutores();
            
        }

       

        public List<string> autorList = new List<string>();

        public List<string> retornaAutores()
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
                string autor = txtNome.Text;
                if (string.IsNullOrEmpty(autor) || autor == null)
                {
                    throw new Exception("Você deve inserir um nome.");
                }
                if (autorList.Contains(autor))
                {
                    throw new Exception("O autor já está cadastrado.");
                }
                using(MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "INSERT INTO autor(nome) VALUES(@nome)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", autor);
                    if(cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Autor cadastrado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        autorList = retornaAutores();
                    }
                    else
                    {
                        throw new Exception("Ocorreu um erro ao tentar cadastrar o autor.\nPor favor, entre em contato com o suporte!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
