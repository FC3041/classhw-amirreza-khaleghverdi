namespace factorial;

class Program
{  
    public static void factorial(int num)
    {
        if (num<0)
        {
            Console.WriteLine("invalid input (it must be positive)");
            return;
        }
        else if (num==0)
        {
            Console.WriteLine("factorial 0 is 0");
            return;
        }
        int result=1;
        for (int i=1;i<num+1;i++)
        {
            result*=i;
        }
        Console.WriteLine("factorial "+ num +" is "+ result);
    }
    static void Main(string[] args)
    {
        Console.Write("enter number:");
        int num=Convert.ToInt32(Console.ReadLine());
        factorial(num);
        
        
    }
}
