using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XfTemplate.Controls.EntryControl;
using XfTemplate.UWP.Renderers.EntryControl;

[assembly: ExportRenderer(typeof(LoginEntry), typeof(LoginEntryRenderer))]
namespace XfTemplate.UWP.Renderers.EntryControl
{
    public class LoginEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0,0,0,0);
                Control.Background = new SolidColorBrush(Colors.Transparent);
                Control.BackgroundFocusBrush = new SolidColorBrush(Colors.Transparent);
            }
        }
    }
}
