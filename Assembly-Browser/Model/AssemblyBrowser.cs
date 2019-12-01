using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AssemblyBrowser
    {
        // variables
        public string Name { get; private set; }
        public Dictionary<string, ExportedNsInfo> Namespaces { get; }



        // methods
        public AssemblyBrowser(string name, Dictionary<string, ExportedNsInfo> namespaces)
        {
            Name = name;
            Namespaces = namespaces;
        }



        public override string ToString()
        {
            return "Assembly " + Name;
        }

    }
}
