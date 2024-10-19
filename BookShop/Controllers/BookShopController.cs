using BookShop.Application.Commands;
using BookShop.Application.Queries;
using BookShop.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookShopController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookShopController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBookCommand command)
        {
            var bookId = await _mediator.Send(command);
            return Ok(bookId);
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get()
        {
            var books = await _mediator.Send(new GetBooksQuery());
            return Ok(books);
        }
    }
}
