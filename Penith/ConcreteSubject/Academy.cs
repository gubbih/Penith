using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penith.ConcreteSubject
{
    public delegate void NotifyHandler();
    public class Academy : ISubject //Concrete sub
    {
        //private List<IObserver> students = new List<IObserver>();
        private NotifyHandler students;
        public NotifyHandler Students { get; set; }

        private string name = "";

        public string Name
        {
            get { return name; }
            set { name = value; }
            
        }
        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        private string message;

         public string Message
         {
             get { return message; }
             set
             {
                 message = value;
                 Notify();
             }
         }
        public Academy(string name, string adress)
        {
            this.Name = name;
            this.Adress = adress;
        }
        
        public void Attach(IObserver o)
        {
            students += o.Update;
        }
        public void Detach(IObserver o)
        {
            students -= o.Update;

        }
        public void Notify()
        {
            students.Invoke();
        }

    }
}
