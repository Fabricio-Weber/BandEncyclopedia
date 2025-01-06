// See https://aka.ms/new-console-template for more information

using System;

List<string> bandsList = new List<string>{"100gecs", "Death Grips", "Deftones", "Godspeed You! Black Emperor"};
void SplashScreen()
{
    Console.WriteLine(@"
███╗░░██╗░░░██╗░░██╗░░░██╗░░░██╗░░░██████╗░
████╗░██║░░░██║░██╔╝░░░██║░░░██║░░░██╔══██╗
██╔██╗██║░░░█████═╝░░░░╚██╗░██╔╝░░░██║░░██║
██║╚████║░░░██╔═██╗░░░░░╚████╔╝░░░░██║░░██║
██║░╚███║██╗██║░╚██╗██╗░░╚██╔╝░░██╗██████╔╝
╚═╝░░╚══╝╚═╝╚═╝░░╚═╝╚═╝░░░╚═╝░░░╚═╝╚═════╝░");

    Console.WriteLine("\nWelcome, please select an option:");
}

void ShowMenuOptions()
{
    Console.Clear();
    SplashScreen();
    Console.WriteLine("\nType 1 to list all bands");
    Console.WriteLine("Type 2 to register a band");
    Console.WriteLine("Type 3 to rate a band");
    Console.WriteLine("Type 4 to show the average score for bands");
    Console.WriteLine("Type -1 to exit");

    Console.Write("Type the option you want: ");
    string chosenOption = Console.ReadLine()!;
    int numericalOption = int.Parse(chosenOption);

    switch (numericalOption)
    {
        case 1:
            ShowBands();
            break;
        case 2:
            RegisterBand();
            break;
        case 3:
            Console.WriteLine("\nYOU CHOSE OPTION " + numericalOption);
            break;
        case 4:
            Console.WriteLine("\nYOU CHOSE OPTION " + numericalOption);
            break;
        case -1: break;
        default:
            Console.WriteLine("\nINVALID OPTION");
            break;
    }
}

SplashScreen();
ShowMenuOptions();

void RegisterBand()
{
    Console.Clear();
    ShowOptionTitle("Register a band");
    Console.WriteLine("Type the name of the band you want to register");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName);
    Console.WriteLine($"The band {bandName} was registered successfully");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}

void ShowBands()
{
    Console.Clear();
    ShowOptionTitle("Bands registered");
    for(int i = 0; i < bandsList.Count; i++)
    {
        Console.WriteLine($"{bandsList[i]}");
    }

    Console.WriteLine("\n************************");
    Console.WriteLine("Press any key to return");
    Console.ReadKey();
    ShowMenuOptions();
}

void ShowOptionTitle(string title)
{
    int letters = title.Length;
    string borders = string.Empty.PadLeft(letters, '*');
    Console.WriteLine(borders);
    Console.WriteLine(title);
    Console.WriteLine(borders + "\n");
}