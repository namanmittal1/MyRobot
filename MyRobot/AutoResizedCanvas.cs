using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyRobot
{
    public class AutoResizedCanvas : Canvas
    {
        protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint)
        {
            base.MeasureOverride(constraint);

            double width = 0;
            double height = 0;

            if (base.InternalChildren.Count <= 0)
            {
                return new Size(width, height);
            }


            width = base
           .InternalChildren
           .OfType<UIElement>()
           .Max(i => i.DesiredSize.Width + (double)i.GetValue(Canvas.LeftProperty));

            if (Double.IsNaN(width))
            {
                width = 0;
            }

            height = base
           .InternalChildren
           .OfType<UIElement>()
           .Where(i => i.GetValue(Canvas.TopProperty) != null)
           .Max(i => i.DesiredSize.Height + (double)i.GetValue(Canvas.TopProperty));

            if (Double.IsNaN(height))
            {
                height = 0;
            }
            return new Size(width, height);
        }
    }
}
