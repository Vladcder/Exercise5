using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            bool isMagicSquare = true;
            int[] sumRow = new int[array.GetLength(0)];
            int[] sumCol= new int[array.GetLength(1)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sumRow[i] += array[i, j];
                    }
                    if (sumRow[i] != sumRow[0])
                    { 
                        isMagicSquare = false;
                        break;
                    }
                }
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        sumCol[j] += array[i, j];
                    }
                    if (sumCol[j] != sumCol[0])
                    {
                        isMagicSquare = false;
                        break;
                    }
            }
            if (isMagicSquare)
            {
                Console.WriteLine("Матрица является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Матрица не является магическим квадратом");

            }


            Console.ReadKey();
        }
    }
}
