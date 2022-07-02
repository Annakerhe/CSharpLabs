using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceModel
{
    public class Worker : Model
    {
        private readonly object locker = new();

        public Action<string> Logger;
        public Worker(Action<string> logger)
        {
            this.Logger = logger;
        }

    }
}
