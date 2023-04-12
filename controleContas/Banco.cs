using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Banco
    {
        public int Numero { get; set; }
        public string Nome { get; set; }

        public Banco(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
    }
}
