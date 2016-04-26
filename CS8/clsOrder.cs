using System;
using System.Collections.Generic;
using System.Text;

//clsOrder by Jim Harris

namespace CS8
{
    class clsOrder
    {
        //declare class variables include shared (static)

        protected string cstrDescription;
        protected int cintQuantity;
        protected decimal cdecPrice;
        protected decimal cdecExtendedPrice;

        protected static decimal cdecTotalPrice;
        protected static int cintTotalCount;

        //declare constructors

        public clsOrder()
        {
            //default constructor
        }

        public clsOrder(string strDescription, int intQuantity, decimal decPrice)
        {
            //Overloaded constructor
            //Use Property Methods to assign values
            this.Description = strDescription;
            this.Quantity = intQuantity;
            this.Price = decPrice;
        }

        //declare property methods

        public string Description
        {
            get { return this.cstrDescription; }
            set { this.cstrDescription = value; }
        }

        public int Quantity
        {
            get { return this.cintQuantity; }
            set { this.cintQuantity = value; }
        }

        public decimal Price
        {
            get { return this.cdecPrice; }
            set { this.cdecPrice = value; }
        }

        //declare read-only properties
        public decimal ExtendedPrice 
        {
            get { return this.cdecExtendedPrice; }
        }


        //declare Shared (static) ReadOnly Properites
        public static decimal TotalPrice 
        {
            get
            {
                return cdecTotalPrice;
            }
        }

        public static int TotalCount 
        {
            get
            {
                return cintTotalCount;
            }
        }

        //declare supporting methods
        public virtual void calcExtendedPrice()
        {
            cdecExtendedPrice = cintQuantity * cdecPrice;
        }

        public void accumulateTotals()  // why isn't this declared static? - Jim Harris
        {
            cdecTotalPrice += cdecExtendedPrice;
            cintTotalCount += 1;
        }

        public static void resetTotals()
        {
            cdecTotalPrice = 0;
            cintTotalCount = 0;
        }

    }//end of class
}
