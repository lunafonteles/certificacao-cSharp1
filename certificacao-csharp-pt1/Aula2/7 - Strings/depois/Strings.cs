using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula2
{
    class Strings
    {
        public void Executar()
        {
            string a = "bom dia";
            string b = "b";
            b += "om dia";
            Console.WriteLine($"a == b: { a == b}");
            Console.WriteLine($"(object)a == (object)b: { (object)a == (object)b}");

            string bomDia = "bom dia";
            Console.WriteLine($"bomDia(4): {bomDia[4]}");

            var caractere = bomDia[4];
            Console.WriteLine(caractere.GetType());

        }
    }
}
