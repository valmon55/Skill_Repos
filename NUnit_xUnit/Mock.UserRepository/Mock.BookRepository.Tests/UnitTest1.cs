using Moq;

namespace Mock.BookRepository.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FindAllTestCorrectValue()
        {
            var list = new List<Book>()
            {
                new Book() { Title = "����� � ���" },
                new Book() { Title = "�������-���������" },
                new Book() { Title = "���� ��������" }
            };
                        
            Mock<IBookRepository> mockRepository = new Mock<IBookRepository>();
            mockRepository.Setup(p => p.FindAll()).Returns(list);

            Assert.Contains(mockRepository.Object.FindAll(),b => b.Title == "����� � ���");
            Assert.Contains(mockRepository.Object.FindAll(), b => b.Title == "�������-���������");
            Assert.Contains(mockRepository.Object.FindAll(), b => b.Title == "���� ��������");

        }
    }
}