using Bolillero.core;
namespace Tests;

public class SimulacionTest
{
    public Bolillerito prueba {get; set;}
    public Simulacion Simprueba {get; set;}
    public SimulacionTest () => prueba = new Bolillerito(10, new PrimeAzar());
    public S

    [Fact]
    public void simularSinHilos()
    {
        var jugarNVeces = prueba.JugarNVeces(Jugada: new List<int> {0, 1}, 1);
        Assert.Equal(1, jugarNVeces);
    }

    [Fact]
    public void simularConHilos()
    {
        var jugarNVeces = prueba.JugarNVeces(Jugada: new List<int> {0,1}, 1);
        Assert.Equal(1, jugarNVeces);
    }

    [Fact]
    static async void simularConHilosAsync()
    {
        var jugarNVeces = await prueba.JugarNVeces(Jugada: new List<int> {0,1}, 1);
        Assert.Equal(1, jugarNVeces); 
    }
}
