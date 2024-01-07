using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];
            Random random = new Random();
            Console.WriteLine("Неупорядоченный массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = -50f+(random.NextDouble() * (50f-(-50f)));
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < 5-1; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 5; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Упорядоченный массив ");
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
