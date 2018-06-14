using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using XfTemplate.Resx.Extensions;
using XfTemplate.UWP.DependencyServices;

[assembly: Dependency(typeof(LocaleService))]
namespace XfTemplate.UWP.DependencyServices
{
    public class LocaleService : ILocalize
    {
        public CultureInfo GetCurrentCultureInfo()
        {
            return new CultureInfo(XfTemplate.App.CultureCode);
        }
        public CultureInfo GetCurrentCultureInfo(string sLanguageCode)
        {
            return CultureInfo.CreateSpecificCulture(sLanguageCode);
        }
        public void SetLocale()
        {
            var ci = GetCurrentCultureInfo();
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            Console.WriteLine("SetLocale: " + ci.Name);
        }
        public void ChangeLocale(string sLanguageCode)
        {
            var ci = CultureInfo.CreateSpecificCulture(sLanguageCode);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            Console.WriteLine("ChangeToLanguage: " + ci.Name);
        }
    }
}
