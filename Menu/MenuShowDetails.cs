
using ScreenSound.Models;
namespace ScreenSound.Menu;

internal class MenuShowDetails : Menu
{
    public override void Run(Dictionary<string, Band> bandList)
	{
        GenerateTitle("Informe uma banda para obter a média");

        Console.Write("Digite o nome da banda: ");
        string bandName = Console.ReadLine()!;

        if (bandList.ContainsKey(bandName))
        {
            Band band = bandList[bandName];
            Console.WriteLine($"\nA média da banda {band.Name} é {band.Average}!");

            if (band.Albums.Count > 0) {
                Console.WriteLine("\nDiscografia:\n");

                foreach (Album album in band.Albums)
                {
                    Console.WriteLine($"{album.Name} -> {album.Average}");
                }
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {bandName} não foi encontrada");
        }

        base.Run(bandList);
    }
}

