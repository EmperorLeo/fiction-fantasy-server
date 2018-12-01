using FictionFantasyServer.Api;
using Xunit;

namespace FictionFantasyServer.ApiTests
{
    public class BooksEndpointTests : TestBase
    {
        public BooksEndpointTests(CustomWebApplicationFactory<Startup> factory) : base(factory)
        {

        }

        [Fact]
        public void TestAddBook()
        {
            Assert.True(true);
        }
    }
}