Banda MFDOOM = new Banda("MF DOOM");

Album albumDoMFDOOM = new Album("Mm.. Food");

Musica musica1 = new Musica(MFDOOM, "Beef Rapp")
{
    Duracao = 279,
    Disponivel = true
};


Musica musica2 = new Musica(MFDOOM, "Hoe Cakes")
{
    Duracao = 234,
    Disponivel = true
};


Musica musica3 = new Musica(MFDOOM, "Potholderz")
{
    Duracao = 200,
    Disponivel = true
};


albumDoMFDOOM.AdicionarMusica(musica1);
albumDoMFDOOM.AdicionarMusica(musica2);
albumDoMFDOOM.AdicionarMusica(musica3);
MFDOOM.AdcionarAlbum(albumDoMFDOOM);

musica1.ExibirFichaTecnica();
Console.WriteLine("");
musica2.ExibirFichaTecnica();
Console.WriteLine("");
musica3.ExibirFichaTecnica();
Console.WriteLine("");
albumDoMFDOOM.ExibirMusicasDoAlbum();
Console.WriteLine("");
MFDOOM.ExibirDiscogradia();