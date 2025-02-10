using System;

namespace Biblioteca.domain
{
    static class Usuario
    {
        private static int _id;
        private static string _usuario;
        private static string _senha;

        public static int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public static string UsuarioNome
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public static string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        static Usuario()
        {
            _id = 0;
            _usuario = "default";
            _senha = "default";
        }
    }
}
