using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment
{
    public class Execution
    {
        static void Main(string[] args)
        {
            DummyDataForBookRental dummyDataForBookRental = new DummyDataForBookRental();
            List<BookRental> rentalList = dummyDataForBookRental.getDummyBookRentalData();
            Console.WriteLine(" Data of book is: ");
            foreach (BookRental bookRental in rentalList)
            {
                Console.WriteLine(bookRental);
            }
            Console.WriteLine("********************************************************************************");

            DummyDataForBookData dummyDataForBookData = new DummyDataForBookData();
            List<BookData> bookList =dummyDataForBookData.getBookData();
            foreach (BookData bookData in bookList)
            {
                Console.WriteLine(bookData);
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("                                                            ");
            //*************************************************************************************************

            //problem 1:=
            //calling method of AggregateOperations by creating object of it
            AggregateOperations aggregateOperations = new AggregateOperations();
            List<UserStatus> Userlist = aggregateOperations.getUserDataGroupByStatus(rentalList);
            //iterating list and displaying fields of userStatus
            foreach (UserStatus userStatus in Userlist)
            {
                System.Console.WriteLine(userStatus);
            }
            Console.WriteLine("***********************************************************************");
            //********************************************************************************************************

            //problem 2:=
            List<BooksIssued> issuedList =aggregateOperations.GetDataGroupByIssued(bookList, rentalList);
            //iterating list
            foreach(BooksIssued issued in issuedList)
            {
                Console.WriteLine(issued);
            }

        }
    }
}
