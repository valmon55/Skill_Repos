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
                new Book() { Title = "Война и мир" },
                new Book() { Title = "Человек-невидимка" },
                new Book() { Title = "Анна Каренина" }
            };
                        
            Mock<IBookRepository> mockRepository = new Mock<IBookRepository>();
            mockRepository.Setup(p => p.FindAll()).Returns(list);

            Assert.Contains(mockRepository.Object.FindAll(),b => b.Title == "Война и мир");
            Assert.Contains(mockRepository.Object.FindAll(), b => b.Title == "Человек-невидимка");
            Assert.Contains(mockRepository.Object.FindAll(), b => b.Title == "Анна Каренина");

        }
    }
}