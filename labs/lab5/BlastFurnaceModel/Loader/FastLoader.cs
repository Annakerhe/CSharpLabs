using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceModel.Loader
{
    public class FastLoader : Loader
    {
        public FastLoader(Action<string> logger) : base(logger)
        {
            LineVelocity = 2;
            LoadCapacity = 1;
        }
    }
}
