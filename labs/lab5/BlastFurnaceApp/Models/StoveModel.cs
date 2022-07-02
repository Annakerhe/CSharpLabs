using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlastFurnaceApp.Types;
using BlastFurnaceModel;

namespace BlastFurnaceApp
{
    public class StoveModel : CompositionModel, IRunnable
    {
        private FormController formController;
        private Stove model;
        private int OverHeat = 0;
        public int Temperature { get; set; }
        public bool IsWork
        {
            get => Temperature < 1500;
        }


        public StoveModel(FormController formController, Stove model, Bitmap image, Point position) : base(model, image, position)
        {
            this.formController = formController;
            this.model = model;
            Temperature = 600;
        }

        public void Process()
        {
            model.Logger($"Старт: {ModelObject.IdName}");
            while (!IsCanceled)
            {
                if (!IsWork && OverHeat == 0)
                {
                    OverHeat = 1;
                    formController.OnStoveChangedState(new StoveEvent(ModelObject.IdName, IsWork));

                }
                if  (IsWork && OverHeat == 1)
                {
                    OverHeat = 0;
                    formController.OnStoveChangedState(new StoveEvent(ModelObject.IdName, IsWork));
                }

                Thread.Sleep(1000);
            }
        }
    }
}
