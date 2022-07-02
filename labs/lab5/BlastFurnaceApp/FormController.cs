using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlastFurnaceModel;
using BlastFurnaceModel.Loader;
using BlastFurnaceApp.Models;
using BlastFurnaceApp.Types;

namespace BlastFurnaceApp
{
    public class FormController
    {
        const int FurnaceLimit = 2;
        const int WorkerLimit = 4;
        const int LoaderLimit = 4;
        const int BoxCapacity = 8;
        const int lineOne = 200;
        const int lineTwo = 500;

        public int LineOne { get => lineOne; }
        public int LineTwo { get => lineTwo; }

        public readonly object LoaderLocker = new();
        public readonly object StoveLocker = new();

        private Action<string> _logger;

        public Point BoxStrorePos;
        public Point LoaderParking;
        public Point WorkerPlace;
        private Random random;
        public List<StoveModel> FurnaceContainer;
        public List<Load> BoxContainer;
        public List<WorkerModel> WorkerContainer;
        public List<LoaderModel> LoaderContainer;

        public FormController(Action<string> logger)
        {
            this._logger = logger;
            this.FurnaceContainer = new List<StoveModel>();
            this.BoxContainer = new List<Load>();
            this.LoaderContainer = new List<LoaderModel>();
            this.WorkerContainer = new List<WorkerModel>();

            BoxStrorePos = new Point(20, 550);
            LoaderParking = new Point(920, LineOne);
            WorkerPlace = new Point(800, 600);
            random = new Random();
        }

        public void Init()
        {
            FurnaceAdd();
            WorkerAdd();
        }

        public void AddBoxes(int count)
        {
            if (BoxContainer.Count < BoxCapacity)
            {
                for (int i = 0; i < count; i++)
                {
                    Load payLoad = new Load(this._logger, random.Next(3, 6));
                    this.BoxContainer.Add(payLoad);
                    this.OnNewBoxAppeared(new LoadEventArgs(payLoad));
                    Thread.Sleep(1000);
                }
            }
            else if (random.Next(1, 25) % 9 == 0)
            {
                BoxContainer.Clear();
                this.OnEmptyBoxEvent(new EmptyBoxesEvent());
            }
            else
                this.OnNewBoxAppeared(new EventArgs());
        }


        public void StoveColling(string ObjectId)
        {
            foreach (StoveModel item in FurnaceContainer)
            {
                if (item.ModelObject.IdName == ObjectId)
                {
                    while (item.Temperature > 800)
                    {
                        this._logger(ObjectId + " T = " + item.Temperature);
                        item.Temperature -= random.Next(10, 40);
                        Thread.Sleep(2000);
                    }
                }
            }
        }
        public StoveModel FindWokedStove()
        {
            foreach (StoveModel item in FurnaceContainer)
            {   if (item.IsWork)
                  return item;
            }
            return null;
        }
        public void FurnaceAdd()
        {
            if (this.FurnaceContainer.Count >= FurnaceLimit)
            {
                MessageBox.Show($"Превышено максимальное количество = {FurnaceLimit}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Stove newStove = new Stove(this._logger);
            newStove.ModelName = "Домна";
            newStove.Index = this.FurnaceContainer.Count;

            Bitmap image = Properties.Resources.stove;
            Point startPoint = new Point(1100, 190 + (200 * newStove.Index));
            StoveModel newStoveObj = new StoveModel(this, newStove, image, startPoint);
            this.FurnaceContainer.Add(newStoveObj);
            Task.Run(newStoveObj.Process);
        }

        public void LoaderAdd(string type)
        {
            if (this.LoaderContainer.Count >= LoaderLimit)
            {
                MessageBox.Show($"Превышено максимальное количество = {LoaderLimit}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Loader model;
            switch (type)
            {
                case "BIG":
                    model = new BigLoader(this._logger);
                    break;
                case "FAST":
                    model = new FastLoader(this._logger);
                    break;
                default:
                    model = new MiddleLoader(this._logger);
                    break;
            }
            model.ModelName = "Погрузчик";
            model.Index = this.LoaderContainer.Count;

            Point position = new Point(LoaderParking.X, LoaderParking.Y + LoaderContainer.Count * 100);
            LoaderModel loaderModel = new LoaderModel(this, model, position);
            LoaderContainer.Add(loaderModel);
            Task.Run(loaderModel.Process);
        }

        public void WorkerAdd()
        {
            if (this.WorkerContainer.Count >= WorkerLimit)
            {
                MessageBox.Show($"Превышено максимальное количество = {WorkerLimit}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Worker newWoker = new Worker(this._logger);
            newWoker.ModelName = "Рабочий";
            newWoker.Index = this.WorkerContainer.Count;

            Bitmap image = Properties.Resources.Worker;
            Point startPoint = new Point(random.Next(20, 200), random.Next(10, 100));

            WorkerModel newWorkerObj = new WorkerModel(this, newWoker, image, startPoint);
            this.WorkerContainer.Add(newWorkerObj);
            Task.Run(newWorkerObj.Process);

        }

        public LoaderModel FindFreeLoader()
        {
            lock (LoaderLocker)
            {
                foreach (LoaderModel item in LoaderContainer)
                {
                    if (item.IsFree)
                        return item;
                }
            }
            return null;
        }

        #region EVENTS
        public event EventHandler NewLoadArrive;
        public event EventHandler StoveEvent;
        public event EventHandler EmptyBoxEvent;
        public void OnNewBoxAppeared(EventArgs e)
        {
            EventHandler eventHandler = NewLoadArrive;
            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }
        public void OnStoveChangedState(EventArgs e)
        {
            EventHandler eventHandler = StoveEvent;
            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }
        public void OnEmptyBoxEvent(EventArgs e)
        {
            EventHandler eventHandler = EmptyBoxEvent;
            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }

        #endregion
    }
}

