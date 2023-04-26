namespace Bolillero.core;

public class ARandom: IAzar

{
    private Random _random{ get; set; }
    public ARandom()
        =>_random = new Random(DateTime.Now.Millisecond);
    public int SacarIndice(List<int> Adentro)
    => _random.Next(0, Adentro.Count);
    
}