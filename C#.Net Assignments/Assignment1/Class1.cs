using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
     class Class1
    {

        private string _name; //data field
        private int _age; // data field

        public string Name //Property
        {
            get
            {
                return _name;
            } 
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18 && value <= 65)
                    _age = value;
                else
                    Console.WriteLine("Not done");

            }
        }


    }
}
