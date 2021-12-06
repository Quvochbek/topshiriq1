using System;
using System.Collections.Generic;
using System.Text;

namespace topshiriq
{
    class Bookshop
    {
        public int kitoblarsoni=0;
        public int jamipul;
        public string nomi;
        
        public Bookshop(string name, int cost) {
            nomi = name;
           jamipul = cost;
        }
         public  bool hasbook() { return kitoblarsoni!=0; }
        public bool hasbook(book book1) { return book1.kitoblarsoni!=0; }
        public int buybook(book book1,int buysoni) {
            
                if (jamipul / book1.narxi < buysoni) buysoni =  jamipul / book1.narxi;

            jamipul -= (book1.narxi * buysoni);
            book1.kitoblarsoni += buysoni;
            kitoblarsoni += buysoni;

            return buysoni;
        }
        public int getmoney() { 
            return jamipul; }
        public int getcount() { return kitoblarsoni; }

        public int getcount(book book1) { return book1.kitoblarsoni; }

        public int sell(book book1,int buysoni) {
            if (book1.kitoblarsoni >= buysoni)
            {
                book1.kitoblarsoni -= buysoni;
                kitoblarsoni -= buysoni;

                return buysoni;
            }
            else return 0;
        }

        public string getbookshopname() { return "Kitoblar olami"; }






    }
}
