using System;
using System.Collections.Generic;
using System.Drawing;

using BlastFurnaceModel;
using BlastFurnaceApp.Models;

namespace BlastFurnaceApp
{
    public partial class MainForm : Form
    {
        #region FIELDS
        public FormController FormController;
        private Bitmap ImageBox;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            ImageBox = Properties.Resources.box;
            this.Size = new Size(1280, 800);
            this.FormController = new FormController(LoggerBox);
        }

        #region METHODS
        private void PaintFactory(Graphics g, int width)
        {
            g.DrawImage(Properties.Resources.Factory, 0, 3, width, 300);
        }
        private void PaintBoxStore(Graphics g)
        {
            int count = FormController.BoxContainer.Count;
            int X = FormController.BoxStrorePos.X;
            int Y = FormController.BoxStrorePos.Y;
            int boxHeigth = ImageBox.Height;
            int boxWidth = ImageBox.Width;

            for (int i = 0; i < count; i++)
            {
                X += boxWidth + 5;
                if (i % 3 == 0)
                {
                    X = FormController.BoxStrorePos.X;
                    Y -= (boxHeigth + 5);
                }
                g.DrawImage(ImageBox, X, Y);
            }
        }
        private void PaintStove(Graphics g, int MaxWidth)
        {
            foreach (StoveModel item in FormController.FurnaceContainer)
            {
                if (item.GetCurrentFrame() != null)
                    item.currentPosition.X = MaxWidth - (item.GetCurrentFrame().Width + 25);
                g.DrawImage(item.GetCurrentFrame(), item.GetXPosition(), item.GetYPosition());
                PaintLabel(item);
            }
        }
        private void PaintWorkers(Graphics g)
        {
            foreach (WorkerModel item in FormController.WorkerContainer)
            {
                if (item.GetCurrentFrame() != null && !item.IsInside)
                    g.DrawImage(item.GetCurrentFrame(), item.GetXPosition(), item.GetYPosition());
            }
        }
        private void PaintLoaders(Graphics g)
        {
            foreach (LoaderModel item in FormController.LoaderContainer)
            {
                if (item.GetCurrentFrame() != null)
                    g.DrawImage(item.GetCurrentFrame(), item.GetXPosition(), item.GetYPosition());
            }
        }
        private void PaintLabel(StoveModel item)
        {
            if (item.ModelObject.Index == 0)
            {
                if (item.IsWork)
                {
                    this.label1.BackColor = Color.Lime;
                    this.label1.Text = "Ðàáîòàþ";
                }
                else
                {
                    this.label1.BackColor = Color.Red;
                    this.label1.Text = "Ïåðåãðåëàñü";
                }
                this.label1.Location = new Point(item.GetXPosition() - 40, item.GetYPosition() + 40);
                this.label1.Visible = true;
            }
            else
            {
                if (item.IsWork)
                {
                    this.label2.BackColor = Color.Lime;
                    this.label2.Text = "Ðàáîòàþ";
                }
                else
                {
                    this.label2.BackColor = Color.Red;
                    this.label2.Text = "Ïåðåãðåëàñü";
                }
                this.label2.Location = new Point(item.GetXPosition() - 40, item.GetYPosition() + 40);
                this.label2.Visible = true;
            }
        }

        public void LoggerBox(string message)
        {
            textBox1.Invoke((MethodInvoker)delegate
            {
                textBox1.Text += message + "\r\n";
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Task.Run(() => FormController.AddBoxes(1));

            foreach (StoveModel item in FormController.FurnaceContainer)
            {
                item.Temperature += random.Next(5, 50);
            }
        }
        #endregion

        #region EVENT HANDLERS
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormController.Init();
            Task.Run(() =>
            {
                Thread.Sleep(1600);
                FormController.WorkerAdd();
            });
            Task.Run(() =>
            {
                Thread.Sleep(2300);
                FormController.LoaderAdd("MIDDLE");
            });
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int MaxWidth = this.ClientSize.Width;
            PaintFactory(g, MaxWidth);
            PaintStove(g, MaxWidth);
            PaintBoxStore(g);
            PaintWorkers(g);
            PaintLoaders(g);

        }

        private void ðàáî÷åãîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormController.WorkerAdd();
        }

        private void ïå÷üToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormController.FurnaceAdd();
        }

        private void æóðíàëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Visible == false)
                this.textBox1.Visible = true;
            else
                this.textBox1.Visible = false;
        }

        private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ñèìóëÿòîð Äîìåíàÿ ïå÷ü \n" + '\u00A9' + "Àííà Ìîëîäàÿ",
                            "Î ïðîãðàììå",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }

        private void áîëüøîéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(() => FormController.LoaderAdd("BIG"));
        }
        private void ñðåäíèéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(() => FormController.LoaderAdd("MIDDLE"));
        }

        private void øóñòðûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(() => FormController.LoaderAdd("FAST"));
        }

        #endregion

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox1.Visible = false;
        }
    }
}