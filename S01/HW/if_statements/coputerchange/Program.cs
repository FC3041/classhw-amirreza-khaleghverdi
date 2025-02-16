namespace coputerchange;

class Program
{
    public static void computer_change(int amount)
    {
        if (amount>100)
        {
            Console.WriteLine("amount is more than 100");
            return;
        }
        else
        {
            int cent=amount;
            int quarters=amount/25;
            amount=amount%25;

            int dimes=amount/10;
            amount=amount%10;

            int nickels=amount/5;
            amount=amount%5;

            int pennies=amount;
            Console.WriteLine(cent+" cent is "+quarters+" quarters "+ dimes+" dimes "+nickels+" nickels "+pennies+" pennies");
            
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter cent amount: ");
        int amount=Convert.ToInt32(Console.ReadLine());
        computer_change(amount);
    }
}
