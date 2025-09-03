public static class DelegateProblems
{
    public delegate string StringProcessor(string input);

    public static string ProcessString(string input, StringProcessor processor)
    {
        return processor(input);
    }

    public static string ToLower(string input) => input.ToLower();
    public static string ToUpper(string input) => input.ToUpper();
    
}
