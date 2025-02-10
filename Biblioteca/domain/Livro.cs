using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.domain
{
    internal class Livro
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string autor { get; set; }
        public int idUsuario { get; set; }
        public string situacao { get; set; }
        public DateTime data_Emprestimo { get; set; }
        public DateTime data_Devolucao { get; set; }
    }
}
