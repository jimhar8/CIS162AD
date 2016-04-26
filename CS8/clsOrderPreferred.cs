using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Jim Harris CIS162AD

namespace CS8
{
    class clsOrderPreferred : clsOrder
    {

        private const decimal cdecDISCOUNT_RATE = 0.05M;

        //declare default constructor - call base default constructor

        public clsOrderPreferred( ) : base( )
	    {			
            //Call default constructor in base class
        } 

        //declare overloaded constructor - call base overloaded constructor
        public clsOrderPreferred(string strDescription, int intQuantity, decimal decPrice)
            : base(strDescription, intQuantity, decPrice)
        {

        }

        //override definition of virtual definition in base
        public override void calcExtendedPrice()
        {
            cdecExtendedPrice = cintQuantity *
                (cdecPrice - cdecPrice * cdecDISCOUNT_RATE);
        }


    }
}
