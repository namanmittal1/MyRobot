using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MyRobot.DataModels;

namespace MyRobot
{
    public class PlaceDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RobotWithNeck { get; set; }
        public DataTemplate RobotWithoutNeck { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            Int32 val = (item as Robot).NeckValue;
            if (val == 1)
                return RobotWithNeck;
            else if (val == 2)
                return RobotWithoutNeck;

            return null;
        }
    }
}
