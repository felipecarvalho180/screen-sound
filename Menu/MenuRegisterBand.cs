
using ScreenSound.Models;

namespace ScreenSound.Menu;

internal class MenuRegisterBand : Menu
{
	public override void Run(Dictionary<string, Band> bandList)
	{
        GenerateTitle("Registro de bandas");
        Console.Write("Digite o nome de banda que deseja registrar: ");

        string bandName = Console.ReadLine()!;
        Band band = new(bandName);

        bandList.Add(bandName, band);

        Console.WriteLine($"A banda {bandName} foi registrada com sucesso");

        base.Run(bandList);
    }
}

