using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Second home work: Git 2015\n Victorija Bulvane IT 3 course.\n\n Third task!");

            int x, y, z, counter = 0;

            for (int i = 0; i == counter; i++)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("\n Enter please first number:  ");
                    x = Int32.Parse(Console.ReadLine());

                    Console.Write(" Enter please second number: ");
                    y = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("\n You enter: \n\t    x: {0} \n\t    y: {1}", x, y);

                    z = x * y;

                    Console.WriteLine("\n x * y = " + z + "\n");

                    if (z <= 0) Console.WriteLine(" Sorry, no asterisks!");
                        else
                        {
                            for (int asterisks = 1; asterisks <= z; asterisks++)
                            {
                                Console.WriteLine(" " + asterisks + ". *");
                            }
                        }


                }
                catch (Exception error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n " + error.Message);
                    counter++;
                }
            }

            Console.ResetColor();

            Console.WriteLine("\n\n Press any key to exit!");

            Console.ReadKey();
        }
    }
}
