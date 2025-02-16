namespace general_neper;

class Program
{
    public static int factorial(int num)
    {
        int result=1;
        for (int i=1;i<num+1;i++)
        {
            result*=i;
        }
        return result;
    }
    
    public static double euler(double precision)
    {
        double euler=0;
        int n=0;
        while(true)
        {
            double term=1.0/factorial(n);
            if (term<precision)
            {
                break;
            }
            else
            {
                euler+=term;
                n+=1;
            }
        }
        return euler;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(euler(0.001));
    }
}
