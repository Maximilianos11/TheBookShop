using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetBookStore.Data.Interfaces;	

namespace InternetBookStore.Controllers
{
	public class BookController : Controller
	{
		private readonly IBook _allBooks;
		private readonly IBookList _allBookList;

		public BookController(IBook iAllBooks, IBookList iBookList)
		{
			_allBooks = iAllBooks;
			_allBookList = iBookList;

		}
		public ViewResult List()
		{
			var books = _allBooks.BookDescr;

			return View(books);
		}
	}
}

