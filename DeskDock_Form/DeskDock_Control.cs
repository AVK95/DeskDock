//TOP LEVEL INTERFACE FOR A DESK DOCK CONTROL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskDock_Form
{
    internal interface DeskDock_Control
    {
        //Name is shown as tooltip and used to refer internally
        public string Name { get; }

        //Description is shown when trying to add this control from the controls selector
        public string Description { get; }

        public Version Version { get; }
        
        //Icon displayed on the control
        public Bitmap Icon { get; }

        //Todo: Add required methods
        public void Clicked();

    }
}
