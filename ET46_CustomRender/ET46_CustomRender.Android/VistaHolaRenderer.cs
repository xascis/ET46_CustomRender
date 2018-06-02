using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using ET46_CustomRender;
using ET46_CustomRender.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(VistaHola), typeof(VistaHolaRenderer))]

namespace ET46_CustomRender.Droid
{
    public class VistaHolaRenderer : ViewRenderer<VistaHola, TextView>
    {
        public VistaHolaRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<VistaHola> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new TextView(Context)
                {
                    Text = "Hola desde Android con Custom Renderer"
                });
                Control.SetTextSize(Android.Util.ComplexUnitType.Sp, 24);
            }
        }
    }
}