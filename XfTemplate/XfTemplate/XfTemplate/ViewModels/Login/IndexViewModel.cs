using System.Windows.Input;
using Xamarin.Forms;
using XfTemplate.Helpers.Constants;
using XfTemplate.Helpers.Notify;
using XfTemplate.Views.Login;

namespace XfTemplate.ViewModels.Login
{
    public class IndexViewModel : BaseModel
    {
        private string _domain = string.Empty;
        private string _user = string.Empty;
        private string _pass = string.Empty;
        private bool _isBusy;
        private bool _isBtn = true;
        private bool _isRemember;
        public bool IsActiveFrom;



        public ImageSource LogoIco => ImageSource.FromResource(ContantIcons.Logo);
        public string DomainIco => ContantIcons.AllDomain;
        public string UserNameIco => ContantIcons.AllUsername;
        public string PasswordIco => ContantIcons.AllPassword;
        public string EnglishIco => ContantIcons.EnglishFlag;
        public string KhmerIco => ContantIcons.KhmerFlag;

        public string Domain
        {
            set
            {
                if (_domain == value) return;
                _domain = value;
                OnPropertyChanged();
            }
            get => _domain;
        }
        public string UserName
        {
            set
            {
                if (_user == value) return;
                _user = value;
                OnPropertyChanged();
            }
            get => _user;
        }
        public string Password
        {
            set
            {
                if (_pass == value) return;
                _pass = value;
                OnPropertyChanged();
            }
            get => _pass;
        }
        public bool IsBtnEnable
        {
            set
            {
                if (_isBtn == value) return;
                _isBtn = value;
                OnPropertyChanged();
            }
            get => _isBtn;
        }
        public bool IsBusy
        {
            set
            {
                if (_isBusy == value) return;
                _isBusy = value;
                OnPropertyChanged();
            }
            get => _isBusy;
        }
        public bool IsRemember
        {
            set
            {
                if (_isRemember == value) return;
                _isRemember = value;
                OnPropertyChanged();
            }
            get => _isRemember;
        }

        public ICommand LoginCommand => new Command(() =>
        {
            
        });
        public ICommand ResetCommand => new Command(() =>
        {
           
        });
        public ICommand EnglishCommand => new Command(() =>
        {
            Application.Current.MainPage = new LoginPage();
        });
        public ICommand KhmerCommand => new Command(() =>
        {
            Application.Current.MainPage = new LoginPage();
        });
    }
}
