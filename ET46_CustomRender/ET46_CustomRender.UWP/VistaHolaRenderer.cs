using ET46_CustomRender;
using ET46_CustomRender.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(VistaHola), typeof(VistaHolaRenderer))]

namespace ET46_CustomRender.UWP
{
    public class VistaHolaRenderer : ViewRenderer<VistaHola, TextBlock>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<VistaHola> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                SetNativeControl(new TextBlock
                {
                    Text = "Hola desde UWP con Custom Renderer!",
                    FontSize = 24
                });
            }
        }
    }
}
