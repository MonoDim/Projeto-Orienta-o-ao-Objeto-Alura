﻿public class Album
{
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"A duração total desse album é de: {DuracaoTotal} segundos");
    }
}
