using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class DeveloperInfoAttribute : System.Attribute
    {
        public string Name { get; }
        public string datereliz { get; }

        public DeveloperInfoAttribute() { }
        public DeveloperInfoAttribute(string name, string datereliz)
        {
            Name = name;
            this.datereliz = datereliz;
        }
    }
}
