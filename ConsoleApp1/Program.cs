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
        public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            animal obj = new animal();
            obj.speak();

            obj = new dog(); //animal waly obj ko use krty hoy
            obj.speak();


            dog d = new dog(); // new obj k zrye
            d.speak();




            int result = obj.age = 22; 
            Console.WriteLine(result);

            //properties ko call krna
            Class1 c = new Class1();
            c.Name = "hassan malik";
            c.Age = 20;
            Console.WriteLine("Name is {0}, and Age is {1}",c.Name,c.Age);
            
            Console.ReadKey();

        }
#endregion
    }
}