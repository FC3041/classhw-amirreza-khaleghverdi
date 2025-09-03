namespace fibonacci;

class Program
{
    public static int fibonacci(int N)
    {   
        if(N==1)
        {
            return 0;
        }
        else if(N==2)
        {
            return 1;
        }
        else 
        {
            return fibonacci(N-2)+fibonacci(N-1);
        }
        
    }
    static void Main(string[] args)
    {
        Console.Write("enter the N: ");
        int N=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fibonacci(N));
    }
}
