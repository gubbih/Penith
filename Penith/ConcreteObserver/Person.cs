using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penith.ConcreteObserver
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name)
        {
            this.name = name;
        }
        
    }
}
