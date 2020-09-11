using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetBookStore.Data.Models;

namespace InternetBookStore.Data.Interfaces
{
	public interface IBookList
	{
		IEnumerable<BookList> AllBooks { get; }
	}
}
