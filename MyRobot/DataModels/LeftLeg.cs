using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobot.DataModels
{
    public class LeftLeg :Leg
    {
        public LeftLeg()
        {
            StartX = 120;
            StartY = 220;
           EndX = 150;
            EndY = 140;
        }

        public LeftLeg(LeftLeg currentLeg, Int32 difference)
            : this()
        {
            StartX = currentLeg.StartX + difference;
           // StartY = currentLeg.StartY + difference;
            EndX = currentLeg.EndX + difference;
           // EndY = currentLeg.EndY + difference;
        }

    }
}
