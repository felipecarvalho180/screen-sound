using ScreenSound.Menu;
using ScreenSound.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Band band1 = new("Linkin Park");
        band1.AddRating(new Rating(10));
        band1.AddRating(new Rating(7));
        band1.AddRating(new Rating(9));

        Band band2 = new("Imagine Dragons");
        band2.AddRating(new Rating(5));
        band2.AddRating(new Rating(7));
        band2.AddRating(new Rating(9));

        Dictionary<string, Band> bandList = new()
        {
            { band1.Name, band1 },
            { band2.Name, band2 }
        };

        void ShowWelcomeMessage()
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
            Console.WriteLine("\nBem vindo ao Screen Sound\n");
        }

        void ShowMenuOptions()
        {
            ShowWelcomeMessage();
            Console.WriteLine("Digite 1 para registrar banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para avaliar um álbum");
            Console.WriteLine("Digite 6 para exibir a média de uma banda");
            Console.WriteLine("Digite alguma tecla para sair");

            Console.Write("\nDigite a sua opção: ");

            string selectedOption = Console.ReadLine()!;
            int numericSelectedOption = int.Parse(selectedOption);

            Dictionary<int, Menu> options = new Dictionary<int, Menu>
            {
                { 1, new MenuRegisterBand() },
                { 2, new MenuRegisterAlbum() },
                { 3, new MenuShowAllBands() },
                { 4, new MenuRatingBand() },
                { 5, new MenuRatingAlbum() },
                { 6, new MenuShowDetails() },
            };

            if (options.ContainsKey(numericSelectedOption))
            {
                options[numericSelectedOption].Run(bandList);
                ShowMenuOptions();
            }
            else
            {
                Console.WriteLine("Opção inválida, Tchau tchau :)");
            }
        }

        ShowMenuOptions();
    }
}