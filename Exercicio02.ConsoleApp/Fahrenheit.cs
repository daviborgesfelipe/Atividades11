using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.ConsoleApp
{
    internal class Fahrenheit
    {
        internal double graus;

        internal double ConverterParaCelsius()
        {
            return (graus - 32) * 5 / 9;
        }
    }
}
