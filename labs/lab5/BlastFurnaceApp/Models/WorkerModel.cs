using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlastFurnaceApp.Types;
using BlastFurnaceModel;
using BlastFurnaceApp.Models;

namespace BlastFurnaceApp
{
    public class WorkerModel : CompositionModel, IMovable, IRunnable
    {
        const int ShiftPosition = 32;

        private Worker model;
        private FormController formController;
        public LoaderModel RefLoaderModel { get; set; }
        public bool IsConnected
        {
            get => RefLoaderModel != null;
        }
        public bool IsInside { get; set; }

        Point destination;

        public WorkerModel(FormController formController, Worker model, Bitmap image, Point position) : base(model, image, position)
        {
            this.model = model;
            DelayMills = 30;
            LineStep = 3;

            this.formController = formController;
            this.formController.NewLoadArrive += new EventHandler(this.Load_NewArrived);
            this.formController.EmptyBoxEvent += new EventHandler(this.Load_EmptyHandling);
            this.formController.StoveEvent += new EventHandler(this.Stove_EventHandling);

        }

        private int _lineStep;
        public int LineStep
        {
            get => _lineStep;
            set => _lineStep = value;
        }

        public bool NeedMove(Point destination)
        {
            return Math.Abs(destination.X - GetXPosition()) >= LineStep || Math.Abs(destination.Y - GetYPosition()) >= LineStep;
        }

        public void MoveTo()
        {
            if (NeedMove(destination))
            {
                this.currentPosition.Y += LineStep * (destination.Y - this.currentPosition.Y) / Math.Abs(destination.X - this.currentPosition.X);
                this.currentPosition.X += LineStep * Math.Sign(destination.X - this.currentPosition.X);
                //this.model.Logger($"X: {this.currentPosition.X} - Y: {this.currentPosition.Y}");
            }
            else if (IsConnected)
            {
                Thread.Sleep(500);
                IsInside = true;
                Thread.Sleep(500);
                if (this.RefLoaderModel.State == LoaderState.NONE)
                    this.RefLoaderModel.State = LoaderState.FORWARD;
            }
        }
        private void FindFreeLoader()
        {
            this.RefLoaderModel = this.formController.FindFreeLoader();
            if (IsConnected)
            {
                this.RefLoaderModel.IsFree = false;
                this.model.Logger("Catch: " + RefLoaderModel.ModelObject.IdName);
                destination = new Point(RefLoaderModel.GetXPosition() + 150, RefLoaderModel.GetYPosition() + 50);
            }
            DoSomething -= FindFreeLoader;
        }

        public void Process()
        {
            this.model.Logger($"Старт: {ModelObject.IdName}");
            while (!IsCanceled)
            {
                if (!IsConnected)
                    destination = new Point(formController.WorkerPlace.X + ModelObject.Index * ShiftPosition, formController.WorkerPlace.Y);

                MoveTo();
                DoSomething?.Invoke();
                Thread.Sleep(DelayMills);
            }
        }

        public void Load_NewArrived(object sender, EventArgs e)
        {
            if (e is LoadEventArgs)
            {
                Load loadObj = (e as LoadEventArgs).coolArrive;
                int mass = loadObj.PayLoad;
                this.model.Logger($"{ModelObject.IdName}: Подвезли материал {mass}кг");
            }
            if (!IsConnected)
                DoSomething += FindFreeLoader;
        }

        public void Stove_EventHandling(object sender, EventArgs e)
        {
            if (sender is FormController)
            {
                bool IsWork = ((StoveEvent)e).IsWork;
                string objectId = ((StoveEvent)e).ModelName;
                if (!IsWork)
                {
                    this.model.Logger($"{objectId}: Перегрев печи");
                    //Стоп работа. Запустить охлаждение
                    Task.Factory.StartNew(() =>
                    {
                        Thread.Sleep(2000);
                        this.formController.StoveColling(objectId);
                    });
                }
                else
                {
                    this.model.Logger($"{objectId}: В работе");
                    //Поехали дальше
                }
            }
        }

        public void Load_EmptyHandling(object sender, EventArgs e)
        {
            if (e is EmptyBoxesEvent)
            {
                this.model.Logger($"{ModelObject.IdName}: Закончился материал");
            }
        }

    }
}
