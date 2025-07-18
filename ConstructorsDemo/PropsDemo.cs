using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
    namespace Demo
    {
        class Student
        {
        // property is a wrapper around pvt variable
        // it has get & set methods
        // get allows you to return value
        // set allows you to put value in the pvt variable
        // property shud be public
        int rn;
        public int Rn
        {
            get
            {
                 return rn;
            }
            set
            {
                if(value<0) rn = 0;
                rn = value;
            }
        }

        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;   
            }
        }
        //intrinsic property
        public int Score { get;   set; }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //public int DayofBirth { get; set; }
        //public string Batch { get; set; }


    }
    }

