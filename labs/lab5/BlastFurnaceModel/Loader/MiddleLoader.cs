using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceModel.Loader
{
    public class MiddleLoader : Loader
    {
        public MiddleLoader(Action<string> logger) : base(logger)
        {
            Size = 1.3f;
            LineVelocity = 1;
            LoadCapacity = 1;
        }
  
    }
}
