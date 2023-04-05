using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    internal class LataOleo
    {
        internal double Altura;
        internal double Diametro;
        internal double Raio;
        internal double Volume;
        internal double CalcularVolume()
        {
            return Math.PI * Math.Pow(Raio, 2) * Altura;
        }
        internal double ConverterParaLitros() 
        {
            return Volume / 1000;
        }
    }
}
