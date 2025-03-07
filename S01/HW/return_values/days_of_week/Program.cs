namespace days_of_week;

class Program
{
    public static void days_of_week(int month,int day)
    {
          




        int num=(month-1)*30+(day-1);
        if (num%7==0)
        {
            Console.WriteLine("monday");
        }
        else if (num%7==1)
        {
            Console.WriteLine("Tuesday");
        }
        else if (num%7==2)
        {
            Console.WriteLine("Wednesday");
        }
        else if (num%7==3)
        {
            Console.WriteLine("Thursday");
        }
        else if (num%7==4)
        {
            Console.WriteLine("Friday");
        }
        else if (num%7==5)
        {
            Console.WriteLine("Saturday");
        }
        else if (num%7==6)
        {
            Console.WriteLine("Sunday");
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter month: ");
        int month=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter day: " );
        int day=Convert.ToInt32(Console.ReadLine());
        days_of_week(month,day);
    }
}
