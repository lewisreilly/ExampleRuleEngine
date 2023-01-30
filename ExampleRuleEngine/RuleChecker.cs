using System.Reflection;

namespace RuleEngine
{
    public class RuleChecker
    {
        private readonly IEnumerable<IRule> _rules;

        public RuleChecker()
        {
            _rules = GetRules();
        }

        public bool IsValid(int number)
        {
            return _rules.All(r => r.IsValid(number));
        }

        private IEnumerable<IRule> GetRules()
        {
            var currentAssembly = GetType().GetTypeInfo().Assembly;
            var rules = currentAssembly
                    .DefinedTypes
                    .Where(type => type.ImplementedInterfaces.Any(i => i == typeof(IRule)))
                    .Select(type => (IRule)Activator.CreateInstance(type))
                    .ToList();

            return rules;
        }
    }
}
