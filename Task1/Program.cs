using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array=new double[7];
            double sum=0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=Convert.ToDouble(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine($"Среднее арифметическое чисел в массиве равно {sum/array.Length}");
        }
    }
}
