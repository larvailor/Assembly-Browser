using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssembly
{
    public class Class1
    {
        // variables
        private int field;
        public int Property1 { set; get; }



        // methods
        public string RturnStringMethods(int x = 1)
        {
            field = x;
            return "Class1";
        }

    }
}
