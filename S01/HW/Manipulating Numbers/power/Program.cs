using System.Security.Cryptography;

namespace power;

class Program
{
    public static void power (int a,int b)
    {
        int i=0;
        int result=1;
        while (i<+b)
        {
            result*=a;
            i++;
                        
        }
        Console.WriteLine(a+" power "+b+" is "+result);
    }
    static void Main(string[] args)
    {
        power(12,2);
        
    }
}
