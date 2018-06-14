using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XfTemplate.Controls.EntryControl;
using XfTemplate.iOS.Renderers.EntryControl;

[assembly:ExportRenderer(typeof(LoginEntry),typeof(LoginEntryRenderer))]
namespace XfTemplate.iOS.Renderers.EntryControl
{
    public class LoginEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.AutocapitalizationType = UITextAutocapitalizationType.None;
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}