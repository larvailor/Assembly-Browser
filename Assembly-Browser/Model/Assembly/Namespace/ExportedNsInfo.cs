using Model.Assembly.Namespace.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Assembly.Namespace
{
    public class ExportedNsInfo
    {
        // variables
        public string Name { get; set; }
        public List<ExportedTypeInfo> Types { get; private set; }



        // methods
        public ExportedNsInfo(string name, List<ExportedTypeInfo> types)
        {
            Name = name;
            Types = types;
        }



        public override string ToString()
        {
            return Name;
        }
    }
}
