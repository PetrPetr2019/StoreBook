using Microsoft.AspNetCore.Mvc;
using StoreBook;

namespace Shop.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public IActionResult Index(int id)
        {
            var book = bookRepository.GtById(id);
            return View(book);
        }
    }
}