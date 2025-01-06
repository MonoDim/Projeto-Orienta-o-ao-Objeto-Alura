Album albumDoMFDOOM = new Album();
albumDoMFDOOM.Nome = "Mm.. Food";

Musica musica1 = new Musica();
musica1.Nome = "Beef Rapp";
musica1.Duracao = 279;

Musica musica2 = new Musica();
musica2.Nome = "Hoe Cakes";
musica2.Duracao = 234;

Musica musica3 = new Musica();
musica3.Nome = "Potholderz";
musica3.Duracao = 200;

albumDoMFDOOM.AdicionarMusica(musica1);
albumDoMFDOOM.AdicionarMusica(musica2);
albumDoMFDOOM.AdicionarMusica(musica3);

albumDoMFDOOM.ExibirMusicasDoAlbum();