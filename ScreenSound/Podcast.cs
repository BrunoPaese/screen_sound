class Podcast
{
    public List<Episodio> episodios = new();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podecast {Nome} apresentado por {Host}\n");
        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Esse podcast possui {TotalEpisodios} episódios");
    }
}