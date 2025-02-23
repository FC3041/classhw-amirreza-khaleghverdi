namespace absolute;

class Program
{
    public static void absolute(int num)
    {
        if (num<0)
        {
            Console.WriteLine(-num);
        }
        else
        {
            Console.WriteLine(num);
        } 
    }
    static void Main(string[] args)
    {
        Console.Write("enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        absolute(num);
    }
}
