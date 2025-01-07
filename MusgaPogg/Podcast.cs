public class Podcast
{
    public List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public string Host { get; }




}