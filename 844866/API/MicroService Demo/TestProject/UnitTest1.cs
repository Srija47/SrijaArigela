using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class TestCalculate
    {
        Calculate obj = null;
        [SetUp]
        public void Setup()
        {
            obj = new Calculate();
        }

        [Test]
        public void TestAdd()
        {
            int result = obj.Add(3, 5);
            int expected = 8;
            Assert.AreEqual(expected, result);
        }
        [Test]
        [Description("Test Greet Method")]
        public void GreetTest()
        {
            string result = obj.Greet("Sachin");
            Assert.NotNull(result);
            Assert.AreEqual("Hello Sachin",result);
        }
    }
}