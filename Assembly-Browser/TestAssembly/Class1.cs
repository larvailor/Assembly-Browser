using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace1
{
    public class Class1
    {
        // variables
        public float publicField;
        private float privateField;
        public int PublicProperty { get; set; }
        public int PropertyWithPrivateSet { get; private set; }



        // methods
        public string Method1()
        {
            return "Class1";
        }



        public int MethodWithParams(int x, double y)
        {
            return 1;
        }



        private void PrivateMethod()
        {

        }
    }
}
