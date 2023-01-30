namespace RuleEngine.Rules
{
    internal class ZeroRule : IRule
    {
        public bool IsValid(int number)
        {
            return number != 0;
        }
    }
}
