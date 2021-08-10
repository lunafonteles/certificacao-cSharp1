using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas");
            clienteEspecial.FazerPedido(1, "Residencial", 1);
            Console.WriteLine();

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial");
            clienteEspecial.FazerPedido(1, quantidade: 4);

            
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "anonimo")
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId, string endereco = "residencial", int quantidade = 1)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
        //parametros opcionais devem estar depois de todos obrigatorios
    }
}
