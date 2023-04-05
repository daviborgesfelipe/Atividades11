namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica mediaHarmonica = new MediaHarmonica();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Formula  n1+n2+n3 / totalNota ====");
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite a primeira nota");
                mediaHarmonica.notaUm = Convert.ToDouble(Console.ReadLine());
                while (mediaHarmonica.notaUm > 10 || mediaHarmonica.notaUm < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Nota um nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    mediaHarmonica.notaUm = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                ;
                Console.WriteLine("Digite a segunda nota");
                mediaHarmonica.notaDois = Convert.ToDouble(Console.ReadLine());
                while (mediaHarmonica.notaDois > 10 || mediaHarmonica.notaDois < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Nota dois nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    mediaHarmonica.notaDois = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite a terceira nota");
                mediaHarmonica.notaTres = Convert.ToDouble(Console.ReadLine());
                while (mediaHarmonica.notaTres > 10 || mediaHarmonica.notaTres < 0)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Nota tres nao pode ser maior que 10 ou menor que 0");
                    Console.WriteLine("=======================================");
                    mediaHarmonica.notaTres = Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                Console.WriteLine("=======================================");
                mediaHarmonica.media = mediaHarmonica.CalcularMediaHarmonica();
                mediaHarmonica.media = Math.Round(mediaHarmonica.media, 2);
                Console.WriteLine("Media é: " + mediaHarmonica.media);
                Console.WriteLine("=======================================");
                Console.ReadLine();
            }
        }
    }
}