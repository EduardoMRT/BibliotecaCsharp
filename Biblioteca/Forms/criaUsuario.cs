using Biblioteca.DatabaseConfig;
using Biblioteca.util;
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
    public partial class criaUsuario : Form
    {
        public criaUsuario()
        {
            InitializeComponent();
            txtCSenha.PasswordChar = '*';
            txtSenha.PasswordChar = '*';
            usuarios = usuariosAtuais();
        }

        private List<string> usuarios = new List<string>();
        private Color defaultTextColor = new Color();

        private List<string> usuariosAtuais()
        {
            using (MySqlConnection conn = Databasecs.Conn())
            {
                try
                {
                    string sql = "SELECT usuario, senha FROM usuario";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        usuarios.Add(reader.GetString(0).ToString());
                    }
                    return usuarios;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar os usuários\nPor favor entre em contato com o suporte!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private bool verificaSenhas()
        {
            if (txtSenha.Text.Equals(txtCSenha.Text, StringComparison.Ordinal))
            {
                return true;
            }
            else
            {
                MessageBox.Show("O campo senha e confirmar senha devem ser iguais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                defaultTextColor = txtSenha.BackColor;
                txtSenha.BackColor = Color.Red;
                txtCSenha.BackColor = Color.Red;
                return false;
            }
        }

        private void cadastraUsuario(string senha)
        {
            string sql = "INSERT INTO usuario(usuario, senha) VALUES (@usuario, @senha)";
            using (MySqlConnection conn = Databasecs.Conn())
            {
                string usuario = txtUsuario.Text;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o usuário, entre em contato com o suporte!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception e)
                {
                       MessageBox.Show($"Ocorreu um erro ao tentar cadastrar o usuário, entre em contato com o suporte!\n Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private string criptografaSenha(string senha)
        {
            return new CriptografiaUtil(senha).criptografa();
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != null && !string.IsNullOrEmpty(txtUsuario.Text))
            {
                if (usuarios.Contains(txtUsuario.Text))
                {
                    MessageBox.Show("Nome de usuário já utilizado, escolha outro");
                }
                else
                {
                    if (verificaSenhas())
                    {
                        cadastraUsuario(criptografaSenha(txtSenha.Text));
                    }
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSenha_TextChanged(Object sender, EventArgs e)
        {

            if (txtSenha.BackColor == Color.Red)
            {
                txtSenha.BackColor = defaultTextColor;
                txtCSenha.BackColor = defaultTextColor;
                txtCSenha.Clear();
                txtSenha.Clear();
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => Application.Run(new Login()));
            thread.Start();
            this.Close(); 
        }
    }
}
