using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobot.DataModels
{
    public class Head
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public Head()
        {
            Width = 100;
            Height = 50;
            X = 100;
            Y = 10;
        }

        public Head(Head currentHead, Int32 difference)
            :  this()
        {
            X = currentHead.X + difference;
          //  Y = currentHead.Y + difference;
        }

    }
}
