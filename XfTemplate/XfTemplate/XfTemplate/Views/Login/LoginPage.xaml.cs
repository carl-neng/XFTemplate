using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XfTemplate.ViewModels.Login;

namespace XfTemplate.Views.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent ();
		    BindingContext = new IndexViewModel();

		}
	}
}