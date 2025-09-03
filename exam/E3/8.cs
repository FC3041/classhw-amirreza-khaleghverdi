public static class LambdaProblems
{
        public static Func<string, int> GetStringLengthCalculator()
    {
        return str=> str.Length;
    }
}
