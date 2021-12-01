using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penith.ConcreteSubject
{
    public class Organization
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public Organization(string name)
        {
            this.name = name;
        }


    }
}
