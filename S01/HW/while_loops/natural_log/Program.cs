using System;

namespace NaturalLogarithm
{
    class Program
    {
        public static double natural_log(double x, double precision)
        {
            if (x <= 0)
            {
                Console.WriteLine("x must be positive");
            }

            double lowerBound = -100; 
            double upperBound = 100;  
            int iterations = 0;   

            
            while (upperBound - lowerBound > precision)
            {
                double mid = (lowerBound + upperBound) / 2;
                double expMid = Math.Exp(mid);

                if (expMid < x)
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
            double result = natural_log(x, precision);
            Console.WriteLine($"Natural logarithm of {x} with precision {precision} is: {result}");
            
        }
    }
}