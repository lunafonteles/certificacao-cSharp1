using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula2
{
    class Delegate
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
        // delegate estatico
        delegate double metodoMultiplicacao(double input);

        class Calculadora
        {
            static double duplicar(double input)
            {
                return input * 2;
            }

            static double triplicar(double input)
            {
                return input * 3;
            }

            public static void Executar()
            {
                Console.WriteLine($"Duplicar 7,5: {duplicar(7.5)}");
                Console.WriteLine($"Triplicar 7,5: {triplicar(7.5)}");

                metodoMultiplicacao metodoMultiplicacao = duplicar;
                Console.WriteLine(metodoMultiplicacao(7.5));
                metodoMultiplicacao = triplicar;
                Console.WriteLine(metodoMultiplicacao(7.5));

                // delegate com metodo anonimo
                metodoMultiplicacao metodoQuadrado = delegate (double input)
                {
                    return input * input;
                };

                double quadrado = metodoQuadrado(5);
                Console.WriteLine("quadrado: {0}", quadrado);

                // delegate com expressao lambda
                metodoMultiplicacao metodoCubo = input => input * input * input;
                double cubo = metodoCubo(4.37);
            }


        }
    }
}
