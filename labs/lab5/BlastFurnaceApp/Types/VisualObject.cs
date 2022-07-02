using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastFurnaceApp.Types
{
    public class VisualObject
    {
        public Bitmap ImageFrame;
        public Point currentPosition;
        public VisualObject(Bitmap image, Point position)
        {
            this.ImageFrame = image;
            this.currentPosition = position;                      
        }

        public Bitmap GetCurrentFrame()
        {
            return this.ImageFrame;
        }

        public int GetXPosition()
        {
            return this.currentPosition.X;
        }

        public int GetYPosition()
        {
            return this.currentPosition.Y;
        }

        public void FlipImageHorizontally()
        {
            this.ImageFrame.RotateFlip(RotateFlipType.Rotate180FlipY);
        }
    }

}
