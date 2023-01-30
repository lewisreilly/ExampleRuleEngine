namespace RuleEngine.Rules
{
    internal class NegativeNumberRule : IRule
    {
        public bool IsValid(int number)
        {
            return number >= 0;
        }
    }
}
