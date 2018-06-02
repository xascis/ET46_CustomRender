using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ET46_CustomRender;
using ET46_CustomRender.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EllipseView), typeof(EllipseViewRenderer))]
namespace ET46_CustomRender.Droid
{
    public class EllipseViewRenderer : ViewRenderer<EllipseView, EllipseDrawableView>
    {
        double width, height;

        public EllipseViewRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<EllipseView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                SetNativeControl(new EllipseDrawableView(Context));
            }
            if (e.NewElement != null)
            {
                SetColor();
                SetSize();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == VisualElement.WidthProperty.PropertyName)
            {
                width = Element.Width;
                SetSize();
            } else if (e.PropertyName == VisualElement.HeightProperty.PropertyName)
            {
                height = Element.Height;
                SetSize();
            } else if (e.PropertyName == EllipseView.ColorProperty.PropertyName)
            {
                SetColor();
            }
        }

        void SetColor()
        {
            Control.SetColor(Element.Color);
        }

        void SetSize()
        {
            Control.SetSize(width, height);
        }
    }
}