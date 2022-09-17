using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.OOPS
{
    class Person
    {
        private string name; // field

        public Person(string _name)
        {
            this.name = _name;
        }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }

}
