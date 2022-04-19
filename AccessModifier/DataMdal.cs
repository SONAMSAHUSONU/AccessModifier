using DDrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    //public: public member can we access anywhere. method, varible ,constractor
    //internal: We can access within the project 
    //Protected : We can declear using inheritance we can declear protected or using protect to inheriting the class member
    public class DataMdal//class by default private so we can not declear as a private expilicitly
    { //private can we access within a class

        private DataMdal()//we can't create object of private constractor
        {
            Dip d1 = new Dip();
            
        }
        public DataMdal(int x, int y)//we can create object of public constractor and we can call also
        {
            DataMdal d1 = new DataMdal();
            d1.GetData(); //public member we can access anywhere
            Console.WriteLine(x+y);
        }
        public string GetData()
        {
            DataMdal d1 = new DataMdal();
            return "Hi";
        }

        public string City = "Bhopal";
        public string state = "mp";
        public int age = 12;
        private long mobile = 7211971251;//private we can use within a class only
        protected bool isMale = true;
        internal char Gender = 'F';
        protected internal string Fname = "Sonam";
        internal protected string Lname = "Sahu";

    }
}
