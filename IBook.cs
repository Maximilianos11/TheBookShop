using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetBookStore.Data.Models;

namespace InternetBookStore.Data.Interfaces
{
	public interface IBook
	{
		IEnumerable<Book> BookDescr { get; }
		Book getObjectBook(int BookId);
	}
}
