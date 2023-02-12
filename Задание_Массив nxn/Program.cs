using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_Массив_nxn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = ((i == j) || (i + j == n - 1) || (i == 0) && (j == n - 3) || (i == n-1) && (j == n - 3)||(i == n-3) && (j == 0)|| (i == n - 3) && (j == n-1)) ? 1 : 0;
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
