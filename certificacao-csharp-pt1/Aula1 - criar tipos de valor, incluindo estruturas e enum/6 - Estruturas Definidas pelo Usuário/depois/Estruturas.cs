using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            posicaoGPS posicao1;
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;

            //posicao1 = new posicaoGPS() { Latitude = 13.78, Longitude = 29.51 };
            posicao1 = new posicaoGPS(13.78, 29.51);
        }
    }

    interface IGPS
    {
        bool estarNoHemisferioNorte();
    } 

    struct posicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public posicaoGPS(double latitude, double longitude)
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
        //estrutura nao permite herança de outras estruturas
    }
}
