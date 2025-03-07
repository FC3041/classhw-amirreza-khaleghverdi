namespace triangle1_2;

class Program
{
    public static void triangle(int row)
    {
        for (int i=0;i<row;i++)
        {
            if (i%2==1)
            {
                Console.WriteLine(new string('%',i));
            }
            else
            {
                Console.WriteLine(new string('*',i));
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter the number of rows: ");
        int row=Convert.ToInt32(Console.ReadLine());
        triangle(row);

    }
}
