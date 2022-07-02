using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceModel.Loader
{
    interface ILoader
    {
        public float Size { get; set; }
        public float LineVelocity { get; set; }       
        public int LoadCapacity { get; set; }
      
        void UpLoading();
        void DownLoading();
    }
}
