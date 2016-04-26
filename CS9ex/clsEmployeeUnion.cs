using System;
using System.Collections.Generic;
using System.Text;

//Juan Marquez - clsEmployeeUnion used to process Union Members

namespace CS9ex
{
    class clsEmployeeUnion : clsEmployee 
    {
       private const decimal cdecUNION_MEMBER_YES = 10.00M;

        public clsEmployeeUnion()
            : base()
        {
            // default constructor
        }

        public clsEmployeeUnion(string strName, int intHours, decimal decRate)
            : base(strName, intHours, decRate)
        {
            //Overloaded constructor
            //call base-class constructor and pass the values
        }

        //override definition of virtual definition in base
        public override void setUnionDues()
        {
            cdecUnionDues = cdecUNION_MEMBER_YES;
        }
    }//end of class
}
