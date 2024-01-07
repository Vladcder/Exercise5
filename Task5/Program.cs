using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N ");
            int N=Convert.ToInt32(Console.ReadLine());
            int[,] array=new int[N,N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    if (i%2==j%2)
                    {
                        array[i, j] = 1;
                        Console.Write(array[i, j]);
                    }
                    else
                    {
                        array[i, j] = 0;
                        Console.Write(array[i, j]);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
