using System;
using System.Threading.Tasks;
namespace Tasks;

public static class Task2
{
    public static async Task StartDownloadsAsync()
    {
        Console.WriteLine("Starting Download Manager...");

        Task file1Task = DownloadFile1();
        Task file2Task = DownloadFile2();
        Task file3Task = DownloadFile3();

        await Task.WhenAll(file1Task, file2Task, file3Task);

        Console.WriteLine("All files have been downloaded.");
    }

    private static async Task DownloadFile1()
    {
        Console.WriteLine("File 1 download started...");
        await Task.Delay(3000);
        Console.WriteLine("File 1 download finished.");
    }

    private static async Task DownloadFile2()
    {
        Console.WriteLine("File 2 download started...");
        await Task.Delay(5000);
        Console.WriteLine("V File 2 download finished.");
    }

    private static async Task DownloadFile3()
    {
        Console.WriteLine("File 3 download started...");
        await Task.Delay(2000); 
        Console.WriteLine("File 3 download finished.");
    }
}