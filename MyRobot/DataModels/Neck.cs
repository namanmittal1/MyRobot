using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobot.DataModels
{
    public class Neck
    {
        public int StartX { get; set; }

        public int StartY { get; set; }

        public int EndX { get; set; }

        public int EndY { get; set; }

        public Neck()
        {
            StartX = 150;
            StartY = 60;
            EndX = 150;
            EndY = 80;
        }

        public Neck(Neck currentNeck, Int32 difference)
            : this()
        {                  
            StartX = currentNeck.StartX + difference;
          //  StartY = currentNeck.StartY + difference;
            EndX = currentNeck.EndX + difference;
          //  EndY = currentNeck.EndY + difference;
        }
    }
}
