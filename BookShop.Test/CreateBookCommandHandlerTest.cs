using BookShop.Application.Commands;
using BookShop.Application.Handlers;

namespace BookShop.Test
{
    public class CreateBookCommandHandlerTests
    {
        [Fact]
        public async Task Handle_ShouldReturnNewBookId()
        {
            var command = new CreateBookCommand
            {
                Title = "Test Book",
                Author = "Test Author",
                Price = 8.99m
            };

            var handler = new CreateBookCommandHandler();
            var result = await handler.Handle(command, CancellationToken.None);

            Assert.NotEqual(Guid.Empty, result);

        }
    }
}
