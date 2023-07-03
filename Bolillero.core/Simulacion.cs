namespace Bolillero.core;

public class Simulacion 
{
    public long simularSinHilos(Bolillerito clonoriginal, List<int> Jugada, int cantidad) 
        => clonoriginal.JugarNVeces(Jugada, cantidad);

    public long simularConHilos(Bolillerito original, List<int> Jugada, int cantidad, int cantHilos)
    {
        var cantProcesos = cantidad / cantHilos;
        Task<long>[] cantSimul = new Task<long>[cantHilos];
        
        for (int i = 0; i < cantidad; i++)
        {
            var boli = original.Clonar();
            cantSimul[i] = Task<long>.Run(()=>(long)boli.JugarNVeces(Jugada, cantProcesos));
        }
        Task<long>.WaitAll(cantSimul);
        return cantSimul.Sum(c => c.Result);
    }
    static async Task<long> simularConHilosAsync(Bolillerito original, List<int> Jugada, int cantidad, int cantHilos)
    {
        var cantProcesos = cantidad / cantHilos;
        Task<long>[] cantSimul = new Task<long>[cantHilos];

        for (int i = 0; i < cantidad; i++)
        {
            var boli = original.Clonar();
            cantSimul[i] = Task<long>.Run(()=>(long)boli.JugarNVeces(Jugada, cantProcesos));
        }
        await Task<long>.WhenAll(cantSimul);
        return cantSimul.Sum(c => c.Result);
    }
}