using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceModel.Loader
{
    public class BigLoader : Loader
    {
        public BigLoader(Action<string> logger) : base(logger)
        {
            Size = 1.6f;
            LineVelocity = 1;
            LoadCapacity = 2;
        }
    }
}
