﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetBookStore.Data.Models;
using InternetBookStore.Data.Interfaces;

namespace InternetBookStore.Data.mocks
{
	public class mockbook: IBook	
	{
		public IEnumerable<Book> BookDescr
		{
			get
			{
				return new List<Book>
				{
					new Book {img="https://static.librebook.me/uploads/pics/02/26/209.jpg",
						name= "Старик и море",
						Author = "Эрнест Хемингуэй" ,
						Price =450,
						shortDesc="Поесть о старике и его любви" +
					" к морю зацепит каждого поклонника творчества Хемингуэя",
						longDesc= "Повесть американского писателя Эрнеста Хемингуэя, написанная в Бимини (Багамские острова) и вышедшая в 1952 году." +
						" Последнее известное художественное произведение Хемингуэя, опубликованное при его жизни. Рассказывает историю старика Сантьяго," +
						" кубинского рыбака о его борьбе в открытом море с гигантским марлином, который стал самой большой добычей в его жизни.",
						available=true},
					new Book {img="https://img.yakaboo.ua/media/catalog/product/cache/1/image/546x/00c1a1eab9920e00d38dc8798e6142c9/4/0/407484_61809030.jpg",
						name= "Руслан и Людмила",
						Author = "Александр Сергеевич Пушкин",
						Price = 600,
						shortDesc="Первая законченная поэма Александра Сергеевича Пушкина;" +
					" волшебная сказка, вдохновлённая древнерусскими былинами",
						longDesc="«Руслан и Людмила», по нашему мнению, одно из лучших поэтических произведений Пушкина, — это прелестный, вечно свежий, вечно душистый цветок в нашей поэзии." +
					" В этом создании наш поэт почти в первый раз заговорил языком развязным, свободным, текучим, звонким, гармоническим...",
						available=true},
					new Book {img="https://i3.mybook.io/p/512x852/book_covers/a4/72/a4721d84-6323-4f79-90e4-391f7afd41fa.jpe?v2",
						name= "Ромэо и Джульетта",
						Author = "Уильям Шекспир",
						Price =500,
						shortDesc="Трагедия Шекспира цепляющая каждого" +
					" с неожиданным финалом",
						longDesc="Трагедия Уильяма Шекспира, рассказывающая о любви юноши и девушки из двух враждующих веронских родов — Монтекки и Капулетти." +
						"Сочинение обычно датируется 1594—1595 годами. Более ранняя датировка пьесы возникала в связи с предположением о том," +
						" что работа над ней могла быть начата ещё в 1591 году, затем отложена и окончена примерно два года спустя. Таким образом," +
						" 1593 год оказывается наиболее ранней из рассматриваемых дат, а 1596 год — позднейшей, так как в следующем году текст пьесы был напечатан." +
						"Достоверность данной истории не установлена, но приметы исторического фона и жизненные мотивы, присутствующие в итальянской основе сюжета," +
						" сообщают определённое правдоподобие повести о веронских влюблённых.",
						available=true}
				};

			}
		}
		public Book getObjectBook(int BookId)
		{
			throw new NotImplementedException();
		}
	}
}