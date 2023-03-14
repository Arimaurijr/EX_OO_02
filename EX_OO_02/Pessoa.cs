using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_OO_02
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public Pessoa(string nome, string telefone, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return (Nome + " - " + Telefone + " - " + Endereco);
        }
    }
}
