using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstConstCallChainStep310
{
    public class MyData
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }



        public MyData(int yearborn, string lastname)
        {
            Age = DateTime.Now.Year - yearborn;
            Name = lastname;
            Year = yearborn;

        }
        public MyData( string lastname): this(1979, lastname)
        {

        }



    }
}
