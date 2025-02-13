namespace pythagorean;

class Program
{
    public static void pythagorean(int num)
    {
        for (int i=1;i<num+1;i++)
        {
            for (int j=1;j<num+1;j++)
            {
                for (int z=1;z<num+1;z++)
                {
                    if (i*i+j*j==z*z)
                    {
                        Console.WriteLine(i+","+j+","+z+" are pythagorean numbers");
                    }
                }
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter limit: ");
        int num=Convert.ToInt32(Console.ReadLine());
        pythagorean(num);
    }
}
