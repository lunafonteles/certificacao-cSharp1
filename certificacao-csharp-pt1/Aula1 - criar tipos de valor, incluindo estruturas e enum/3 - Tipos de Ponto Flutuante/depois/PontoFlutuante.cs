using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace certificacao_csharp_roteiro.antes
{
    class PontoFlutuante
    {
        public void Executar()
        {
            float idade;
            idade = 15.5f;

            float massaDaTerra = 5.9736e24f; //e = elevado, System.Single
            Console.WriteLine("MinValue: " + long.MinValue);

            //float numeroMuitoMaior = 6e100;
            Double numeroMuitoMaior = 6e100;

            int x = 5;
            short y = 2;
            var resultado = x * y;
            Console.WriteLine("x * y" + resultado);
            //  Console.WriteLine(resultado.GetType); sempre se torna o q tem mais bytes

        }
    }
}
