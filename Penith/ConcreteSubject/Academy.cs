using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penith.ConcreteSubject
{
    //public delegate void NotifyHandler();
    public delegate void EventHandler(object sender, EventArgs e);
    public class Academy : INotifyMessageChanged //Concrete sub
    {
        //private List<IObserver> students = new List<IObserver>();
        private EventHandler messageChanged;
        public event EventHandler MessageChanged
        { 
            add { messageChanged += value; } 
            remove { messageChanged -= value; } 
        }

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
                this.OnMessageChanged();
             }
         }
        public Academy(string name, string adress)
        {
            this.Name = name;
            this.Adress = adress;
        }
        

        /*public void Attach(IObserver o)
        {
            MessageChanged += o.Update;
        }
        public void Detach(IObserver o)
        {
            MessageChanged -= o.Update;
        }*/
        public void OnMessageChanged()
        {
            if (messageChanged != null)
                messageChanged(this, null);
        }

    }
}
