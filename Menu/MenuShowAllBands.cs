using ScreenSound.Models;

namespace ScreenSound.Menu;

internal class MenuShowAllBands : Menu
{
	public override void Run(Dictionary<string, Band> bandList)
	{
        GenerateTitle("Bandas registradas");

        foreach (string band in bandList.Keys)
        {
            Console.WriteLine($"Banda: {band}");
        }

        base.Run(bandList);
    }
}

