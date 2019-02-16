using Pipeline.Domain;
using Xunit;

namespace Pipeline.Web.Tests
{
    public class PrinterShould
    {
        [Fact]
        public void PrintHelloWorld()
        {
            Assert.Equal("Hello world!", new Printer().Greet());
        }
    }
}
