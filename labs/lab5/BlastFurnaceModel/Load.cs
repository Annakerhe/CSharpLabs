using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlastFurnaceModel
{
    public class Load : Model
    {
        private int payLoad;
        public int PayLoad { get => payLoad; }

        public Action<string> Logger;
        public Load(Action<string> logger, int payLoad)
        {
            this.Logger = logger;
            this.payLoad = payLoad;
        }        
    }
}
