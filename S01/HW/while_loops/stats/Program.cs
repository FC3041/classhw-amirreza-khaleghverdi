using System;
using System.Collections.Generic;

namespace stats
{
    class Program
    {
        public static int min(int[] arr)
        {
            int x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < x)
                {
                    x = arr[i];
                }
            }
            return x;
        }

        public static int max(int[] arr)
        {
            int x = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > x)
                {
                    x = arr[i];
                }
            }
            return x;
        }

        public static double average(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        public static void stats()
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or -1 to stop): ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == -1)
                {
                    break;
                }

                numbers.Add(num);
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers were entered.");
                return;
            }

            int[] arr = numbers.ToArray();

            Console.Write("The entered numbers are: ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr[arr.Length - 1]);

            Console.WriteLine("The average is: " + average(arr));
            Console.WriteLine("The max is: " + max(arr));
            Console.WriteLine("The min is: " + min(arr));
        }

        static void Main(string[] args)
        {
            stats();
        }
    }
}