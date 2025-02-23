using System.Reflection.Metadata;

namespace parameterized_rocket;

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

    public static void line(int parameter)
    {
        Console.WriteLine('+'+new string('-',2*parameter-1)+'+');
    }
    public static void body(int parameter)
    {
        for (int i=0;i<5;i++)
        {
            Console.WriteLine('+'+new string('*',2*parameter-1)+'+');
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter parameter:");
        int a=Convert.ToInt32(Console.ReadLine());
        head(a);
        line(a);
        body(a);
        line(a);
        head(a);
        
    }
}
// x=7
// a=2*x-1
// b=x
// c=10

// def head(b):
//     print(b*" " + "^" + b*" ")
//     for i in range(1,b):
//         print((b-i)*" " + i*"/" + "|" + i*"\\" + (b-i)*" ")

// def line(a):
//     print("+" + a*"-" + "+")

// def body(a,b):
//         print("+" + a*"*" + "+")

// head(b)
// line(a)
// for i in range(c):
//     body(a,b)
// line(a)
// head(b)
// #wide=2x+1 
