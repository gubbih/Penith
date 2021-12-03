using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penith
{
    public interface IObserver
    {
        public void Update(object sender, EventArgs e);
    }
    /*public abstract class Observer: IObserver;
    {
        public abstract void Update();
    }*/
}
