using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;
            Console.WriteLine("Volume do cubo: " + volume(lado));

            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;
            Console.WriteLine("Volume do cilindro: " + volume(altura, raio));

            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine("Volume do prisma: " + volume(largura, profundidade, altura));
        }

        double volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        double volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
        //sobrecarga deixa usar mesmo nome do metodo se variar os parametros por nome ou tipo
    }
}
