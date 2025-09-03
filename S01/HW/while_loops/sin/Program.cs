using System.Linq.Expressions;

namespace sin;

class Program
{
    public static double power (double a,int b)
    {
        int i=1;
        double result=1;
        while (i<=b)
        {
            result*=a;
            i++;
                        
        }
        return result;
    }
    public static int factorial(int num)
    {
        int result=1;
        for (int i=1;i<=num;i++)
        {
            result*=i;
        }
        return result;
    }
    
    public static double sin(double degree,double precision)
    {
        double rad=degree*(Math.PI/180);
        double result=0;
        int n=1;
        while(true)
        {
            double term=power(rad,n)/factorial(n);
            if (Math.Abs(term)<precision)
            {
                break;
            }
            else if (n%4==1)
            {
                result+=term;
            }
            else if (n%4==3)
            {
                result-=term;
                
            }
            n+=2;
        }
        return result;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(sin(60,0.0001));
        
    }
}
