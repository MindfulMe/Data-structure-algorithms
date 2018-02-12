using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{

    

    class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("Number of elements in the array:");
            uint numOfElements = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();
            string[] data = new string[numOfElements];
            for (int i=0;i<numOfElements;i++)
            {
                data[i] = Console.ReadLine();
            }

            Console.WriteLine("1-search. 2-replacement. 3-swapping");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Enter a pattern");
                    string pattern = Console.ReadLine();
                   for (int i=0;i<numOfElements;i++)
                    {
                        if (pattern == data[i])
                        {
                            Console.WriteLine("Found at index {0}", i);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("What are you going to replace?");
                    string replace = Console.ReadLine();
                    Console.WriteLine("What are you going to place?");
                    string place = Console.ReadLine();
                    for (int i = 0; i < numOfElements; i++)
                    {
                        if (replace == data[i])
                        {
                            data[i] = place;
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("What are you going to swap?");
                    string swap1 = Console.ReadLine();
                    int cout1 = 0;
                    for (int i = 0; i < numOfElements; i++)
                    {
                        if (swap1 == data[i])
                        {
                            cout1++;
                        }
                    }
                    if (cout1==0)
                    {
                        System.Environment.Exit(404);
                    }
                    Console.WriteLine("swap with?");
                    string swap2 = Console.ReadLine();
                    int cout2 = 0;
                    for (int i = 0; i < numOfElements; i++)
                    {
                        if (swap2 == data[i])
                        {
                            cout2++;
                        }
                    }
                    if (cout2 == 0)
                    {
                        System.Environment.Exit(404);
                    }

                    for (int i = 0; i < numOfElements; i++)
                    {
                        if (swap2 == data[i])
                        {
                            data[i] = swap1;
                        }
                        else if (swap1 == data[i])
                        {
                            data[i] = swap2;
                        }
                    }
                   
                    break;
            }
            Console.WriteLine("Final array is");
            for (int i = 0; i < numOfElements; i++)
            {
                Console.WriteLine("{0}", data[i]);
            }
            Console.ReadKey();
        }
    }
}
