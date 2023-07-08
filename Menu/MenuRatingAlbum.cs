using ScreenSound.Models;

namespace ScreenSound.Menu;

internal class MenuRatingAlbum : Menu
{
	public override void Run(Dictionary<string, Band> bandList)
	{
        GenerateTitle("Avaliar Álbum");

        Console.Write("Digite o nome da banda: ");
        string bandName = Console.ReadLine()!;

        if (!bandList.ContainsKey(bandName)) {
            Console.WriteLine($"\nA banda {bandName} não foi encontrada");
            return;
        }
        
        Band band = bandList[bandName];

        if (band.Albums.Count <= 0) {
            Console.WriteLine($"\nA banda {bandName} não contém albuns ainda.");
            return;
        }

        Console.Write("Agora digite o nome do álbum: ");
        string albumName = Console.ReadLine()!;

        if (!band.Albums.Any(a => a.Name.Equals(albumName))) {
            Console.WriteLine($"\nÁlbum não encontrado.");
            return;
        }

        Album album = band.Albums.First(a => a.Name.Equals(albumName));

        Console.Write($"Qual a nota que o álbum {albumName} merece: ");
        Rating rate = Rating.Parse(Console.ReadLine()!);

        album.AddRating(rate);    

        Console.WriteLine($"\nA nota {rate.Value} foi adicionada ao álbum {albumName}!");

        base.Run(bandList);
    }
}

