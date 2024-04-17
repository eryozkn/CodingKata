using Xunit;

namespace CodingKata.Tests
{
    public class HelloWorldTest
    {
        [Fact]
        public void Hello_ReturnsHelloWorld() => Assert.Equal("Hello, World!", HelloWorld.Hello());
    }
}