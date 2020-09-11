using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetBookStore.Data.Models;
using InternetBookStore.Data.Interfaces;

namespace InternetBookStore.Data.mocks
{
	public class MockList : IBookList
	{
		public IEnumerable<BookList> AllBooks
		{
			get
			{
				return new List<BookList>
				{
					new BookList {Name= "Ромэо и Джульетта", Author = "Уильям Шекспир", Price =500},
					new BookList {Name= "Руслан и Людмила", Author = "Александр Сергеевич Пушкин", Price = 600},
					new BookList {Name= "Старик и море", Author = "Эрнест Хемингуэй" , Price =450}
				};

			}
		}
	}
}
