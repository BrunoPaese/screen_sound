﻿namespace ScreenSound.Modelos;

internal class Album
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public static int ContadorDeObjetos = 0;

    public Album(string nome)
    {
        Nome = nome;
        ContadorDeObjetos++;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este album inteiro você precisa de {DuracaoTotal} segundos");
    }

}