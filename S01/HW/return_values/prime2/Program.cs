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

    public static void print_prime(int limit)
    {
        for (int i=0;i<limit+1;i++)
        {
            if (is_prime(i)==true)
            {
                Console.Write(i+",");
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter a number: ");
        int limit=Convert.ToInt32(Console.ReadLine());
        print_prime(limit);
    }
}
