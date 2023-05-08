namespace Bolillero.core;

public class Bolillerito

{
    public List<int> Adentro { get; set; }
    public List<int> Afuera { get; set; }
    public List<int> Jugada { get; set; }
    public IAzar Random { get; set; }
    

    public Bolillerito(int numero, IAzar random)
    {
        Adentro = new List<int> ();
        CrearBolillas(numero);
        Afuera = new List<int> ();
        Jugada = new List<int> ();
        Random = random;
    }
    public int SacarBolilla()
    {
        var indice = Random.SacarIndice(this.Adentro);
        var Bolilla = Adentro[indice];

        Afuera.Add(Bolilla);

        Adentro.RemoveAt(indice);

        return (Bolilla);

    }
    public bool Jugar(List<int> Jugada)
    {
        for (int  i = 0 ; i < Jugada.Count ; i++)
        {
            var Bolilla = SacarBolilla();
            
            if (Bolilla != Jugada[i])
                return false;
        }

        return true;
    }

    public int JugarNVeces(List<int> Jugada, int cantidad)
    {
        var Victoria = 0;
        
        for (int i = 0 ; i < cantidad ; i++) 
        {
            var game = Jugar(Jugada);

            if (game == true)
                Victoria =+ 1;
        }

        return Victoria;
    }

    public void MeterBolilla()
    {
        Adentro.AddRange(Afuera);
        Afuera.Clear();
    }

    public void CrearBolillas(int numero)
    {
        for (int i = 0 ; i < numero  ; i++)
        {
            Adentro.Add(i);
        }
    }
}