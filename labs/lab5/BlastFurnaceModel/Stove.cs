using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceModel
{
    public class Stove : Model
    {
        public Action<string> Logger;
        public Stove(Action<string> logger)
        {
            this.Logger = logger;
        }
    }
}
