using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        #region  

        static void Main(string[] args)
        {
            animal obj = new animal();
            obj.speak();

            obj = new dog();
            obj.speak();


            dog d = new dog();

            d.speak();
            Console.ReadKey();
        }
#endregion
    }
}