namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada mediaPonderada = new MediaPonderada();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Formula  n1+n2+n3 / totalNota ====");
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite a primeira nota");
                mediaPonderada.notaUm = Convert.ToDouble(Console.ReadLine());
                while (mediaPonderada.notaUm > 10 || mediaPonderada.notaUm < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Nota um nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    mediaPonderada.notaUm = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite a segunda nota");
                mediaPonderada.notaDois = Convert.ToDouble(Console.ReadLine());
                while (mediaPonderada.notaDois > 10 || mediaPonderada.notaDois < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Nota dois nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    mediaPonderada.notaDois = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite o peso da primeira nota");
                mediaPonderada.pesoUm = Convert.ToDouble(Console.ReadLine());
                while (mediaPonderada.pesoUm > 10 || mediaPonderada.pesoUm < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Peso nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    mediaPonderada.pesoUm = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite o peso da segunda nota");
                mediaPonderada.pesoDois = Convert.ToDouble(Console.ReadLine());
                while (mediaPonderada.pesoDois > 10 || mediaPonderada.pesoDois < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Peso nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    mediaPonderada.pesoDois = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                mediaPonderada.media = mediaPonderada.CalcularMediaPonderada();
                mediaPonderada.media = Math.Round(mediaPonderada.media, 2);
                Console.WriteLine("Media é: " + mediaPonderada.media);
                Console.WriteLine("=======================================");
                Console.ReadLine();
            }
        }
    }
}