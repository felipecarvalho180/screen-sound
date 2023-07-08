using ScreenSound.Models;
namespace ScreenSound.Menu;

internal class MenuRatingBand : Menu
{
    public override void Run(Dictionary<string, Band> bandList)
    {
        GenerateTitle("Avaliar banda");

        Console.Write("Digite o nome da banda: ");
        string band = Console.ReadLine()!;

        if (bandList.ContainsKey(band))
        {
            Console.Write($"Qual a nota que a banda {band} merece: ");
            Rating rate = Rating.Parse(Console.ReadLine()!);
            bandList[band].AddRating(rate);

            Console.WriteLine($"\nA nota {rate.Value} foi adicionada a banda {band}!");
        }
        else
        {
            Console.WriteLine($"\nA banda {band} não foi encontrada");
        }

        base.Run(bandList);
    }
}

