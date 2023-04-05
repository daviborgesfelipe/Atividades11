using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.ConsoleApp
{
    internal class Cilindro
    {
        internal double Raio;
        internal double Altura;

        internal double CalcularVolume()
        {
            return Math.PI* Math.Pow(Raio, 2) * Altura;
        }
    }
}
