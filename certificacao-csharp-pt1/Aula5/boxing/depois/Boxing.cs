using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;
            object caixa = numero; //boxing
            Console.WriteLine(string.Concat("resposta", numero, true));

            try
            {
                int unboxed = (int)caixa;
                System.Console.WriteLine("Unboxing ok");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Erro: unboxing incorreto", e);
            }
        }
    }
}
