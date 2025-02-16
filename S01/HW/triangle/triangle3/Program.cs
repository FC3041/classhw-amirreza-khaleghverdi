namespace triangle1_2;

class Program
{
    public static void triangle(int row,char shape)
    {
        for (int i=0;i<row;i++)
        {
            Console.WriteLine(new string(' ',row-i) +new string(shape,i));
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter the number of rows: ");
        int row=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the shape:");
        char shape=Convert.ToChar(Console.ReadLine());
        triangle(row,shape);

    }
}
