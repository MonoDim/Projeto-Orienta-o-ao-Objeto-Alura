public class Banda
{
    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public void AdcionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void ExibirDiscogradia()
    {
        Console.WriteLine($"Segue a discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
