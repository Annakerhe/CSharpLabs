using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceModel.Loader
{
    public abstract class Loader : Model, ILoader
    {
        public Loader(Action<string> logger)
        {
            this.Logger = logger;
            Size = 1;
        }

        public Action<string> Logger;
   
        public float Size { get; set; }
        public float LineVelocity { get; set; }
        public int LoadCapacity { get; set; }

        public void DownLoading()
        {
            Thread.Sleep(1000);
        }

        public void UpLoading()
        {
            Thread.Sleep(1000);
        }
 
    }
}
