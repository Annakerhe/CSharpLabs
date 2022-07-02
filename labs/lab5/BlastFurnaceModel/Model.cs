using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceModel
{
    public abstract class Model
    {
        public string ModelName { get; set; }
        public int Index { get; set; }
        public string IdName { get => ModelName + "#" + Index; }
   
    }
}
