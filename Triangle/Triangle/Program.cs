using System;
using System.Security.Cryptography.X509Certificates;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value = false;
            while (!value)
            {   
                
                Console.WriteLine("1. Enter Triangle dimensons");
                Console.WriteLine("2. Exit");
                String s = Console.ReadLine();
                if (s == "2")
                {
                    System.Environment.Exit(1);
                    value = true;
                }
                else if (s == "1")
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    int y = Convert.ToInt32(Console.ReadLine());
                    int z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(TriangleSolver.Analyze(x, y, z));
                    value = false;
                }

                else
                {
                    Console.WriteLine("Invalid option choose between these two options only");
                    value = false;
                }
            }
           
        }
    }
}
