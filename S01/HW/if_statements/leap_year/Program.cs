namespace leap_year;

class Program
{
    public static void leap_year(int year)
    {
        if (year%4==0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter the year: ");
        int year=Convert.ToInt32(Console.ReadLine());
        leap_year(year);
    }
}
