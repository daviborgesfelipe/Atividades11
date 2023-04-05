namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Fahrenheit fahrenheit = new Fahrenheit();
                Console.Clear();
                Console.WriteLine("==== Formula (°F - 32) * 5 / 9 ====");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a temperatura em Fahrenheit");
                fahrenheit.graus = Convert.ToDouble(Console.ReadLine());
                double celsius = fahrenheit.ConverterParaCelsius();
                celsius = Math.Round(celsius, 2);
                Console.WriteLine("===================================");
                Console.WriteLine(fahrenheit.graus + "°F é o mesmo que " + celsius + "°C");
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}