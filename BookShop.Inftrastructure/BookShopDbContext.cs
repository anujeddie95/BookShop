using BookShop.Domain.Entities;

namespace BookShop.Inftrastructure
{
    public class BookShopDbContext
    {
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
