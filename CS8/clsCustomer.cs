using System;
using System.Collections.Generic;
using System.Text;

//clsCustomer by Jim Harris

namespace CS8
{
    class clsCustomer
    {
        private string cstrName;
        private string cstrStreet;
        private string cstrCity;
        private string cstrState;
        private string cstrZip;

        // constructors

        public clsCustomer()
        {
            //default constructor
        }

        public clsCustomer(string strName, string strStreet, string strCity, string strState, string strZip)
        {
            //Overloaded constructor
            //Use Property Methods to assign values
            this.Name = strName;
            this.Street = strStreet;
            this.City = strCity;
            this.State = strState;
            this.Zip = strZip; 
        }

        public string Name
        {
            get { return this.cstrName; }
            set { this.cstrName = value; }
        }

        public string Street
        {
            get { return this.cstrStreet; }
            set { this.cstrStreet = value; }
        }

        public string City
        {
            get { return this.cstrCity; }
            set { this.cstrCity = value; }
        }

        public string State
        {
            get { return this.cstrState; }
            set { this.cstrState = value; }
        }

        public string Zip
        {
            get { return this.cstrZip; }
            set { this.cstrZip = value; }
        } 


    }
}
