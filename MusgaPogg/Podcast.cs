public class Podcast
{
    public List<Episodio> episodios = new List<Episodio>();

    public Podcast (string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public string Host { get; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirEpisodios()
    {
        Console.WriteLine($"Lista de episódios do podcast: {Nome}.\n");
        foreach (var episodio in episodios)
        {
            Console.WriteLine($"Episódio {episodio.NumeroEpisodio}: {episodio.Nome}");
        }
    }
}