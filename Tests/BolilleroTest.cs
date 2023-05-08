using Bolillero.core;
namespace Tests;

public class BolilleroTest

{
    public Bolillerito prueba { get; set; }
    public BolilleroTest () => prueba = new Bolillerito(10, new PrimeAzar());
    
    [Fact]
    public void SacarBolilla()
    {
        var bolilla = prueba.SacarBolilla();
        var devolver = 0;
        
        Assert.Equal(devolver, bolilla);
        Assert.Equal(9, prueba.Adentro.Count);
        Assert.Equal(1, prueba.Afuera.Count);
    }

    [Fact]
    public void MeterBolilla()
    {
        prueba.SacarBolilla();
        prueba.MeterBolilla();

        Assert.Equal(10, prueba.Adentro.Count);
        Assert.Equal(0, prueba.Afuera.Count);
    }

    [Fact]
    public void JugarGana()
    {
        var jugarGana = prueba.Jugar(Jugada: new List <int>() {0, 1, 2,3});
        Assert.True(jugarGana);
    }

    [Fact]
    public void JugarPierde()
    {
        var jugarPierde = prueba.Jugar(Jugada: new List<int>() {4, 2, 1});
        Assert.False(jugarPierde);
    }

    [Fact]
    public void GanarNVeces()
    {
        var ganarNVeces = prueba.JugarNVeces(Jugada: new List<int> {0, 1}, 1);
        Assert.Equal(1, ganarNVeces);
    }
}