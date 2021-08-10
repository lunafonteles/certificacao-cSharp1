using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {

            diasDaSemana primeiroDia = diasDaSemana.seg;

            diasDeTrabalho diasDeTrabalho = diasDeTrabalho.ter | diasDeTrabalho.qui;

            Console.WriteLine(diasDeTrabalho);
           
        }
    }

    enum diasDaSemana : long { seg, ter, qua, qui, sex, sab, dom }
    //obs pode atribuir um valor especifico pra cada se quiser ou da primeira. caso nao atribuido conta a partir do 0
    //pode colocar sem os : 

    
    [Flags] //faz aparecer os nomes da enum nao os numeros
    enum diasDeTrabalho { seg = 0, ter = 1, qua = 2, qui = 4, sex = 8, sab = 16, dom = 32}
    //bits sempre o dobro do anterior
}
