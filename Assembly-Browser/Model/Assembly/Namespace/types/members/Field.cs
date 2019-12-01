using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Assembly.Namespace.Types.Members
{
    public class Field
    {
        // methods
        public string Name { get; private set; }
        public string Attributes { get; private set; }
        public string Type { get; private set; }



        // methods
        public Field(string name, string attributes, string type)
        {
            Name = name;
            Attributes = attributes;
            Type = type;
        }



        public override string ToString()
        {
            return Attributes + " " + Type + " " + Name;
        }
    }
}
