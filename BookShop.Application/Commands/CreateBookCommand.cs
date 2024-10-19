using MediatR;

namespace BookShop.Application.Commands
{
    public class CreateBookCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}
