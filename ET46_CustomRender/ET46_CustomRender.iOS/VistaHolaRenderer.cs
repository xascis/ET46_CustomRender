using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using ET46_CustomRender;
using Xamarin.Forms;
using ET46_CustomRender.iOS;

[assembly: ExportRenderer(typeof(VistaHola), typeof(VistaHolaRenderer))]

namespace ET46_CustomRender.iOS
{
    public class VistaHolaRenderer : ViewRenderer<VistaHola, UILabel>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<VistaHola> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                UILabel label = new UILabel
                {
                    Text = "Hola desde iOS con CustomRender",
                    Font = UIFont.SystemFontOfSize(24)
                };
                SetNativeControl(label);
            }
        }
    }
}