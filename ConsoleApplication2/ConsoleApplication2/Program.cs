using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        while (true)
        {
            // startuje licznie
            Example();
            // to co wpisales
            string result = Console.ReadLine();
            Console.WriteLine("napisales: " + result);
        }
    }

    static async void Example()
    {
        // ta metoda dziala asynchronicznie
        int t = await Task.Run(() => Allocate());
        Console.WriteLine("obliczam: " + t);
    }

    static int Allocate()
    {
        // obliczam calkowita ilost liczb w stringu
        int size = 0;
        for (int z = 0; z < 100; z++)
        {
            for (int i = 0; i < 1000000; i++)
            {
                string value = i.ToString();
                if (value == null)
                {
                    return 0;
                }
                size += value.Length;
            }
        }
        return size;
    }
}