using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble()*50f;
                Console.WriteLine(array[i]);
            }
            for (int i = 0;i < array.Length-1; i++)
            {
                for (int j=i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine($"Сумма максимального и минимального числа в массиве равна {array[0]+ array[array.Length - 1]}");

            Console.ReadKey();
        }
    }
}
