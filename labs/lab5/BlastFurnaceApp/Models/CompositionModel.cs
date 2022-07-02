using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlastFurnaceApp.Types;
using BlastFurnaceModel;


namespace BlastFurnaceApp
{
    public class CompositionModel : VisualObject
    {      
        private Model modelObject;
        public Model ModelObject
        {
            get { return modelObject; }
            private set { }
        }
        public int DelayMills { get; set; }
        public bool IsCanceled { get; set; }

        public Action DoSomething;
        public CompositionModel(Model model, Bitmap image, Point position) : base(image, position)
        {
            this.modelObject = model;
            DoSomething = null;
        }

    }
}
