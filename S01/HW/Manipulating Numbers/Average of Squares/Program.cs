namespace Average_of_Squares;

class Program
{
    public static void Average_of_Squares(int num)
    {
        double result=0;
        for (int i=1;i<=num;i++)
        {
            result+=i*i;
        }
        result=result/num;
        Console.WriteLine(result);
    }
    static void Main(string[] args)
    {
        Console.Write("enter a number:");
        int num=Convert.ToInt32(Console.ReadLine());
        Average_of_Squares(num);
        
    }
}
