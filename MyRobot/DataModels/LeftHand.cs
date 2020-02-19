using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobot.DataModels
{
    public class LeftHand : Hand
    {       
        public LeftHand()
        {
            StartX = 80;
            StartY = 82;
            EndX = 10;
            EndY = 82;
        }
        public LeftHand(LeftHand currentHand, Int32 difference)
            : this()
        {
            StartX = currentHand.StartX + difference;
          //  StartY = currentHand.StartY + difference;
            EndX = currentHand.EndX + difference;
          //  EndY = currentHand.EndY + difference;
        }
    }
}
