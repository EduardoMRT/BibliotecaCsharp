using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.domain
{
    internal class Pessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public  string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string NumeroCasa { get; set; }


        public Pessoa(int id, string nome, string sobrenome, string cpf, string telefone, string email, string cep, string numeroCasa)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            CEP = cep;
            NumeroCasa = numeroCasa;
        }

        public Pessoa() { }

    }
}
