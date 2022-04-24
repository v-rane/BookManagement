using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment
{
    public class AggregateOperations
    {
        /*
         * @className - AggregateOperations
         * @objective - to aggregate and display desired data from methods
         * @autherName - Varsha Rane
         * @Date - 22-4-2022
         */
        public List<UserStatus> getUserDataGroupByStatus(List<BookRental> list)
        {
            /*
             * @methodName - getUserDataGroupByStatus
             * @objective -to get data that how many books user has returned and issued 
             * @para - List<BookRental>
             * @return - List<UserStatus>
             */

            //dic with object of UserStatus as values and key as userName
            Dictionary<string, UserStatus> dic = new Dictionary<string, UserStatus>();
            foreach (BookRental book in list)
            {
                if (dic.ContainsKey(book.UserName))
                {
                    dic[book.UserName].NumberOfBooksIssued++;
                    //if status is returned then increment in return
                    if (book.Status == "returned")
                    {
                        dic[book.UserName].NumberOfBooksReturned++;
                    }
                }
                else
                {
                    //dic does not contains username then add values in dic after creating object of userName
                    dic.Add(book.UserName, new UserStatus());
                    dic[book.UserName].UserName = book.UserName;
                    dic[book.UserName].NumberOfBooksIssued =1;
                    if (book.Status == "returned")
                    {
                        dic[book.UserName].NumberOfBooksReturned = 1;
                    }
                }
            }
            //returning list after converting into list
            return dic.Values.ToList() ;
        }

        //************************************************************************************************************
        public List<BooksIssued> GetDataGroupByIssued(List<BookData> bookData, List<BookRental> bookRental) 
        {
            /*
             * @methodName - GetDataGroupByIssued
             * @objective - to get data which book is issued by which user with details
             * @para -List<BookData> ,  List<BookRental>
             * @return -List<BooksIssued>
             */

           //dic created with key as userName from bookData as values for getting bookName from it and adding in object of bookissued  
          Dictionary<int, BookData> dic = new Dictionary<int, BookData>();
          List<BooksIssued> issuedList = new List<BooksIssued>();
            foreach (BookData book in bookData)
            {
                dic.Add(book.BookId, book);
            }
            foreach(BookRental value in bookRental)
            {
                if(value.Status == "issued")
                {
                    //if status is issued then add values in object of BooksIssued 
                    BooksIssued booksIssued = new BooksIssued();
                    booksIssued.BookId = value.BookID ;
                    //taking bookname from dic
                    booksIssued.BookName = dic[value.BookID].BookName;
                    booksIssued.BookStatus = value.Status;
                    booksIssued.UserName= value.UserName;
                    booksIssued.BookIssueDate = value.IssueDate;
                    //adding object in list
                    issuedList.Add(booksIssued);
                }
            }
            //returning issueList after adding values in it
            return issuedList ;
        }        
    }
}
