using System;

namespace CalculadoraDistancia
{
    class Program
    {
        public const double latTarget = -22.97370561481047;
        public const double lonTarget = -43.371087640278084;
        private static double Haversine(double lat1, double lat2, double lon1, double lon2)
        {
            const double r = 6335.439; // kms

            var sdlat = Math.Sin((lat2 - lat1) / 2);
            var sdlon = Math.Sin((lon2 - lon1) / 2);
            var q = sdlat * sdlat + Math.Cos(lat1) * Math.Cos(lat2) * sdlon * sdlon;
            var d = 2 * r * Math.Asin(Math.Sqrt(q));
            Console.WriteLine($"Estou na target?: {EstouNaTarget(d)}");
            return d;
        }
        private static bool EstouNaTarget(double distancia)
        {
            return distancia <= 5;
    
        }
        private static double Teste(double lat, double lon)
        {
            return Haversine(latTarget, lat, lon, lonTarget);
        }
        static void Main(string[] args)
        {
            //target
          

            
            //alvo perto da target
            var alvopertotargetlat = -22.96972149961419;
            var alvopertotargetlon = -43.37026653077708;
            Console.WriteLine($"Resultado alvo perto target: {Teste(alvopertotargetlat, alvopertotargetlon)}");

 
            // nova iguaçu - três corações
            Console.WriteLine($"Resultado nova iguaçu: {Teste(-22.716778822235323, -43.46185375760112)}");
            // resultado perto da target
            Console.WriteLine($"Resultado perto da target: {Teste(-22.97372778381012, -43.37089859703066)}");


        }
    }
}
