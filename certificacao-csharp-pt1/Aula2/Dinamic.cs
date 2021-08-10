using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula2
{
    class Dinamic
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto = objeto + 3;

            dynamic dinamico = 1;
            dinamico = dinamico + 3;
            Console.WriteLine(dinamico);

        }
    }
}
