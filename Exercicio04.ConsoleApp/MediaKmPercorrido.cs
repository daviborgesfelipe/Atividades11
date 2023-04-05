namespace Exercicio04.ConsoleApp
{
    internal class MediaKmPercorrido
    {
        internal double InicioKm;
        internal double FinalKm;
        internal double QntdCombustivel;
        internal double PercorridoKm;
        internal double Media;
        internal double CalcularKmPercorrido()
        {
            return FinalKm - InicioKm;
        }
        internal double CalcularMedia()
        {
            return PercorridoKm / QntdCombustivel;
        }
    }
}
