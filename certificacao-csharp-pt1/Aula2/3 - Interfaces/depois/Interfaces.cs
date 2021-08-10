using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula2
{
    class Interfaces
    {
        public void Executar()
        {
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();
            eletro1 = new Abajur();

        }

        interface IEletrodomestico
        {
            void Ligar();
            void Desligar();
        }

        interface IIluminacao
        {
            double PotenciaDaLampada { get; set; }
        }

        class Televisao : IEletrodomestico
        {
            public void Ligar() { }
            public void Desligar() { }
        }


        class Abajur : IEletrodomestico, IIluminacao
        {
            public double PotenciaDaLampada { get; set; }
            public void Ligar() { }
            public void Desligar() { }
        }

        class Lanterna : IEletrodomestico, IIluminacao
        {
            public double PotenciaDaLampada { get; set; }
            public void Ligar() { }
            public void Desligar() { }
        }

        class Radio : IEletrodomestico
        {
            public void Ligar() { }
            public void Desligar() { }
        }
    }
}
