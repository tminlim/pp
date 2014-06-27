using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalTest
{
    public class Program
    {
        static void Shape(int n)
        {
            string b = "   ";
            string s = " * ";

            int i;
            int range = 2* n - 1;

            for (i = 0; i <  n ; i++)
            {
                    for (int j = 0; j < n - (i + 1); j++)
                    {
                        Console.Write(b);
                    }

                    for (int m = 0; m < 2 * i + 1; m++)
                    {
                        if (m == 0)
                            Console.Write(s);
                        else if (m == 2 * i)
                            Console.Write(s);
                        else
                            Console.Write(b);
                    }

                    for (int j = 0; j < n - (i + 1); j++)
                    {
                        Console.Write(b);
                    }
                    Console.WriteLine();
               
            }
            int nBottom = 1;
            for (i = n; i < range; i++)
            {
                
                for (int b1 = 0; b1 < nBottom; b1++)
                    Console.Write(b);
                for (int b2 = 0; b2 < 2 * (i - (2*nBottom - 1)) - 1; b2++)
                {
                    if(b2 == 0)
                        Console.Write(s);
                    else if (b2 == 2 * (i - (2 * nBottom - 1)) - 2)
                        Console.Write(s);
                    else
                        Console.Write(b);

                }
                for (int b1 = 0; b1 < nBottom; b1++)
                    Console.Write(b);
                nBottom++;
                Console.WriteLine();
            }

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("insert into  the number");
            int n = Convert.ToInt32(Console.ReadLine());

            Shape(n);

            
        }
    }
}
