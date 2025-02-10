using Biblioteca.DatabaseConfig;
using Biblioteca.domain;
using iText.Forms.Fields.Merging;
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
    public partial class CadastrarPessoa : Form
    {
        public CadastrarPessoa()
        {
            InitializeComponent();
            PessoaList.Clear();
            PessoaList = retornaPessoas();
            txtCPF.Mask = "999,999,999-99";
            txtCEP.Mask = "99999-999";
            txtTelefone.Mask = "(99) 99999-9999";
        }

        private List<Pessoa> PessoaList = new List<Pessoa>();

        private List<Pessoa> retornaPessoas()
        {
            try
            {
                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "SELECT * FROM pessoa ORDER BY nome ASC";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();
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

        private Pessoa criaPessoa()
        {
            string cpf = txtCPF.Text;
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string cep = txtCEP.Text;
            string numeroCasa = txtNCasa.Text;

            return new Pessoa(1, nome, sobrenome, cpf, telefone, email, cep, numeroCasa);
        }

        public void verificaEmail()
        {
            if (!txtEmail.Text.Contains('@'))
            {
                throw new Exception("Insira um email válido!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                verificaEmail();

                Pessoa pessoa = criaPessoa();
                if (pessoa == null)
                {
                    throw new Exception("Você precisa digitar os dados da pessoa.");
                }

                using (MySqlConnection conn = Databasecs.Conn())
                {
                    string sql = "INSERT INTO pessoa(nome, sobrenome, CEP, email, telefone, cpf, numeroCasa) VALUES(@nome, @sobrenome, @CEP, @email, @telefone, @cpf, @numeroCasa)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@sobrenome", pessoa.Sobrenome);
                    cmd.Parameters.AddWithValue("@CEP", pessoa.CEP);
                    cmd.Parameters.AddWithValue("@email", pessoa.Email);
                    cmd.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                    cmd.Parameters.AddWithValue("@cpf", pessoa.CPF);
                    cmd.Parameters.AddWithValue("@numeroCasa", pessoa.NumeroCasa);

                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Pessoa cadastrada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Erro ao tentar salvar a pessoa!");
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nPor favor entre em contato com o suporte.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
