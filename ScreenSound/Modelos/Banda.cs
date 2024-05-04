namespace ScreenSound.Modelos;

internal class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
  
    private List<Album> albuns = new();
    private List<Avaliacao> notas = new();
    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }

    public static Banda ConverteParaMaiusculo(string texto)
    {
        string nome = texto.ToUpper();
        return new Banda(nome);
    }
}