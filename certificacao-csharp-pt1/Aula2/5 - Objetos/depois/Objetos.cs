using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula2
{
    class Objetos
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"Pontuação {pontuacao}");

            object meuObjeto = pontuacao;
            Console.WriteLine(meuObjeto);
            Console.WriteLine(meuObjeto.GetType());

            meuObjeto = new jogador();
            jogador classRef;
            classRef = (jogador)meuObjeto;
            //conversao explicita ou cast

            Console.WriteLine(classRef.Pontuacao);
        }
    }

    class jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}

