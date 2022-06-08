using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dz_17_ObserverButton
{
    interface ISubject
    {
        // Присоединяет наблюдателя к издателю.
        void Attach(Button observer);

        // Отсоединяет наблюдателя от издателя.
        void Detach(Button observer);
         
    }
}
