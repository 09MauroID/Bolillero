namespace Tests;

public class BolilleroTest

{
    public Bolillero prueba { get; set; }
    public BolilleroTest () => prueba = new Bolillero(10, new PrimeAzar());
    
    [Fact]
    public void SacarBolilla()
    {
        var bolilla = prueba.SacarBolilla();
    }
}