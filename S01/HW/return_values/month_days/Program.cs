namespace month_days;

class Program
{
    public static int month_days(int month)
    {
        if (month==1)
        {
            return 31;
        }
        else if (month==2)
        {
            return 28;
        }
        else if (month==3)
        {
            return 31;
        }
        else if (month==4)
        {
            return 30;
        }
        else if (month==5)
        {
            return 30;
        }
        else if (month==6)
        {
            return 30;
        }
        else if (month==7)
        {
            return 31;
        }
        else if (month==8)
        {
            return 31;
        }
        else if (month==9)
        {
            return 30;
        }
        else if (month==10)
        {
            return 31;
        }
        else if (month==11)
        {
            return 30;
        }
        else if (month==12)
        {
            return 31;
        }
        return 0;
    }
    static void Main(string[] args)
    {
        Console.Write("enter month number: ");
        int month=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(month_days(month));
    }
}
