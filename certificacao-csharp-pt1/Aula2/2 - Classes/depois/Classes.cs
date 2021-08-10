using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula2
{
    class Classes
    {
        public void Executar()
        {
            ClasseposicaoGPS posicao1 = new ClasseposicaoGPS()
            { Latitude = 13.78, Longitude = 29.51 };

            posicao1 = new ClasseposicaoGPS(13.78, 29.51);
            Console.WriteLine(posicao1);

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(13.78, 29.51, DateTime.Now);
            Console.WriteLine(posicao2);
        }
    }

    class ClasseposicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public ClasseposicaoGPS() { }

        public ClasseposicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool estarNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";

        }

    }

    class PosicaoGPSComLeitura : ClasseposicaoGPS
    {
        private readonly DateTime dataLeitura;

        public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude, longitude)
        {
            this.dataLeitura = dataLeitura;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}, Data Leitura {dataLeitura}";

        }
    }
}
