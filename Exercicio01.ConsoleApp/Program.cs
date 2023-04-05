namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Caixa caixa = new Caixa();
                Console.Clear();
                Console.WriteLine("==== Formula = L x A x C ========");
                Console.WriteLine("=================================");
                Console.WriteLine("Digite a largura do triangulo:");
                caixa.Largura = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=================================");
                Console.WriteLine("Digite a altura do triangulo:");
                caixa.Altura = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=================================");
                Console.WriteLine("Digite o comprimento do triangulo:");
                caixa.Comprimento = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("========== Volume ===============");
                double Volume = caixa.CalcularVolume();
                Console.WriteLine("Resultado: " + Volume);
                Console.WriteLine("=================================");
                Console.ReadLine();
            }
        }
    }
}