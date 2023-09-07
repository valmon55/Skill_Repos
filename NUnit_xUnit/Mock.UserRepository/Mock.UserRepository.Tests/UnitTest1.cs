using Moq;

namespace Mock.UserRepository.Tests
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
        public void FindAllTestCorrectValue()
        {
            var list = new List<User>()
            {
              new User() {Name = "Антон"},
              new User() {Name = "Иван"},
              new User() {Name = "Алексей"}
            };

            Mock<IUserRepository> mockRepository = new Mock<IUserRepository>();
            mockRepository.Setup(p => p.FindAll()).Returns(list);

            Assert.That(mockRepository.Object.FindAll().Any(u => u.Name == "Антон"));
            Assert.That(mockRepository.Object.FindAll().Any(u => u.Name == "Иван"));
            Assert.That(mockRepository.Object.FindAll().Any(u => u.Name == "Алексей"));
        }
    }
}