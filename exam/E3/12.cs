public class SafeCounter
{
    private int count = 0;
    private  object _lock = new object();

    public int Count => count;

    public void Increment()
    {
        lock (_lock)
        {
            count++;
        }
    }
}
