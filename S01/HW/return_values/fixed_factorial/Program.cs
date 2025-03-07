namespace factorial;

class Program
{  
    public static int factorial(int num)
    {
        int result=1;
        for (int i=1;i<num+1;i++)
        {
            result*=i;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.Write("enter number:");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("factorial "+num+" is "+ factorial(num));
        
    }
}
