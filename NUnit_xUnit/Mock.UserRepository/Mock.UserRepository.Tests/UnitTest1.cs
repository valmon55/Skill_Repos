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
              new User() {Name = "�����"},
              new User() {Name = "����"},
              new User() {Name = "�������"}
            };

            Mock<IUserRepository> mockRepository = new Mock<IUserRepository>();
            mockRepository.Setup(p => p.FindAll()).Returns(list);

            Assert.That(mockRepository.Object.FindAll().Any(u => u.Name == "�����"));
            Assert.That(mockRepository.Object.FindAll().Any(u => u.Name == "����"));
            Assert.That(mockRepository.Object.FindAll().Any(u => u.Name == "�������"));
        }
    }
}