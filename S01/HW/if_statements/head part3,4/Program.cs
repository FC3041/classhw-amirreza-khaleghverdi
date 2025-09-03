namespace head;

class Program
{
    public static void head(int parameter)
    {
        Console.WriteLine(new string(' ',parameter)+"^"+new string(' ',parameter));
        for (int i=1;i<parameter;i++)
        {
            Console.WriteLine(new string(' ',parameter-i)+new string('/',i)+'|'+new string('\\',i)+new string(' ',parameter-i));
        }
        
    }
    static void Main(string[] args)
    {
        Console.Write("enter the parameter: ");
        int parameter=Convert.ToInt32(Console.ReadLine());
        head((parameter+1)/2);
    }
}
