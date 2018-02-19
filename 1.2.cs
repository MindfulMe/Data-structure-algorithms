using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> data = new List<string>();
        Console.WriteLine("Enter the number of elemnts");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= number - 1; i++)
            data.Add(Console.ReadLine());
        Console.WriteLine("How many elements do you wanna remove?");
        int RemNumber = Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<RemNumber;i++)
        {
            Console.WriteLine("Remove element number:");
            data.RemoveAt(1+Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine("Search for an elemnt:");
        string pattern = Console.ReadLine();
        for (int i=0;i<data.Count;i++)
        {
            if (pattern == data[i])
                Console.WriteLine($"Found at index {i}");
        }
        for (int i=0; i<data.Count;i++)
        {
            Console.WriteLine($"{data[i]}");
        }
        Console.ReadKey();
    }
}

