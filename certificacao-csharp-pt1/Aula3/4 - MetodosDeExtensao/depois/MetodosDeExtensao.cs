using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Este é\r\no meu documento");
            impressora.ImprimirDocumento();
            ImprimirDocumentoHTML(impressora.Documento);
            impressora.ImprimirDocumentoHTML();

            //metodo de extensao é uma forma de usar método como se fosse parte de uma classe
        }

        void ImprimirDocumentoHTML(string documento)
        {
            Console.WriteLine($"<html><body>{documento}</body></html>");
        }

    }

    class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }
    }

    static class ImpressoraExtensions
    {
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
        //extendendo classe impressora para o metodo imprimir html
    }
        
}




