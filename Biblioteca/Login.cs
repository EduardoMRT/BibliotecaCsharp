using Biblioteca.DatabaseConfig;
using Biblioteca.domain;
using Biblioteca.Forms;
using Biblioteca.util;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void chamaInicio()
        {
            var th = new Thread(() => Application.Run(new Iniciocs()));
            th.Start();
            this.Close();
        }

        private void login(string usuario, string senha)
        {
            using (MySqlConnection conn = Databasecs.Conn())
            {
                try
                {
                    string sql = "SELECT 1 FROM usuario u WHERE u.usuario = @usuario AND u.senha = @senha";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", new CriptografiaUtil(senha).criptografa());
                    if (command.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Logado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Usuario.UsuarioNome = usuario;
                        chamaInicio();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválida!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar entrar no sistema\nEntre em contato com o suporte!\n" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            try
            {
                login(usuario, senha);
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro inesperado! \nEntre em contato com o suporte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkNaoTemConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var th = new Thread(() => Application.Run(new criaUsuario()));
            th.Start();
            this.Close();
        }
    }
}
