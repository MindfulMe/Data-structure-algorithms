// todo: replace the "f" element with "j" :з
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
            string[,] data = new string[numOfElements, numOfElements];
            for (int i = 0; i < numOfElements; i++)
            {
                for (int f = 0; f < numOfElements; f++)
                {
                    data[i, f] = Console.ReadLine();
                }
            }

            Console.WriteLine("1-search. 2-replacement. 3-swapping");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Enter a pattern");
                    string pattern = Console.ReadLine();
                    for (int i = 0; i < numOfElements; i++)
                    {
                        for (int f = 0; f < numOfElements; f++)
                        {
                            if (pattern == data[i, f])
                            {
                                Console.WriteLine("Found at indexes {0}{1}", i, f);
                            }
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
                        for (int f = 0; f < numOfElements; f++)
                        {
                            if (replace == data[i, f])
                            {
                                data[i, f] = place;
                            }
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("What are you going to swap?");
                    string swap1 = Console.ReadLine();
                    int cout1 = 0;
                    for (int i = 0; i < numOfElements; i++)
                        for (int f = 0; f < numOfElements; f++)
                        {
                            {
                                if (swap1 == data[i, f])
                                {
                                    cout1++;
                                }
                            }
                    }
                    if (cout1 == 0)
                    {
                        System.Environment.Exit(404);
                    }
                    Console.WriteLine("swap with?");
                    string swap2 = Console.ReadLine();
                    int cout2 = 0;
                    for (int i = 0; i < numOfElements; i++)
                        for (int f = 0; f < numOfElements; f++)
                        {
                            {
                                if (swap2 == data[i,f])
                                {
                                    cout2++;
                                }
                            }
                    }
                    if (cout2 == 0)
                    {
                        System.Environment.Exit(404);
                    }

                    for (int i = 0; i < numOfElements; i++)
                        for (int f = 0; f < numOfElements; f++)
                        {
                            {
                                if (swap2 == data[i,f])
                                {
                                    data[i,f] = swap1;
                                }
                                else if (swap1 == data[i,f])
                                {
                                    data[i,f] = swap2;
                                }
                            }
                        }


                    break;
            }
            Console.WriteLine("Final array is");
            for (int i = 0; i < numOfElements; i++)
                for (int f = 0; f < numOfElements; f++)
                {
                    {
                        Console.WriteLine("{0}", data[i, f]);
                    }
                }
            Console.ReadKey();
        }
    }
}
