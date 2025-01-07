public class Episodio
{
    private static int contadorEpisodios = 0;
    public Episodio(string nome, int duracao)
    {
        Nome = nome;
        Duracao = duracao;
        NumeroEpisodio = ++contadorEpisodios;
    }
    public string Nome { get; }
    public int Duracao { get; }
    public string Convidado { get; set; }
    public int NumeroEpisodio { get; set; } 

    public void ExibirDetalheEpisodio()
    {
        Console.WriteLine($"Episodio: {Nome}");
        Console.WriteLine($"Duração: {Duracao}");

    }
}