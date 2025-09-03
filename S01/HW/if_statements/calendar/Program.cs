namespace calendar;

class Program
{
    public static void calendar(int num)
    {
        if (num==1)
        {
            Console.WriteLine("january");
        }
        if (num==2)
        {
            Console.WriteLine("february");
            
        }
        if (num==3)
        {
            Console.WriteLine("march");
        }
        if (num==4)
        {
            Console.WriteLine("april");
        }
        if (num==5)
        {
            Console.WriteLine("may");
        }
        if (num==6)
        {
            Console.WriteLine("june");
        }
        if (num==7)
        {
            Console.WriteLine("july");
        }
        if (num==8)
        {
            Console.WriteLine("august");
        }
        if (num==9)
        {
            Console.WriteLine("september");
        }
        if (num==10)
        {
            Console.WriteLine("october");
        }
        if (num==11)
        {
            Console.WriteLine("november");
        }
        if (num==12)
        {
            Console.WriteLine("december");
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter month number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        calendar(num);
    }
}
