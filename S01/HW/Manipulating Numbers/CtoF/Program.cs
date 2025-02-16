namespace CtoF;

class Program
{
    public static void CtoF(int C)
    {
        double F=(C*1.8)+32;
        Console.WriteLine(C+" Celsius is " +Math.Round(F,2)+" Fahrenheit");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("enter celsius: ");
        int c=Convert.ToInt32(Console.ReadLine());
        CtoF(c);
    }
}
