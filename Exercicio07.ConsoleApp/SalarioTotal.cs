using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07.ConsoleApp
{
    internal class SalarioTotal
    {
        internal double salarioTotal;
        internal double salarioBase;
        internal double totalVendas;
        internal double percentual;
        internal double CalcularSalarioTotal()
        {
            return ((percentual / 100) * totalVendas) + salarioBase;
        }
    }
}
