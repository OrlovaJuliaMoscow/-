using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3_Упорядочить
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[10];
            Random  random= new Random();
            for (int i=0; i<10; i++)
            {
                array[i]=random.Next(-50,50);
                Console.Write("{0} ", array [i]);
            }
            Console.WriteLine();
            for (int i=0; i<4; i++) 
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                            array[i] = array[j];
                        array[j] = t;   
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} ", array[i]);

                Console.WriteLine();
                for (int l = 6; l < 9; l++)
                {
                    for (int m = l + 1; m < 10; m++)
                    {
                        if (array[l] < array[m])
                        {
                            int t1 = array[l];
                            array[l] = array[m];
                            array[m] = t1;
                        }
                    }
                }
                Console.WriteLine();
                for (int l = 0; l < 10; l++)
                {
                    Console.WriteLine("{0} ", array[l]);
                }
                Console.ReadKey();
            }
        }
    }
}
