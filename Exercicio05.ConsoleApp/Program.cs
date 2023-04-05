namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                EsferaVol esferaVol = new EsferaVol();
                Console.Clear();
                Console.WriteLine("==== Formula (4/3) * π * r^3 ======");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o raio: ");
                esferaVol.Raio = Convert.ToDouble(Console.ReadLine());
                esferaVol.Volume = esferaVol.CalcularVolumeEsfera();
                esferaVol.Volume = Math.Round(esferaVol.Volume, 2);
                Console.WriteLine("===================================");
                Console.WriteLine("O volume é: " + esferaVol.Volume);
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}