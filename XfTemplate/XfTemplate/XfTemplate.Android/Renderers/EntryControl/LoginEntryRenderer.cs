using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XfTemplate.Controls.EntryControl;
using XfTemplate.Droid.Renderers.EntryControl;

[assembly:ExportRenderer(typeof(LoginEntry),typeof(LoginEntryRenderer))]
namespace XfTemplate.Droid.Renderers.EntryControl
{
    public class LoginEntryRenderer : EntryRenderer
    {
        public LoginEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetHeight(25);
                Control.SetPadding(0, 23, 0, 0); // clear padding default when we set height
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
            if (e.NewElement != null)
            {
                e.NewElement.PlaceholderColor = Color.FromHex("#787878");
            }
        }
    }
}