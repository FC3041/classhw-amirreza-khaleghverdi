namespace part3;

class Program
{
    public static  bool is_near(double x,double y, double closeness)
    {
        if (x<0)
        {
            x=-x;
        }
        else if (y<0)
        {
            y=-y;
        }
        double term=Math.Max(x,y)*closeness;
        if (Math.Max(x,y)-Math.Min(x,y)>term)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(is_near(25,10,0.1));
    }
}
