using Xamarin.Forms;

namespace XfTemplate.Resx.Extensions
{
    public static class GetFromName
    {
        public static string ResourceId()
        {
            string resourceId = "";
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo(App.CultureCode);
            switch (ci.Name)
            {
                case "km-KH":
                    resourceId = "XfTemplate.Resx.AppResource.kh";
                    break;
                case "en-US":
                    resourceId = "XfTemplate.Resx.AppResource";
                    break;
            }
            return resourceId;
        }
    }
}
