using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            ImprimirDetalhesDoPedido("Maria de Fatima", 31, "Caneca vermelha");
            //assim tem q ser na ordem correta

            ImprimirDetalhesDoPedido(numeroPedido: 31, vendedor: "Maria de Fatima", nomeProduto: "Caneca vermelha");
            //parametros nomeados deixa colocar em qualquer ordem

            ImprimirDetalhesDoPedido("Maria de Fatima", 31, nomeProduto: "Caneca vermelha");
            //misturados so se for na ordem correta? nao faz sentido
        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
            {
                throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio.", paramName: nameof(vendedor));
            }

            Console.WriteLine($"Vendedor: {vendedor}, Pedido No.: {numeroPedido}, Produto: {nomeProduto}");
        }
    }
}
