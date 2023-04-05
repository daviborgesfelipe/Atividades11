using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06.ConsoleApp
{
    internal class Celsius
    {
        internal double Graus;
        internal double ConverterParaFarenheit()
        {
            return (Graus - 1.8) + 32;
        }
    }
}
