using MainProject;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(5, 5, 10)]
        [InlineData(0, 0, 0)]
        public void AddTest(int num1, int num2, int expected)
        {
            //Arrange
            var methodInstance = new Method();

            //Act
            var actual = methodInstance.Add(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 30, -10)]

        public void SubtractTest(int num1, int num2, int expected)
        {
            //Arrange
            var methodInstance = new Method();

            //Act
            var actual = methodInstance.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Seth", "Hello, Seth!")]
        [InlineData("John", "Hello, John!")]
        [InlineData("", "Hello!")]
        [InlineData(null, "Hello!")]

        public void GreetingTest(string name, string expected)
        {
            //Arrange
            var methodsInstance = new Method();

            //Act
            var actual = methodsInstance.Greeting(name);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}