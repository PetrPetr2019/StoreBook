using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Shop.Web.Models;
using StoreBook;

namespace Shop.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly IOrderRepository orderRepository;

        public  CartController(IBookRepository bookRepository,
                               IOrderRepository orderRepository)
        {
            this.bookRepository = bookRepository;
            this.orderRepository = orderRepository;
        }
        public IActionResult Add(int id)
        {

            Order order;
            Cart cart;
            if (HttpContext.Session.TryGetCart(out cart))
            {
                order = orderRepository.GetById(cart.OrderId);
            }
            else
            {
                order = orderRepository.Create();
                cart = new Cart(order.Id);
            }

               var book = bookRepository.GtById(id);
               order.AddItem(book, 1);
               orderRepository.Update(order);

               cart.ToTalCount = order.TotalCount;
               cart.TotalPrice = order.TotalPrice;

                HttpContext.Session.Set(cart);
                return RedirectToAction("Index", "Book", new {id});
        }
    }
}