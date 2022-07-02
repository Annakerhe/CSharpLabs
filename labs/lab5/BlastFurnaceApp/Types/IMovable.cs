using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlastFurnaceApp.Types
{
    interface IMovable
    {
        int LineStep { get; set; }
        int DelayMills { get; set; }
        void MoveTo();
    }
}
