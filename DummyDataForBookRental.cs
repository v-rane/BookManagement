using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment
{
    public class DummyDataForBookRental
    {
        /*
         * @ClassName - DummyDataForBookRental
         * @objective- to provide data in BookRental and create list of it
         * @return - List<BookRental>
         */
        public List<BookRental> getDummyBookRentalData()
        {
            //creating list and adding data by creating object of BookRental
            List<BookRental> bookRentalList = new List<BookRental>();
            BookRental bookRental1 = new BookRental(1 , 101, "varsha" , new DateTime(2021,12,04), "issue" , new DateTime(2022,4,06) , 451001);
            BookRental bookRental2 = new BookRental(2 , 102 ,"ganesh" ,new DateTime(2021, 1, 04) , "returned" , new DateTime(2022, 4, 06) , 451001);
            BookRental bookRental3 = new BookRental(3 ,  103, "umesh" , new DateTime( 2022,3,07) , "issue " , new DateTime(2022, 7, 19),  451002);
            BookRental bookRental4 = new BookRental(4 , 104," jeson " , new DateTime(2022, 7, 07), "returned",  new DateTime(2022, 4, 06) , 451001);
            BookRental bookRental5 = new BookRental(5 , 105, "kartik ", new DateTime(2022, 12, 07)  ,"issue ",  new DateTime(2022, 8, 1) , 451003);
            BookRental bookRental6 = new BookRental(6 ,106 ,"harsha ", new DateTime(2022, 3, 5), " issue ",  new DateTime(2022, 9, 05), 451006);
            BookRental bookRental7 = new BookRental(7 ,106 ,"nalin " , new DateTime(2022, 3, 7) ,"issue"  , new DateTime(2022, 10, 16) , 451001);
            BookRental bookRental8 = new BookRental(8 , 107, "manoj"  , new DateTime(2022, 7, 8), "returned", new DateTime(2022, 10, 06), 451003);
            BookRental bookRental9 = new BookRental(9 ,109, "sakshi" , new DateTime(2022, 5, 5) , " issued ", new DateTime(2022, 9, 7), 451001);
            BookRental bookRental10 = new BookRental(10, 110, "baban", new DateTime(2022, 3, 12), " issue" , new DateTime(2022, 9, 06) , 451002);
            //adding data objects in bookRentalList
            bookRentalList.Add(bookRental1);
            bookRentalList.Add(bookRental2);
            bookRentalList.Add(bookRental3);
            bookRentalList.Add(bookRental4);
            bookRentalList.Add(bookRental5);
            bookRentalList.Add(bookRental6);
            bookRentalList.Add(bookRental7);
            bookRentalList.Add(bookRental8);
            bookRentalList.Add(bookRental9);
            bookRentalList.Add(bookRental10);
            return bookRentalList;
        }
    }
}
