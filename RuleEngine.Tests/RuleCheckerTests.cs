using NUnit.Framework;

namespace RuleEngine.Tests
{
    [TestFixture]
    public class RuleCheckerTests
    {
        private readonly RuleChecker _ruleChecker = new RuleChecker();

        [TestCase(1)]
        [TestCase(10)]
        public void A_number_between_1_and_10_is_valid(int number)
        {
            Assert.That(_ruleChecker.IsValid(number), Is.True);
        }

        [Test]
        public void Zero_is_invalid()
        {
            Assert.That(_ruleChecker.IsValid(0), Is.False);
        }

        [Test]
        public void Negative_numbers_are_invalid()
        {
            Assert.That(_ruleChecker.IsValid(-1), Is.False);
        }

        [Test]
        public void A_number_greater_than_10_is_invalid()
        {
            Assert.That(_ruleChecker.IsValid(11), Is.False);
        }
    }
}