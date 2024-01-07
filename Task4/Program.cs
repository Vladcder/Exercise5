using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            Console.WriteLine("Неупорядоченный массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50,51);
                Console.WriteLine(array[i]);
            }
            int count=0;
            for (int i = 0;i < array.Length;i+=2) 
            {
                if (array[i] > 0 && array[i]%2==1)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество нечетных положительных элементов, стоящих на четных местах равно {count}");
            Console.ReadKey();
        }
    }
}
