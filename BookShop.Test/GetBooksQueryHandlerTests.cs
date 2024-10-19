using BookShop.Application.Handlers;
using BookShop.Application.Queries;
using BookShop.Domain.Entities;

namespace BookShop.Test
{
    public class GetBooksQueryHandlerTests
    {
        [Fact]
        public async Task Handle_ShouldReturnListOfBooks()
        {
            var handler = new GetBooksQueryHandler();
            var result = await handler.Handle(new GetBooksQuery(), CancellationToken.None);

            Assert.NotNull(result);
            Assert.IsType<List<Book>>(result);
            Assert.NotEmpty(result);
        }
    }
}
