public class Episodio
{
    public Episodio(string nome, int duracao, List<Episodio> episodiosExistentes)
    {
        Nome = nome;
        Duracao = duracao;
        NumeroEpisodio = episodiosExistentes.Count + 1;
    }
    public string Nome { get; }
    public int Duracao { get; }
    public int NumeroEpisodio { get; }

    


}