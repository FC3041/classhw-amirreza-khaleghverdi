namespace days_before;

class Program
{
    public static int days_before(int nyear,int nmonth,int nday)
    {
        int year=2014;
        int month=1;
        int day=1;
        return (nyear-year)*365+(nmonth-month)*30+(nday-day);
    }
    static void Main(string[] args)
    {
        Console.Write("enter year: ");
        int year=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter month: ");
        int month=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter day: ");
        int day=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(days_before(year,month,day));
    }
}
