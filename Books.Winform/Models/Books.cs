using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksModels
{
    public class Books
    {
        private int  _id;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return  _id; }
            set {  _id = value; }
        }

        private string  _bookname;
        /// <summary>
        /// 
        /// </summary>
        public string BookName
        {
            get { return  _bookname; }
            set {  _bookname = value; }
        }

        private Decimal  _buyprice;
        /// <summary>
        /// 
        /// </summary>
        public Decimal BuyPrice
        {
            get { return  _buyprice; }
            set {  _buyprice = value; }
        }

        private DateTime  _buydate;
        /// <summary>
        /// 
        /// </summary>
        public DateTime BuyDate
        {
            get { return  _buydate; }
            set {  _buydate = value; }
        }

        private int  _flag;
        /// <summary>
        /// 
        /// </summary>
        public int Flag
        {
            get { return  _flag; }
            set {  _flag = value; }
        }
    }
}
