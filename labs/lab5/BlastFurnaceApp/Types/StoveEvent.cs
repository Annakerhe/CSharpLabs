using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceApp.Types
{
    public class StoveEvent : EventArgs
    {
        public string ModelName;
        public bool IsWork;

        public StoveEvent(string ModelName, bool IsWork)
        {
            this.ModelName = ModelName;
            this.IsWork = IsWork;
        }
    }
}
