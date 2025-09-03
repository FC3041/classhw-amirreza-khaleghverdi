namespace S21;

class Program
{
    public static IEnumerable<string> GetNames()
    {
        yield return "ali";
        yield return "fateme";
        yield return "zahra";
    }


    static void Main(string[] args)
    {
        string[] lines=File.ReadAllLines("children-per-woman-UN.csv");

        foreach(var item in  lines.Take(10))
            System.Console.WriteLine(item);

    }

    
    static void Main1(string[] args)
    {
        foreach(var item in GetNames())
            System.Console.WriteLine(item);
        // Console.WriteLine("Hello, World!");
    }
}
