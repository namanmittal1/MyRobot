using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobot.DataModels
{
    public class RightLeg : Leg
    {
        public RightLeg()
        {
            StartX = 170;
            StartY =220;
            EndX = 150;
            EndY = 140;
        }

        public RightLeg(RightLeg currentLeg, Int32 difference)
            : this()
        {
            StartX = currentLeg.StartX + difference;
         //   StartY = currentLeg.StartY + difference;
            EndX = currentLeg.EndX + difference;
         //   EndY = currentLeg.EndY + difference;
        }
    }
}
