namespace factorial;

class Program
{  
    public static void factorial(int num)
    {
        long result=1;
        if (num<0)
        {
            Console.WriteLine("invalid input");
            return;
        }
        else if(num==0)
        {
            Console.WriteLine("factorial 0 is 0");
            return;
        }
        for (int i=1;i<num+1;i++)
        {
            result*=i;
            Console.WriteLine("factorial "+ i +" is " + result);
        }
        
    }
    static void Main(string[] args)
    {
        Console.Write("enter number:");
        int num=Convert.ToInt32(Console.ReadLine());
        factorial(num);
        
    }
}
//its ok till 13
