using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstConstCallChainStep310
{
    class Program
    {
        static void Main(string[] args)
        {
            var mydata = new MyData("Yun" );

            const string myName = "Min";
           

            Console.WriteLine("{0} is your first name and  {1} is your last name and you are {2} years old", myName, mydata.Name, mydata.Age);

            Console.ReadLine();

        }
  

    }
    
}
