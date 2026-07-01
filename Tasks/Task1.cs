using System;
using System.Threading.Tasks;
namespace Tasks;

public static class Task1
{
    public static async Task StartBreakfastAsync()
    {
        Console.WriteLine("Making breakfast started...");

        Task eggTask = BoilEgg();
        Task breadTask = ToastBread();
        Task teaTask = MakeTea();

        await Task.WhenAll(eggTask, breadTask, teaTask);

        Console.WriteLine("Breakfast is ready!");
    }

    static async Task BoilEgg()
    {
        Console.WriteLine("Boiling egg started...");
        await Task.Delay(3000); 
        Console.WriteLine("The egg boiled.");
    }

    static async Task ToastBread()
    {
        Console.WriteLine("Toasting bread started...");
        await Task.Delay(2000); 
        Console.WriteLine("Bread toasted.");
    }

    static async Task MakeTea()
    {
        Console.WriteLine("Making Tea started...");
        await Task.Delay(4000);
        Console.WriteLine("Tea made.");
    }
}