using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bolillero.core
{
    public class Simulacion 
    {
        public long simularSinHilos(Bolillerito original, List<int> Jugada, int cantidad) 
            => original.JugarNVeces(Jugada, cantidad);
    }
}