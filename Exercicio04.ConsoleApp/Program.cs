namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Media;
            while (true)
            {
                MediaKmPercorrido mediaKmPercorrido = new MediaKmPercorrido();
                Console.Clear();
                Console.WriteLine("==== Formula  Km/L ================");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a Quilometragem inicial");
                mediaKmPercorrido.InicioKm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a Quilometragem final");
                mediaKmPercorrido.FinalKm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a Quantidade de combustivel");
                mediaKmPercorrido.QntdCombustivel = Convert.ToDouble(Console.ReadLine());
                mediaKmPercorrido.PercorridoKm = mediaKmPercorrido.CalcularKmPercorrido();
                mediaKmPercorrido.Media = mediaKmPercorrido.CalcularMedia();
                Console.WriteLine("===================================");
                Console.WriteLine("Media: " + mediaKmPercorrido.Media + "Km/L");
                Console.WriteLine("Distancia percorrida: " + mediaKmPercorrido.PercorridoKm + "Km");
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}