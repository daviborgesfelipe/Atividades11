namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Cilindro cilindro = new Cilindro();
                Console.Clear();
                Console.WriteLine("==== Formula  V = pi * r^2 * a ====");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o raio do cilindro");
                cilindro.Raio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o altura do cilindro");
                cilindro.Altura = Convert.ToDouble(Console.ReadLine());
                double volume = cilindro.CalcularVolume();
                volume = Math.Round(volume, 3);
                Console.WriteLine("===================================");
                Console.WriteLine("Volume é: " + volume);
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}