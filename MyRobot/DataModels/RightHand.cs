using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobot.DataModels
{
    public class RightHand : Hand
    {
        public RightHand()
        {
            StartX = 220;
            StartY = 82;
           EndX = 300;
            EndY = 82;
        }

        public RightHand(RightHand currentHand, Int32 difference)
            : this()
        {
            StartX = currentHand.StartX + difference;
          //  StartY = currentHand.StartY + difference;
            EndX = currentHand.EndX + difference;
         //   EndY = currentHand.EndY + difference;
        }
    }
}
