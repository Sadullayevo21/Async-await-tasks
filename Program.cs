using System;
using System.Threading.Tasks;
using Tasks;

bool running;

do
{
    running = true;

    Console.Clear();
    Console.WriteLine("    MENU    ");

    Console.WriteLine("1. Breakfast Preparation");
    Console.WriteLine("2. Download Manager");
    Console.WriteLine("3. Student Information System");
    Console.WriteLine("4. Fastest Delivery");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            await Task1.StartBreakfastAsync();
            break;
        case "2":
            await Task2.StartDownloadsAsync();
            break;
        case "3":
            await Task3.DisplayStudentInfoAsync();
            break;
        case "4":
            await Task4.FindFastestDeliveryAsync();
            break;
        case "0":
            running = false; 
            Console.WriteLine("Program has finished!");
            break;
        default:
            Console.WriteLine("Invalid option! Please choose a number between 0 and 4.");
            Console.ResetColor();
            break;
    }

    if (running)
    {
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

} while (running); 