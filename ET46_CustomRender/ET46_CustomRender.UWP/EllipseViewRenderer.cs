using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;
using Xamarin.Forms;
using ET46_CustomRender.UWP;
using ET46_CustomRender;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(EllipseView), typeof(EllipseViewRenderer))]
namespace ET46_CustomRender.UWP
{
    public class EllipseViewRenderer : ViewRenderer<EllipseView, Ellipse>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<EllipseView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                SetNativeControl(new Ellipse());
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
            if (Element.Color == Xamarin.Forms.Color.Default)
            {
                Control.Fill = null;
            } else
            {
                Xamarin.Forms.Color color = Element.Color;
                Windows.UI.Color wincolor = Windows.UI.Color.FromArgb((byte)(color.A * 255), (byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255));
                Control.Fill = new SolidColorBrush(wincolor);

            }
        }
    }

}
