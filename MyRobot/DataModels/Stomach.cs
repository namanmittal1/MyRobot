using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobot.DataModels
{
    public class Stomach
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public Stomach()
        {
            Width = 140;
            Height = 60;
            X = 80;
            Y = 80;
        }

        public Stomach(Stomach currentStomach, Int32 difference)
            : this()
        {
            X = currentStomach.X + difference;
          //  Y = currentStomach.Y + difference;
        }
    }
}
