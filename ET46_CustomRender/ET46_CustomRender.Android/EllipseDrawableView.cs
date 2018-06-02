﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ET46_CustomRender.Droid
{
    public class EllipseDrawableView : View
    {
        ShapeDrawable shapeDrawable;

        public EllipseDrawableView(Context context) : base(context)
        {
            shapeDrawable = new ShapeDrawable(new OvalShape());
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            shapeDrawable.Draw(canvas);
        }

        public void SetColor(Xamarin.Forms.Color color)
        {
            shapeDrawable.Paint.SetARGB((int)(255 * color.A), (int)(255 * color.R), (int)(255 * color.G), (int)(255 * color.B));
            Invalidate();
        }

        public void SetSize(double width, double height)
        {
            float pixelPerDip = Resources.DisplayMetrics.Density;
            shapeDrawable.SetBounds(0, 0, (int)(width * pixelPerDip), (int)(height * pixelPerDip));
            Invalidate();
        }
    }

}