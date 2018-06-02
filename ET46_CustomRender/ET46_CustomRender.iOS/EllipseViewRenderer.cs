using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ET46_CustomRender;
using ET46_CustomRender.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EllipseView), typeof(EllipseViewRenderer))]
namespace ET46_CustomRender.iOS
{
    public class EllipseViewRenderer : ViewRenderer<EllipseView, EllipseUIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<EllipseView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                SetNativeControl(new EllipseUIView());
            }
            if (e.NewElement != null)
            {
                SetColor();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == EllipseView.ColorProperty.PropertyName)
            {
                SetColor();
            }
        }

        void SetColor()
        {
            if (Element.Color != Color.Default)
            {
                Control.SetColor(Element.Color.ToUIColor());
            } else
            {
                Control.SetColor(UIColor.Clear);
            }
        }
    }
}