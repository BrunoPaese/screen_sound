﻿using ScreenSound.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Episodio ep1 = new(1, "Técnicas de facilitação", 45);
        ep1.AdicionarConvidados("Maria");
        ep1.AdicionarConvidados("Marcelo");

        Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
        ep2.AdicionarConvidados("Fernando");
        ep2.AdicionarConvidados("Marcos");
        ep2.AdicionarConvidados("Flávia");

        Podcast podcast = new("Podcast especial", "Daniel");
        podcast.AdicionarEpisodio(ep1);
        podcast.AdicionarEpisodio(ep2);
        podcast.ExibirDetalhes();

        Banda banda = Banda.ConverteParaMaiusculo("Bandaaa");
    }
}