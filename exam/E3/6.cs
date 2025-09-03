public class Money : IEquatable<Money>
{
    public int Amount { get; set; }
    public string Currency { get; set; }
 
    public Money(int amount, string currency)
    {
        Amount= amount;
        Currency= currency;
    }

    public static Money operator +(Money a, Money b)
    {
        return new Money(b.Amount+a.Amount, a.Currency);
    }

    public static bool operator ==(Money a, Money b)

    {
        if (ReferenceEquals(a, b)) 
        {
            return true;
        }
        if (a is null || b is null) 
        {
            return false;
        }
        return a.Equals(b);
    }

    public static bool operator !=(Money a, Money b) => !(a == b);

    public bool Equals(Money other)
    {
        if (other is null)
        {
            return false;
        }
        return Amount == other.Amount && Currency == other.Currency;
    }
}
