using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ET46_CustomRender
{
    public class EllipseView : View
    {
        public static readonly BindableProperty ColorProperty = BindableProperty.Create("Color", typeof(Color), typeof(EllipseView), Color.Default);

        public Color Color
        {
            set { SetValue(ColorProperty, value); }
            get { return (Color)GetValue(ColorProperty); }
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            //return base.OnMeasure(widthConstraint, heightConstraint);
            return new SizeRequest(new Size(40, 40));
        }
    }
}
