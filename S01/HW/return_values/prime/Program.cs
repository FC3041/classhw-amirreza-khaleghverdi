namespace prime;

class Program
{
    public static bool is_prime(int num)
    {
        bool is_prime=true;
        if (num<2)
        {
            is_prime=false;
            return is_prime;
        }
        else if (num==2)
        {
            is_prime=true;
            return is_prime;
        }
        else
        {
            for (int i=2;i<num;i++)
            {
                if (num%i==0)
                {
                    is_prime =false;
                    return is_prime;
                }

            }
        }
        return is_prime;
    }
    static void Main(string[] args)
    {
        Console.Write("enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(is_prime(num));
    }
}
