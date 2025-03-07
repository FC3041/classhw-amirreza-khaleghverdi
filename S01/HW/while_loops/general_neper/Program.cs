namespace general_neper;

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
    
    public static double general_neper(double num,double precision)
    {
        double result=0;
        int n=0;
        while(true)
        {
            double term=power(num,n)/factorial(n);
            if (term<precision)
            {
                break;
            }
            else
            {
                result+=term;
                n+=1;
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(general_neper(2,0.0001));
        
    }
}
