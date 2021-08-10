using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15; //System.Int32
            
            char resposta = 'S'; //System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal, nao pode ser negativo, 1 byte
            sbyte nivelDeBrilho = -127; //System.Sbyte aceita negativo
            short passageiroVoo = -7; //System.Int16
            long populacaoBrasil = 200_660_929; // +/- 207 milhoes, System.Int64
            ushort passageiroNavio = 230;//System.UInt16, inteiro curto unsined
            uint estoque = 1500;//System.UInt32
            ulong populacaoDoMundo = 7_000_000_000;//7 bilhoes, System.Int64


        }
    }
}
