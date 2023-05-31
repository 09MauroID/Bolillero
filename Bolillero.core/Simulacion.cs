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
        public long simularConHilos(Bolillerito original, List<int> Jugada, int cantidad, int cantHilos)
        {
            
            Task<long>[] cantSimul = new Task<long>[cantHilos];
            {
                for (int i = 0; i < cantidad; i++)
                {
                    var boli = original.Clonar();

                    i = Jugada; cantSimul / cantHilos
                }
            }
        }
}