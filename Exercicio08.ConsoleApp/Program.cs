namespace Exercicio08.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                LataOleo lataOleo = new LataOleo();
                Console.Clear();
                Console.WriteLine("==== Formula  V = pi * r^2 * a ====");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o altura do cilindro");
                lataOleo.Altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("===================================");
                Console.WriteLine("Digite o diametro do cilindro");
                lataOleo.Diametro = Convert.ToDouble(Console.ReadLine());
                lataOleo.Raio = lataOleo.Diametro / 2;
                lataOleo.Volume = lataOleo.CalcularVolume();
                lataOleo.Volume = Math.Round(lataOleo.Volume, 2);
                Console.WriteLine("===================================");
                Console.WriteLine("Volume é: " + lataOleo.Volume + "cm^3");
                lataOleo.Volume = lataOleo.Volume / 1000;
                lataOleo.Volume = Math.Round(lataOleo.ConverterParaLitros());
                Console.WriteLine("Volume é: " + lataOleo.Volume + "L");
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}