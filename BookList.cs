using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBookStore.Data.Models
{
	public class BookList
	{
		public int id { get; set; }
		public string Name { get; set; }
		public string Author { get; set; }
		public string Img { get; set; }
		public ushort Price { get; set; }
	}
}
