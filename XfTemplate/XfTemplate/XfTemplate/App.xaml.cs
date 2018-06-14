using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XfTemplate.Views.Login;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XfTemplate
{
	public partial class App : Application
	{
	    public static string CultureCode { get; set; }
        public App ()
		{
			InitializeComponent();
		    CultureCode = "km";
            MainPage = new LoginPage();
            //MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
