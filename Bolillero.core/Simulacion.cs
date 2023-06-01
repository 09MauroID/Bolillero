namespace Bolillero.core
{
    public class Simulacion 
    {
        public long simularSinHilos(Bolillerito clonoriginal, List<int> Jugada, int cantidad) 
            => clonoriginal.JugarNVeces(Jugada, cantidad);
    }
        public long simularConHilos(Bolillerito clonoriginal, List<int> Jugada, int cantidad, int cantHilos)
        {
            
            Task<long>[] cantSimul = new Task<long>[cantHilos];
            {
                for (int i = 0; i < cantidad; i++)
                {
                    var boli = clonoriginal.Clonar();
                    cantSimul[i] = Task<long>.Run(()=>(long)boli.clonoriginal);
                    
                }
            }
        }
}