using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment
{
    public class UserStatus
    {
        /*
        * @className - UserStatus
        * @objective -getter setter and ctor for UserStatus
        */
        public string UserName { get; set; }
        public int NumberOfBooksIssued { get; set; }
        public int NumberOfBooksReturned { get; set; }

        public UserStatus() { }
        public UserStatus(string UserName, int NumberOfBooksIssued,int numberOfbooksReturned)
        {
            this.UserName = UserName;
            this.NumberOfBooksIssued = NumberOfBooksIssued;
            this.NumberOfBooksReturned = numberOfbooksReturned;
        }
        public override string ToString()
        {
            return " user name:- "+ UserName + " ,  "+ " books issued:-  "  + NumberOfBooksIssued + "  ,  "+ "books returned:- " + NumberOfBooksReturned ;
        }
    }
}
