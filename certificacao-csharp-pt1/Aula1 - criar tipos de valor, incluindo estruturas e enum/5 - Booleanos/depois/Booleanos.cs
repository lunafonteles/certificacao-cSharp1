using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            bool possuiSaldo = true;
            int dias = DateTime.Now.Day;
            Console.WriteLine(dias);

            bool diasPar = (dias % 2 == 0);
            // % significa o resto da divisão

            if(diasPar)
            {
                Console.WriteLine("Numero de dias Par");
            } else
            {
                Console.WriteLine("Numero de dias Impar");
            }


        }
    }
}
