using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class animal
    {


        //override k lye

        public virtual void speak() //virtual etc lazmi h
        {
            Console.WriteLine("orignal class");


        }
        #region

        // HASSAN MALIK FROM PAKISTAN
        #endregion

    }
    //ye ab alg class bnyge complete

    public class dog : animal
    {
        public override void speak()
        {
            Console.WriteLine("orignal class sy override hony wali");
        }

    }


}
