public static class LinqProblems
{
    public static IEnumerable<int> FilterAndDouble(IEnumerable<int> nums)
    {

        return nums.Where(n =>n% 2 == 0 && n > 5).Select(n => n * 2);
    }


    public static Dictionary<string, int> GetTotalAmountByCategory(IEnumerable<Sale> sale)
    {
        return sale.GroupBy(s => s.Category).ToDictionary(g => g.Key, g => g.Sum(sale => sale.Amount));
    }
} 

public class Sale
{
    public int Amount { get; set; }
    public string Category { get; set; }
}

