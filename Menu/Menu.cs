using ScreenSound.Models;

namespace ScreenSound.Menu;

internal class Menu
{
    public void GenerateTitle(string title)
    {
        int titleLength = title.Length;
        string border = string.Empty.PadLeft(titleLength, '*');

        Console.Clear();
        Console.WriteLine(border);
        Console.WriteLine(title);
        Console.WriteLine(border + '\n');
    }

    public virtual void Run(Dictionary<string, Band> bandList)
    {
        Console.WriteLine($"\nDigite alguma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}

