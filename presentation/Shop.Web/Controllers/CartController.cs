﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Shop.Web.Models;
using StoreBook;

namespace Shop.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IBookRepository bookRepository;
        public  CartController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public IActionResult Add(int id)
        {
            var book = bookRepository.GtById(id);
            Cart cart;
            if(!HttpContext.Session.TryGetCart(out cart))
                cart = new Cart();

            if (cart.Items.ContainsKey(id))
                cart.Items[id]++;
            else
                cart.Items[id] = 1;
                cart.Amount += book.Price;

                HttpContext.Session.Set(cart);
                return RedirectToAction("Index", "Book", new {id});
        }
    }
}