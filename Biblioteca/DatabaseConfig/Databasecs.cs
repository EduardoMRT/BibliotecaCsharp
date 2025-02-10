using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DatabaseConfig
{
    internal static class Databasecs
    {

        public static string getSenhaBD()
        {
            string senha = Environment.GetEnvironmentVariable("SENHA_DO_BANCO_MYSQL");
            if (string.IsNullOrEmpty(senha))
            {
                throw new Exception("Senha não definida na váriavel de ambiente! Entre em contato com o suporte do sistema.");
            }
            else {
                return senha;
            }
        }

        public static MySqlConnection Conn()
        {
            try
            {
                string conexao = "Server=localhost; Database=biblio; Uid=root; Pwd=" + getSenhaBD() + ";";
                MySqlConnection conn = new MySqlConnection(conexao);
                conn.Open();
                return conn;
            }catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message);
                throw;
            }
        }

        public static void CloseConnection(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch 
            {
                MessageBox.Show("Erro ao tentar fechar a conexão!");
            }
        }

    }
}
