namespace RuleEngine.Rules
{
    internal class GreaterThan10Rule : IRule
    {
        public bool IsValid(int number)
        {
            return number <= 10;
        }
    }
}
