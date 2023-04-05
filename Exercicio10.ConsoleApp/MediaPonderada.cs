namespace Exercicio10.ConsoleApp
{
    internal class MediaPonderada
    {
        internal double notaUm;
        internal double notaDois;
        internal double pesoUm;
        internal double pesoDois;
        internal double media;
    
        internal double CalcularMediaPonderada()
        {
            return ((notaUm * pesoUm) + (notaDois * pesoDois)) / (pesoDois + pesoUm);
        }
    }

}
