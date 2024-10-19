using BookShop.Application.Commands;
using BookShop.Domain.Entities;
using MediatR;

namespace BookShop.Application.Handlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Guid>
    {
        public Task<Guid> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Author = request.Author,
                Price = request.Price,
            };

            return Task.FromResult(book.Id);
        }
    }
}
