using BookShop.Domain.Entities;
using MediatR;

namespace BookShop.Application.Queries
{
    public class GetBooksQuery : IRequest<List<Book>>
    { 
    }
}
