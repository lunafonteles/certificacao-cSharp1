using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 30;
            Console.WriteLine(idade);

            int copiaIdade = idade;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 23;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            int? idade2 = null;
            //pode colocar null alem de inteiro
            //mesma coisa seria system.Nullable<int> idade2 = null;

        }
    }
}
