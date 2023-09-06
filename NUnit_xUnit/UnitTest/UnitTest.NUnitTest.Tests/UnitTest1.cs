namespace UnitTest.NUnitTest.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test] 
        public void MultiplicationNotNull() 
        {

            var calc = new Calculator(); 
        }
    }
}