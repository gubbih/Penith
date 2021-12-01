using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penith
{
    public interface ISubject
    {
        //private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver o)
        {

            //observers.Add(o);
        }
        public void Detach(IObserver o)
        {
            //observers.Add(o);
        }
        public void Notify()
        {
            //foreach (IObserver o in observers)
            //{
            //    o.Update();
            //}
        }
    }
}
