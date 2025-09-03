public class Comparer<T> where T: IComparable<T>
{
    private T A;

    private T B;

    public Comparer(T a, T b)
    {
        A=a;
        B=b;
    }

    public T GetLarger()
    {
        return A.CompareTo(B) >= 0 ? A : B;
    }
}

public class Product: IComparable<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Product other)
    {
        if (other == null)
        {
            return 1;
        }
            
        return Price.CompareTo(other.Price);
    }
}
