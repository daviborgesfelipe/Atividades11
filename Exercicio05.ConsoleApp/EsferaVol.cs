using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.ConsoleApp
{
    internal class EsferaVol
    {
        internal double Raio;
        internal double Pi;
        internal double Volume;

        internal double CalcularVolumeEsfera()
        {
            Pi = Math.PI;
            Volume = Math.Pow(Raio, 3);
            Volume = Volume * Pi;
            return (4.0 / 3.0) * Volume;
        }
    }
}
