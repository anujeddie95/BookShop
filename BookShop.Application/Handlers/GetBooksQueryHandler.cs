using BookShop.Application.Queries;
using BookShop.Domain.Entities;
using MediatR;

namespace BookShop.Application.Handlers
{
    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, List<Book>>
    {
        public Task<List<Book>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            var books = new List<Book>
            {
                new Book {Id = Guid.NewGuid(), Title = "Book 1", Author = "Author 1", Price = 10.99m },
                new Book {Id = Guid.NewGuid(), Title = "Book 2", Author = "Author 2", Price = 21.99m }
            };

            return Task.FromResult(books);
        }
    }
}
