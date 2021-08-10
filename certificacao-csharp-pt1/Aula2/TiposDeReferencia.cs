using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula2
{
    class TiposDeReferencia
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdade = idade;

            Console.WriteLine(idade);
            Console.WriteLine(copiaIdade);

            idade = 32;
            Console.WriteLine(idade);
            Console.WriteLine(copiaIdade);

            //em tipos de valor as variaveis sao idependentes (struct)
            //em tipos de referencia sao dependentes (classe)
        }


    }

//    struct Cliente
//    {
//        public Cliente(string nome, int idade)
//        {
//            Nome = nome;
//            idade = idade;
//        }

//        public string Nome { get; set; }
//        public int Idade { get; set; }

//        public override string

//    }
}
