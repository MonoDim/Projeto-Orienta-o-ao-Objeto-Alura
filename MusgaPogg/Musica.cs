public class Musica
{
    public string Nome {  get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence ao artista {Artista}";
    



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da musica: {Nome}");
        Console.WriteLine($"Nome do artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Indisponivel no plano");
        }
    }
}