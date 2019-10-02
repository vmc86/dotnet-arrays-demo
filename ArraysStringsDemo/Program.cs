using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] res = new int[10,10];
            for (int j = 1; j < 10; j++)
            {
                for (int i =1; i<10; i++)
                {
                    res[j,i] = i * j;
                } 
            }

            for (int j = 1; j < 10; j++)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.Write(i + " * " + j + " = " + res[j,i] + "\t");
                }
                    Console.WriteLine();
            }
            
        }
    }
}
