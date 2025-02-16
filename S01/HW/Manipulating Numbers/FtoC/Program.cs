namespace FtoC;

class Program
{
    public static void FtoC(int F)
    {
        double C=(F-32)*5.0/9;
        Console.WriteLine(F+" Fahrenheit is "+Math.Round(C,2) +" Celsius");
    }
    static void Main(string[] args)
    {
        Console.Write("enter the farenheit: ");
        int F=Convert.ToInt32(Console.ReadLine());
        FtoC(F);
    }
}
