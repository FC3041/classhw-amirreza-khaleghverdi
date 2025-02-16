using System;

namespace SquareRoot
{

    class Program
    {
        public static double power(double x,double n)
        {
            double result=1;
            for (int i=1;i<=n;i++)
            {
                result*=x;
            }
            return result;
        }
        public static double square_root(double x,int n, double precision)
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
                double midnth = power(mid,n);

                if (midnth < x)
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
            double x = 8;
            int n=3;
            double precision = 0.000001;
            double result = square_root(x, n, precision);
            Console.WriteLine(result);
        }
    }
}