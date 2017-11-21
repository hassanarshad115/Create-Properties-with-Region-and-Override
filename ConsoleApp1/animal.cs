using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class animal
    {
        public virtual void speak()
        {
            Console.WriteLine("orignal class");
        }

    }

    public class dog:animal
    {
       public  override void speak()
        {
            Console.WriteLine("orignal class sy override hony wali");
        }

    }


}
