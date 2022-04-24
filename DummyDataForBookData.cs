using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment
{
    public class DummyDataForBookData
    {
        public List<BookData> getBookData()
        {
        /*
         * @MethodName - DummyDataForBookData
         * @objective - to provide data in BookData and create list of it
         * @return - List<BookData> 
         */
            //creating list to add data in it
            List<BookData> bookDataList = new List<BookData>();
            BookData bookData1 = new BookData(101, " MALGUDI DAYS", 12121, 200, "R.K.NARAYAN");
            BookData bookData2 = new BookData(102 ,"The Private Life of an Indian Prince",12345,300 ,"MULK RAJ ANAND");
            BookData bookData3 = new BookData(103 , "UNTOUCHABLE" ,123456 ,500 ,"MULK RAJ ANAND");
            BookData bookData4 = new BookData(104 , "TRAIN TO PAKISTAN " , 134435,700, "KHUSHWANT SINGH");
            BookData bookData5 = new BookData(105 ,"  GODAN  ", 67879, 900, "JAI RATAN");
            BookData bookData6 = new BookData(106 ," THE ROOM ON THE ROOF",32543,600," RUSKIN BOND");
            BookData bookData7 = new BookData(107, "the story of my life", 546, 890, "Hellen keller");
            BookData bookData8 = new BookData(108 ,"gulliver travels" ,66889,200 ,"gulliver");
            BookData bookData9 = new BookData(109,"the invisible man",6887,100,"steven");
            BookData bookData10 = new BookData(110 ,"the hulk" ,7987, 500, "silvester stallon");
            //adding objects of bookData in list
            bookDataList.Add(bookData1);
            bookDataList.Add(bookData2);
            bookDataList.Add(bookData3);
            bookDataList.Add(bookData4);
            bookDataList.Add(bookData5);
            bookDataList.Add(bookData6);
            bookDataList.Add(bookData7);
            bookDataList.Add(bookData8);
            bookDataList.Add(bookData9);
            bookDataList.Add(bookData10);

            return bookDataList;
        }
    }
}
