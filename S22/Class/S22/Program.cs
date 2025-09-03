using System.Security.Cryptography.X509Certificates;

namespace S22;

class Program
{
    static bool isodd(int a)
    {
        return a%2==1;
    }

    public static bool isprime(int a)
    {
        for(int i=2;i*i<a;i++)
        {
            if(a%i==0)
            return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        Enumerable.Range(1,100)
        .Where (x=> isprime(x))
        .Select(x=>(
            x,x.ToString().Select(c=>c-48).Sum())
        )
        .ToList()
        .ForEach(x=> Console.WriteLine(x));

    }
}
