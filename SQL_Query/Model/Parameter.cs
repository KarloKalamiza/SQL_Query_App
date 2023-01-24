using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Query.Model
{
    public class Parameter
    {
        public string Name { get; set; }
        public string Mode { get; set; }
        public string DataType { get; set; }
        public override string ToString() => $"{Mode} {Name} ({DataType})";
    }
}
