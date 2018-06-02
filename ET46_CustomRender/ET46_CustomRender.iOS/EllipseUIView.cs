using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;

namespace ET46_CustomRender.iOS
{
    class EllipseUIView : UIView
    {
        UIColor color = UIColor.Clear;

        public EllipseUIView()
        {
            BackgroundColor = UIColor.Clear;
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            using(CGContext graphics = UIGraphics.GetCurrentContext())
            {
                CGPath path = new CGPath();
                path.AddEllipseInRect(rect);
                path.CloseSubpath();
                color.SetFill();
                graphics.AddPath(path);
                graphics.DrawPath(CGPathDrawingMode.Fill);

            }
        }

        public void SetColor(UIColor color)
        {
            this.color = color;
            SetNeedsDisplay();
        }
    }
}