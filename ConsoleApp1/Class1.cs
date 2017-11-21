using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        //simple create property
        public string Name { get; set; }

        //create full property
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
