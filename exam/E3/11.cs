public static class Closures
{
    public static Func<int> CreateCounter()
    {
            int num = 0;
        
        return () =>
        { 
            num += 1;
            return num;
        };
    }
}
