using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Property
    {
        // variables
        public string Name { get; private set; }
        public string SetMethod { get; private set; }
        public string GetMethod { get; private set; }



        // methods
        public Property(string name, string setMethod, string getMethod)
        {
            Name = name;
            SetMethod = setMethod;
            GetMethod = getMethod;
        }



        public override string ToString()
        {
            string result = Name;
            if (GetMethod != null)
            {
                result += "{ " + GetMethod + " get; }";
            }

            if (SetMethod != null)
            {
                result += "{ " + SetMethod + " set; }";
            }

            return result;
        }
    }
}
