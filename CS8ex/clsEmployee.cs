using System;
using System.Collections.Generic;
using System.Text;

namespace CS8ex
{
    class clsEmployee
    {
        //declare class variables
        protected string cstrName;
        protected int cintHours;
        protected decimal cdecRate;

        //working variables
        protected decimal cdecGross;
        protected decimal cdecUnionDues;
        protected decimal cdecNetPay;

        const decimal cdecUNION_MEMBER_NO = 0.00M;

        //Shared (static) working variables
        protected static int cintTotalCount;
        protected static decimal cdecTotalNetPay;
        protected static decimal cdecTotalGross;

       //declare constructors
        public clsEmployee()
        {
            //default constructor
        }

        public clsEmployee(string strName, int intHours,
                        decimal decRate)
        {
            //Overloaded constructor
            //Use Property Methods to assign values
            this.Name = strName;
            this.Hours = intHours;
            this.Rate = decRate;
        }

    //declare property methods
        public string Name
        {
            get
            {
                return cstrName;
            }
            set
            {
                cstrName = value;
            }
        }

        public int Hours
        {
            get
            {
                return cintHours;
            }
            set
            {
                cintHours = value;
            }
        }

        public decimal Rate
        {
            get
            {
                return cdecRate;
            }
            set
            {
                cdecRate = value;
            }
        }

    //declare read-only properties
        public decimal Gross 
        {
            get
            {
                return cdecGross;
            }
        }

        public decimal UnionDues
        {
            get
            {
                return cdecUnionDues;
            }
        }

        public decimal NetPay
        {
            get
            {
                return cdecNetPay;
            }
        }

    //declare Shared (static) ReadOnly Properites
        public static decimal TotalGross 
        {
            get
            {
                return cdecTotalGross;
            }
        }

        public static decimal TotalNetPay
        {
            get
            {
                return cdecTotalNetPay;
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
        public void calcGross()
        {
            cdecGross = cintHours * cdecRate;
        }

        public void setUnionDues()
        {
            cdecUnionDues = cdecUNION_MEMBER_NO;
        }

        public void calcNetPay()
        {
            cdecNetPay = cdecGross - cdecUnionDues;
        }

        public void accumulateTotals()
        {
            cdecTotalGross += cdecGross;
            cdecTotalNetPay += cdecNetPay;
            cintTotalCount += 1;
        }

        public static void resetTotals()
        {
            cdecTotalGross = 0;
            cdecTotalNetPay = 0;
            cintTotalCount = 0;
        }

    }//end of class
}
