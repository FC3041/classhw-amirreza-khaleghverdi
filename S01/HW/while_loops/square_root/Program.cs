using System;

namespace SquareRoot
{
    class Program
    {
        public static double square_root(double x, double precision)
        {
            if (x < 0)
            {
                Console.WriteLine("x must be positive");
            }

            double lowerBound = 0;
            double upperBound = x;
            int iterations = 0; 

            
            if (x == 0 || x == 1)
            {
                return x;
            }

            
            while (upperBound - lowerBound > precision)
            {
                double mid = (lowerBound + upperBound) / 2;
                double midSquared = mid * mid;

                if (midSquared < x)
                {
                    lowerBound = mid;
                }
                else
                {
                    upperBound = mid;
                }

                iterations++;
            }

            Console.WriteLine($"Number of iterations: {iterations}");
            return (lowerBound + upperBound) / 2;
        }

        static void Main(string[] args)
        {
            double x = 2;
            double precision = 0.000001;
            double result = square_root(x, precision);
            Console.WriteLine(result);
        }
    }
}