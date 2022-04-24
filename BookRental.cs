using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment
{
    public class BookRental
    {
        public int id { get; set; }
        public int BookID { get; set; }
        public string UserName { get; set; }
        public DateTime IssueDate { get; set; }
        public string Status { get; set; }
        public DateTime ReturnData { get; set; }
        public int PinCode { get; set; }

        public BookRental() { }
        public BookRental(int id, int BookID,string UserName, DateTime IssuedDate, String status, DateTime ReturnDate, int Pincode)
        {
            this.id = id;
            this.BookID = BookID;
            this.UserName = UserName;
            this.IssueDate = IssuedDate;
            this.Status = status;
            this.ReturnData = ReturnDate;
            this.PinCode = Pincode;

        }
        public override string ToString()
        {
            return id + "," + BookID + "," + UserName + "," + IssueDate + "," + Status + "," + ReturnData + "," + PinCode;
        }
    }
}
