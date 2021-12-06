using System;

namespace topshiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            
            book book1 = new book("c++", 20_000);
            book book2 = new book("java", 25_000);
            book book3 = new book("kotlin", 25_000);

            Bookshop shop = new Bookshop("Kitoblar olami", 1_000_000);

         Console.WriteLine(shop.hasbook());
            Console.WriteLine(shop.hasbook(book1));
            //shop.sell(book1);
            Console.WriteLine(shop.buybook(book1, 40));
            Console.WriteLine(shop.getmoney()) ;
            Console.WriteLine(shop.buybook(book2, 20));
            Console.WriteLine(shop.hasbook());
            Console.WriteLine(shop.hasbook(book1)) ;
            Console.WriteLine(shop.sell(book1, 1))   ;
            Console.WriteLine(shop.sell(book3, 1))  ;
            Console.WriteLine(shop.getmoney())   ;
            Console.WriteLine(shop.getcount(book1))  ;
            Console.WriteLine(shop.getcount()) ;
            Console.WriteLine(shop.getbookshopname());






        }
    }
}
