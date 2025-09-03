namespace equation;

class Program
{
    public static void equation(int a,int b,int c)
    {
        double x1=(-b+Math.Sqrt(b*b-4*a*c)) / (2*a);
        double x2=(-b-Math.Sqrt(b*b-4*a*c)) / (2*a);
        Console.WriteLine("the roots of "+a+"x^2 + "+b+"x + "+c+" is "+x1+" and "+x2);
    }
    static void Main(string[] args)
    {
        equation(1,2,1);
        
    }
}
