using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Dz_17_ObserverButton
{
    class Subject: ISubject
    { 
        private List<Button> _observers = new List<Button>();
         
        public void Attach(Button observer)
        { 
            MessageBox.Show($"{observer.Text}: Attached an observer.");
            _observers.Add(observer);
        }

        public void Detach(Button observer)
        {
            _observers.Remove(observer);
            MessageBox.Show($"{observer.Text}: Detached an observer."); 
        }
          
         
        public void DOWN()
        {
            foreach (var observer in _observers) 
                observer.SetBounds(observer.Location.X, observer.Location.Y + 10, observer.Size.Width, observer.Size.Height); 
        }
         
        public void UP()
        {
            foreach (var observer in _observers) 
                observer.SetBounds(observer.Location.X, observer.Location.Y - 10, observer.Size.Width, observer.Size.Height); 
        }

        public void RIGHT()
        {
            foreach (var observer in _observers) 
                observer.SetBounds(observer.Location.X + 10, observer.Location.Y, observer.Size.Width, observer.Size.Height); 
        }

        public void LEFT()
        {
            foreach (var observer in _observers) 
                observer.SetBounds(observer.Location.X - 10, observer.Location.Y, observer.Size.Width, observer.Size.Height); 
        } 
    }
}
