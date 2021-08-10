using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valorProduto1 = 10.10;
            double valorProduto2 = 20.20;
            double subTotal = 30.30;
            // se comprar o resultado com 30.30 o resultado é false pq ele entende como numero binario com resultado 30.2999997 e depois que arredonda se for impresso no console

            decimal materiaPrima = 10.1m;
            decimal maoDeObra = 20.2m;
            decimal custo = 30.3m;
            //nesse caso retorna como verdadeiro
            //moeda sempre utilizar decimal


        }
    }
}
