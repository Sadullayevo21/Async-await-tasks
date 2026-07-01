using System;
using System.Threading.Tasks;

namespace Tasks;
public static class Task4
{
    public static async Task FindFastestDeliveryAsync()
    {
        Console.WriteLine("Delivery services started...");

        Task<string> car = DeliveryByCar();
        Task<string> bike = DeliveryByBike();
        Task<string> drone = DeliveryByDrone();

        Task<string>[] allDeliveries = { car, bike, drone };

        Task<string> fastestDelivery = await Task.WhenAny(allDeliveries);

        string fastestResult = await fastestDelivery;
        Console.WriteLine($"\nFastest delivery: {fastestResult}");

        Console.WriteLine("Waiting for the remaining deliveries to complete...");
        
        await Task.WhenAll(allDeliveries);
        
        Console.WriteLine("All deliveries have completed.");
    }

    private static async Task<string> DeliveryByCar()
    {
        await Task.Delay(4000); 
        Console.WriteLine("-> Car delivery finished.");
        return "Car";
    }

    private static async Task<string> DeliveryByBike()
    {
        await Task.Delay(5000);
        Console.WriteLine("-> Bike delivery finished.");
        return "Bike";
    }

    private static async Task<string> DeliveryByDrone()
    {
        await Task.Delay(2000); 
        Console.WriteLine("-> Drone delivery finished.");
        return "Drone";
    }
}