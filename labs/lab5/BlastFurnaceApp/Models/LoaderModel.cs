using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlastFurnaceModel;
using BlastFurnaceModel.Loader;
using BlastFurnaceApp.Types;

namespace BlastFurnaceApp.Models
{
    public class LoaderModel : CompositionModel, IRunnable, IMovable
    {
        private Loader model;
        private FormController formController;
        public LoaderState State;
        public int LineStep { get; set; }
        public bool IsFree { get; set; }
        public Point destination { get; set; }
        public Loader Model { get => model; }
        public Bitmap[] LoaderFrames = new Bitmap[]
        {
                Properties.Resources.Loader,
                Properties.Resources.Loader0,
                Properties.Resources.Loader1
        };

        public LoaderModel(FormController formController, Loader model, Point position) : base(model, Properties.Resources.Loader, position)
        {
            this.model = model;
            this.formController = formController;
            LineStep = (int)(4 * model.LineVelocity);
            DelayMills = 25;
            State = LoaderState.NONE;
            if (model.Size > 1)
                Zoom(model.Size);

            this.ImageFrame = LoaderFrames[0];
            IsFree = true;
        }

        void Zoom(float zoomFactor)
        {
            for (int i = 0; i < LoaderFrames.Length; i++)
            {
                Size newSize = new Size((int)(LoaderFrames[i].Width * zoomFactor), (int)(LoaderFrames[i].Height * zoomFactor));
                LoaderFrames[i] = new Bitmap(LoaderFrames[i], newSize);
            }
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
            }
            else
            {
                if (this.State == LoaderState.FORWARD)
                    this.State = LoaderState.DOWNLOAD;
                else
                    this.State = LoaderState.UPLOAD;
            }
        }
        public void DownLoading()
        {
            lock (this.formController.LoaderLocker)
            {
                Thread.Sleep(2000);
                this.State = LoaderState.BACK;
                Thread.Sleep(1000);
            }
        }

        public void UpLoading()
        {
            lock (this.formController.StoveLocker)
            {
                Thread.Sleep(2000);
                this.State = LoaderState.FORWARD;
                Thread.Sleep(1000);
            }
        }

        public void Operation()
        {
            switch (this.State)
            {
                case LoaderState.FORWARD:
                    this.ImageFrame = LoaderFrames[1];
                    this.destination = new Point(20, this.formController.LineOne);
                    MoveTo();
                    break;
                case LoaderState.BACK:
                    this.ImageFrame = LoaderFrames[2];
                    StoveModel stove = this.formController.FindWokedStove();
                    if (stove != null)
                        this.destination = new Point(stove.currentPosition.X - 150, stove.currentPosition.Y);
                    else
                        this.destination = new Point(800, this.formController.LineTwo);
                    MoveTo();
                    break;
                case LoaderState.DOWNLOAD:
                    DownLoading();
                    break;
                case LoaderState.UPLOAD:
                    UpLoading();
                    break;
                default:
                    break;
            }

        }

        public void Process()
        {
            this.model.Logger($"Старт: {ModelObject.IdName}");
            while (!IsCanceled)
            {
                Operation();
                //DoSomething?.Invoke();
                Thread.Sleep(DelayMills);
            }
        }

    }
}
