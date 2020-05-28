﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreBook;

namespace Shop.Web.Controllers
{
    public class SearchController : Controller
    {

        private readonly BookService bookService;

        public SearchController(BookService bookService)
        {
            this.bookService  = bookService;
        }
        public IActionResult Index(string query)
        {
            var books = bookService.GetAllByQuery(query);
            
            return View(books);
        }
    }
}
