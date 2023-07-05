//// Screen sound
//string welcomeMessage = "\nBem vindo ao Screen Sound\n";
////List<string> bandList = new List<string> { "U2", "The Beatles" };
//Dictionary<string, List<int>> bandList = new Dictionary<string, List<int>>();
//bandList.Add("Linkin Park", new List<int> { 10, 9, 3 });
//bandList.Add("Led Zeplin", new List<int>());

//void ShowWelcomeMessage()
//{
//    Console.WriteLine(@"
//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
//    Console.WriteLine(welcomeMessage);
//}

//void ShowMenuOptions()
//{
//    ShowWelcomeMessage();
//    Console.WriteLine("Digite 1 para registrar banda");
//    Console.WriteLine("Digite 2 para mostrar todas as bandas");
//    Console.WriteLine("Digite 3 para avaliar uma banda");
//    Console.WriteLine("Digite 4 para exibir a média de uma banda");
//    Console.WriteLine("Digite 0 para sair");

//    Console.Write("\nDigite a sua opção: ");

//    string selectedOption = Console.ReadLine()!;
//    int numericSelectedOption = int.Parse(selectedOption);

//    Dictionary<int, Action> options = new Dictionary<int, Action>
//    {
//        { 1, () => BandRegister() },
//        { 2, () => ShowAllRegisteredBands() },
//        { 3, () => RatedBand() },
//        { 4, () => GetAverage() },
//        { 0, () => Console.WriteLine("Tchau tchau :)")}
//    };

//    if (options.ContainsKey(numericSelectedOption))
//    {
//        options[numericSelectedOption].Invoke();
//    }
//    else
//    {
//        Console.WriteLine("Opção inválida");
//    }


//}

//void BandRegister()
//{
//    GenerateTitle("Registro de bandas");
//    Console.Write("Digite o nome de banda que deseja registrar: ");

//    string bandName = Console.ReadLine()!;
//    bandList.Add(bandName, new List<int>());

//    Console.WriteLine($"A banda {bandName} foi registrada com sucesso");

//    Thread.Sleep(2000);
//    Console.Clear();
//    ShowMenuOptions();
//}

//void ShowAllRegisteredBands()
//{
//    GenerateTitle("Bandas registradas");

//    foreach (string band in bandList.Keys)
//    {
//        Console.WriteLine($"Banda: {band}");
//    }

//    Console.WriteLine("\nClique em alguma tecla para voltar ao menu inicial");
//    Console.ReadKey();
//    Console.Clear();
//    ShowMenuOptions();
//};

//void RatedBand()
//{
//    GenerateTitle("Avaliar banda");

//    Console.Write("Digite o nome da banda: ");
//    string band = Console.ReadLine()!;

//    if (bandList.ContainsKey(band))
//    {
//        Console.Write($"Qual a nota que a banda {band} merece: ");
//        int rate = int.Parse(Console.ReadLine()!);
//        bandList[band].Add(rate);

//        Console.WriteLine($"\nA note {rate} foi adicionada a banda {band}!");
//        Thread.Sleep(4000);
//        Console.Clear();
//        ShowMenuOptions();
//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {band} não foi encontrada");
//        Console.WriteLine($"Digite alguma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ShowMenuOptions();
//    }
//}

//void GetAverage()
//{
//    GenerateTitle("Informe uma banda para obter a média");

//    Console.Write("Digite o nome da banda: ");
//    string band = Console.ReadLine()!;

//    if (bandList.ContainsKey(band))
//    {
//        double bandAverage = bandList[band].Average();

//        Console.WriteLine($"\nA média da banda {band} é {bandAverage}!");
//        Thread.Sleep(4000);
//        Console.Clear();
//        ShowMenuOptions();
//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {band} não foi encontrada");
//        Console.WriteLine($"Digite alguma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ShowMenuOptions();
//    }
//}

//void GenerateTitle(string title)
//{
//    int titleLength = title.Length;
//    string border = string.Empty.PadLeft(titleLength, '*');

//    Console.Clear();
//    Console.WriteLine(border);
//    Console.WriteLine(title);
//    Console.WriteLine(border + '\n');
//};

//ShowMenuOptions();