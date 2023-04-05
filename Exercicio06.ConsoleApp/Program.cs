namespace Exercicio06.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Celsius celsius = new Celsius();
                Console.Clear();
                Console.WriteLine("======  °F = (20 x 1,8) + 32 ======");
                Console.WriteLine("===================================");
                Console.WriteLine("Digite a temperatura em Celsius");
                celsius.Graus = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = celsius.ConverterParaFarenheit();
                fahrenheit = Math.Round(fahrenheit, 2);
                Console.WriteLine("===================================");
                Console.WriteLine(celsius.Graus + "°C é o mesmo que " + fahrenheit + "°F");
                Console.WriteLine("===================================");
                Console.ReadLine();
            }
        }
    }
}