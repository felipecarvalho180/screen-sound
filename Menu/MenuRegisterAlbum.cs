using ScreenSound.Models;

namespace ScreenSound.Menu;

internal class MenuRegisterAlbum : Menu
{
    public override void Run(Dictionary<string, Band> bandList)
    {
        GenerateTitle("Registro de álbuns");
        Console.Write("Digite o nome da banda que constém o álbum que deseja registrar: ");
        string bandName = Console.ReadLine()!;

        if (bandList.ContainsKey(bandName))
        {
            Console.Write("Agora digite o nome do álbum: ");
            string albumName = Console.ReadLine()!;

            Band band = bandList[bandName];
            band.AddAlbum(new Album(albumName));


            Console.WriteLine($"O álbum {albumName} foi adicionado a banda {bandName} com sucesso");
        }
        else
        {
            Console.WriteLine($"\nA banda {bandName} não foi encontrada");
        }

        base.Run(bandList);
    }
}

