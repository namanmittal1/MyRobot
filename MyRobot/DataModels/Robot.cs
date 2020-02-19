using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRobot.DataModels
{
    public class Robot
    {
        public Head RobotHead { get; set; }
        public Neck RobotNeck { get; set; }
        public Stomach RobotStomach { get; set; }
        public LeftHand RobotLeftHand { get; set; }
        public RightHand RobotRightHand { get; set; }
        public LeftLeg RobotLeftLeg { get; set; }
        public RightLeg RobotRightLeg { get; set; }

        public Int32 NeckValue { get; set; }

        public Robot()
        {
            RobotHead = new Head();
            RobotNeck = new Neck();
            RobotStomach = new Stomach();
            RobotLeftHand = new LeftHand();
            RobotRightHand = new RightHand();
            RobotLeftLeg = new LeftLeg();
            RobotRightLeg = new RightLeg();
            NeckValue = 1;
        }

        public Robot(Robot currentRobot, Int32 difference)
            : this()
        {
            RobotHead = new Head(currentRobot.RobotHead, difference);
            RobotNeck = new Neck(currentRobot.RobotNeck, difference);
            RobotStomach = new Stomach(currentRobot.RobotStomach, difference);
            RobotLeftHand = new LeftHand(currentRobot.RobotLeftHand, difference);
            RobotRightHand = new RightHand(currentRobot.RobotRightHand, difference);
            RobotLeftLeg = new LeftLeg(currentRobot.RobotLeftLeg, difference);
            RobotRightLeg = new RightLeg(currentRobot.RobotRightLeg, difference);
            if (difference > 0)
                NeckValue = 1;
            else if (difference < 0)
                NeckValue = 2;
        }

    }
}
