using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_Среднее_арифм_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            float s = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                {
                    s += array[i];
                }
            }
            Console.WriteLine(s / n);
            Console.ReadKey();
        }
    }
}
