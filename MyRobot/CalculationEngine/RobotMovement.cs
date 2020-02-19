using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRobot.DataModels;

namespace MyRobot.CalculationEngine
{
    public class RobotMovement
    {
        public Robot MoveForward(Robot currentRobot)
        {
            return new Robot(currentRobot, 300);
        }

        public Robot MoveBackward(Robot currentRobot)
        {
            return new Robot(currentRobot, -300);
        }

        //public List<Robot> Multiply(int i, Robot currentRobot)
        //{

        //}
    }
}
