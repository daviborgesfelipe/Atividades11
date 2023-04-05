using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09.ConsoleApp
{
    internal class MediaHarmonica
    {
        internal double notaUm;
        internal double notaDois;
        internal double notaTres;
        internal double media;
        internal double CalcularMediaHarmonica()
        {
            media = (notaUm + notaDois + notaTres) / 3;
            media = Math.Round(media, 2);
            return media;
        }
    }
}
