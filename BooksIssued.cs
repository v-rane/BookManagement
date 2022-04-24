using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment
{
    public class BooksIssued
    {
        /*
         * @className - BooksIssued
         * @objective -getter setter and ctor for BooksIssued
         */
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookStatus { get; set; }
        public string UserName { get; set; }
        public DateTime BookIssueDate { get; set; }

        public BooksIssued() { }
        public BooksIssued(int id ,string name ,string status ,string uName,DateTime date)
        {
            this.BookId = id;
            this.BookName = name;
            this.BookStatus = status;
            this.BookIssueDate = date;

        }
    }
}
