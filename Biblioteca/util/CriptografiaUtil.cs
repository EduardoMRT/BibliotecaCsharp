using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.util
{


    class CriptografiaUtil
    {

        public string texto { get; set; }

        public CriptografiaUtil(string textoRecebido) 
        { 
            texto = textoRecebido;
        }   

        public string criptografa()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }


}
