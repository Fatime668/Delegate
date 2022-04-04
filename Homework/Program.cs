using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    class Program
    {
        //public delegate void ShowInfo(double[] arr);
        static void Main(string[] args)
        {
            double[] array = new double[] { 10, 15, 20, 25, 30, 35 };
            Action<double[]> action = AcDel;
            action(array);
        }
        public static void AcDel(double[] productArr)
        {
            double total = 0;
            int count = 0;
            foreach (int num in productArr)
            {
                total += num;
                count++;
                Console.WriteLine(num);

            }
            Console.WriteLine($"Total: {total} Count: {count}");

        }
    }
}
