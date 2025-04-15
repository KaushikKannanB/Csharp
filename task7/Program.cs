using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    public static async Task Main()
    {
        Console.WriteLine("\nCommon tell me when you entered Kaushik: ");
        string kaushik = Console.ReadLine();

        Console.WriteLine("\nCommon tell me when you entered Saxon: ");
        string saxon = Console.ReadLine();
        
        Console.WriteLine("\nSynchronous functions: ");

        Stopwatch ss = new Stopwatch();
        ss.Start();
        string result1 = task3_get_data_from_Kaushik(kaushik);
        string result2 = task4_get_data_from_saxon(saxon);
        ss.Stop();

        Console.WriteLine("\n"+result1);
        Console.WriteLine("\n"+result2);

        Console.WriteLine("\nTime elapsed: " + ss.Elapsed.TotalSeconds);

        Console.WriteLine("\nAsynchronous Tasks: ");

        Stopwatch s = new Stopwatch();

        try
        {
            s.Start();

            Task<string> kaushik_object = task1_get_data_from_Kaushik(kaushik);
            Task<string> saxon_object = task2_get_data_from_saxon(saxon);

            string[] results = await Task.WhenAll(kaushik_object, saxon_object);
            s.Stop();
            foreach (var result in results)
            {
                Console.WriteLine("\n" + result);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\nTime elapsed: " + s.Elapsed.TotalSeconds);
        }
    }
    public static async Task<string> task1_get_data_from_Kaushik(string time)
    {
        await Task.Delay(2000);
        return "Kaushik entered the office at " + time;
    }

    public static async Task<string> task2_get_data_from_saxon(string time)
    {
        await Task.Delay(3000);
        return "Saxon entered the office at " + time;
    }

    public static string task3_get_data_from_Kaushik(string time)
    {
        Thread.Sleep(2000);
        return "Kaushik entered the office at " + time;
    }

    public static string task4_get_data_from_saxon(string time)
    {
        Thread.Sleep(3000);
        return "Saxon entered the office at " + time;
    }
}
