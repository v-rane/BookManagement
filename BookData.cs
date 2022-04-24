using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment
{
    public class BookData
    {
        /*
         * @className - BookData
         * @objective - getter setter for BookData and BookRental 
         */
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int ISBN { get; set; }
        public Decimal Price { get; set; }
        public string Author { get; set; }

        public BookData(int bookId, string bookName, int isbn, decimal price, string author)
        {
            BookId = bookId;
            BookName = bookName;
            ISBN = isbn;
            Price = price;
            Author = author;
        }

        public BookData(){}
             
        public override string ToString()
        {
            return BookId + "  ,  "+ BookName +" ,  "+ ISBN + "  , "  + Price + " , " + Author;
        }
    }
    //***********************************************************************************************************************
   
}
