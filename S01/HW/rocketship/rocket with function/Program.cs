namespace rocket_with_function;

class Program
{
    public static void head()
    {
        Console.WriteLine("    ^");
        Console.WriteLine("   /|\\");
        Console.WriteLine("  //|\\\\");
        Console.WriteLine(" ///|\\\\\\");   
    }
    public static void body()
    {
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");
        Console.WriteLine("+*******+");
    }
    public static void line()
    {
        Console.WriteLine("+-------+");
    }
    static void Main(string[] args)
    {
        head();
        line();
        body();
        line();
        body();
        line();
        head();
    }
}
