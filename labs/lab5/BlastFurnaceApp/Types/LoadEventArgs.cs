using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlastFurnaceModel;

namespace BlastFurnaceApp.Types
{
    public class LoadEventArgs: EventArgs
    {
        public Load coolArrive;

        public LoadEventArgs(Load coolArrive)
        {
            this.coolArrive = coolArrive;
        }
    }

}
